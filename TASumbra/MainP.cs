using System;
using System.Diagnostics;
using WindowsInput;
using System.Windows.Forms;

namespace TASumbra
{
    class MainP
    {
        [STAThread]
        static void Main(string[] args)
        {
            //InputSimulator inputSimulator = new InputSimulator();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppGUI());
            //RunTest(inputSimulator);
            //Application.Exit();
            /*
            NOP(3.0);
            i.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
            i.Keyboard.KeyDown(VirtualKeyCode.VK_Z).Sleep(1000).KeyUp(VirtualKeyCode.VK_Z);
            i.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);
            for (int no = 0; no < 13; no++)
            {
                i.Mouse.MoveMouseBy(30, 0);
                NOP(16667);
            }*/
        }

        private static void RunTest(InputSimulator inputSimulator)
        {
            Mouse mouse = new Mouse(inputSimulator);

            NOP(800000);
            mouse.Move(45, 2, 150);
            //mouse.move(225, 2, 100);
            /*for(int i = 0; i< 360; i++)
            {
                mouse.move(i, 2, 100);
                NOP(16667);
                mouse.move(-i, 2, 100);
            }*/
        }

        /// <summary>
        /// pause during n seconds
        /// </summary>
        /// <param name="durationSeconds"></param>
        public static void NOP(double durationSeconds)
        {
            var durationTicks = Math.Round(durationSeconds * Stopwatch.Frequency);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedTicks < durationTicks)
            {

            }
        }

        /// <summary>
        /// pause during n microseconds
        /// </summary>
        /// <param name="microsecs"></param>
        public static void NOP(int microsecs)
        {
            double durationSeconds = ((double)microsecs) / 1000000;
            var durationTicks = Math.Round(durationSeconds * Stopwatch.Frequency);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedTicks < durationTicks)
            {

            }
        }
    }
}