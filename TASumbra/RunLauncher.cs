using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using WindowsInput.Native;

namespace TASumbra
{
    class RunLauncher
    {
        private MemoryReader memoryReader;
        Thread gameClockRefresherThread;

        private Label gameClockLabel;
        private Label frames;
        private int currentFrame = 0;
        private Label fps;
        private int fpsTemp = 0;
        private Label performanceText;

        private Label timerDelayLabel;

        private DataTable dt;
        private MovieReader movieReader;
        private InputManager inputManager;

        private readonly int maxFrame = 0;

        public bool runStarted = false;
        public bool finished = false;

        public string penumbraPath;

        private float targetclock = 0f;

        public void Destroy()
        {
            try
            {
                gameClockRefresherThread.Abort();
            }
            catch (Exception)
            {

                throw;
            }
            memoryReader.Destroy();
        }

        public void Destroy(object sender, EventArgs e)
        {
            Destroy();
        }

        public RunLauncher(DataTable dt, string gamePath, Label gameClockLabel, Label frames, Label fps, Label performanceText, Label timerDelayLabel)
        {
            penumbraPath = gamePath;
            memoryReader = new MemoryReader();
            this.gameClockLabel = gameClockLabel;
            this.frames = frames;
            this.fps = fps;
            this.performanceText = performanceText;
            this.dt = dt;
            this.timerDelayLabel = timerDelayLabel;
            maxFrame = dt.Rows.Count;
            movieReader = new MovieReader();
            inputManager = new InputManager();
        }

        public bool Start()
        {
            if (!memoryReader.InitPenumbraMemoryReader())
            {
                return false;
            }
            gameClockRefresherThread = new Thread(GameClockRefresher);
            Application.ApplicationExit += Destroy;
            gameClockRefresherThread.Start();
            return true;
        }

        public void GameClockRefresher()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            long stopwatchtime = 0;
            long fpsCalcTemp = 1;
            long i = 0;
            float oldgameClock = 0f;
            float gameClock;
            dontCare:
            if (finished)
            {
                return;
            }
            //stopwatchtime = stopWatch.ElapsedTicks;
            gameClockLabel.Invoke(new MethodInvoker(delegate
            {
                i++;
                gameClock = memoryReader.GetGameClock();
                if (gameClock > oldgameClock)
                {
                    if (stopwatchtime > fpsCalcTemp * 10000000)
                    {
                        FramesPerSecond();
                        fpsCalcTemp++;
                    }
                    oldgameClock = gameClock;
                    gameClockLabel.Text = gameClock.ToString();
                    NextFrame();
                    timerDelayLabel.Text = "" + (gameClock - targetclock);
                    while (gameClock - targetclock > 0.01666666666666666666666666666667f)
                    {
                        NextFrame();
                    }
                }
                performanceText.Text = ((stopWatch.ElapsedTicks - stopwatchtime) / 10).ToString() + "µs";
                stopwatchtime = stopWatch.ElapsedTicks;
            }));
            Thread.Sleep(1);
            goto dontCare;
        }

        public void NextFrame()
        {
            targetclock += 0.01666666666666666666666666666667f;
            frames.Text = (++currentFrame).ToString();
            fpsTemp++;
            if (currentFrame < maxFrame)
            {
                List<Tuple<string, VirtualKeyCode, object>> inputs = movieReader.ReadMovieRow(dt.Rows[currentFrame]);
                inputManager.MultipleInputs(inputs);
                //Console.WriteLine(dt.Rows.Count);
            }
            else
            {
                finished = true;
            }
        }

        public void FramesPerSecond()
        {
            fps.Text = fpsTemp.ToString();
            fpsTemp = 0;
        }
    }
}
