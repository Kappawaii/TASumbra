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
        Thread hardwareKeyListener;
        
        private Label gameFramesLabel;
        private Label gameClockLabel;
        private int currentFrame = 0;
        private int frameOfGameStart = 0;
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


        public void Reset()
        {
            Destroy();
        }

        public void Destroy()
        {
            try
            {
                gameClockRefresherThread.Abort();
                hardwareKeyListener.Abort();
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

        public RunLauncher(DataTable dt, string gamePath, Label gameFramesLabel, Label gameClockLabel, Label fps, Label performanceText, Label timerDelayLabel)
        {
            penumbraPath = gamePath;
            memoryReader = new MemoryReader();
            this.gameFramesLabel = gameFramesLabel;
            this.gameClockLabel = gameClockLabel;
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
            hardwareKeyListener = new Thread(HardwareKeyListener);
            Application.ApplicationExit += Destroy;
            hardwareKeyListener.Start();
            gameClockRefresherThread.Start();
            return true;
        }

        private void HardwareKeyListener()
        {
            gotoBestLoop:
            if (inputManager.InputDeviceStateAdaptor.IsHardwareKeyDown(VirtualKeyCode.DELETE))
            {
                finished = true;
            }
            Thread.Sleep(10);
            goto gotoBestLoop;
        }

        private void GameClockRefresher()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            long stopwatchtime = 0;
            long fpsCalcTemp = 1;
            long i = 0;
            float oldgameClock = 0f;
            int oldFrameCount = 0;
            float gameClock;
            int gameFrameCount;
            dontCare:
            if (finished)
            {
                inputManager.Reset();
                return;
            }
            //stopwatchtime = stopWatch.ElapsedTicks;
            gameFramesLabel.Invoke(new MethodInvoker(delegate
            {
                i++;
                gameClock = memoryReader.GetGameClock();
                gameFrameCount = memoryReader.GetFrameCount();
                if ((gameClock == 0 && oldgameClock == 0) || oldgameClock > gameClock)
                {
                    timerDelayLabel.Text = Math.Abs(gameClock - oldgameClock).ToString();
                    currentFrame = 0;
                    oldFrameCount = 0;
                    frameOfGameStart = gameFrameCount;
                }
                oldgameClock = gameClock;
                currentFrame = gameFrameCount - frameOfGameStart;
                if (currentFrame > oldFrameCount)
                {
                    if (stopwatchtime > fpsCalcTemp * 10000000)
                    {
                        FramesPerSecond();
                        fpsCalcTemp++;
                    }
                    //timerDelayLabel.Text = "Currentframe made step of " + (currentFrame - oldFrameCount);
                    if (currentFrame - oldFrameCount > 1)
                    {
                        timerDelayLabel.Text = "Step delay of: " + (currentFrame - oldFrameCount) + ", performance was: " + ((stopWatch.ElapsedTicks - stopwatchtime) / 10).ToString() + "µs";
                    }
                    oldFrameCount = currentFrame;
                    //gameFramesLabel.Text = gameClock.ToString();
                    gameFramesLabel.Text = currentFrame.ToString();
                    gameClockLabel.Text = gameClock.ToString();
                    NextFrame();
                    //timerDelayLabel.Text = "";
                }
                performanceText.Text = ((stopWatch.ElapsedTicks - stopwatchtime) / 10).ToString() + "µs";
                stopwatchtime = stopWatch.ElapsedTicks;
            }));
            //Thread.Sleep(1);
            goto dontCare;
        }

        public void NextFrame()
        {
            fpsTemp++;
            if (currentFrame < maxFrame)
            {
                List<Tuple<string, VirtualKeyCode, object>> inputs = movieReader.ReadMovieRow(dt.Rows[currentFrame]);
                inputManager.MultipleInputs(inputs);
                //Console.WriteLine(dt.Rows.Count);
            }
            else
            {
                //finished = true;
            }
        }

        public void FramesPerSecond()
        {
            fps.Text = fpsTemp.ToString();
            fpsTemp = 0;
        }
    }
}
