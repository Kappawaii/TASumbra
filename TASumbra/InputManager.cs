using System;
using System.Collections.Generic;
using WindowsInput;
using WindowsInput.Native;

namespace TASumbra
{
    class InputManager
    {
        private InputSimulator inputSimulator;

        public InputManager()
        {
            inputSimulator = new InputSimulator();
        }

        public void MultipleInputs(List<Tuple<string, VirtualKeyCode, object>> inputs)
        {
            int mouseX = 0;
            int mouseY = 0;
            foreach (Tuple<string, VirtualKeyCode, object> tuple in inputs)
            {
                if (tuple.Item3 is string item3String)
                {
                    if (item3String == "Up")
                    {
                        Console.WriteLine(tuple.Item2+"Up");
                        inputSimulator.Keyboard.KeyUp(tuple.Item2);
                    }
                    else if (item3String == "Down")
                    {
                        Console.WriteLine(tuple.Item2 + "Down");
                        inputSimulator.Keyboard.KeyDown(tuple.Item2);
                    }
                    else
                    {
                        Console.WriteLine("Unknown value :" + tuple.Item3.ToString() + ";" + tuple.Item3.GetType());
                    }
                }
                else if (tuple.Item3 is int item3Int)
                {
                    if(tuple.Item1 == "MouseX")
                    {
                        mouseX += item3Int;
                    }
                    else if (tuple.Item1 == "MouseY")
                    {
                        mouseY += item3Int;
                    }
                    else
                    {
                        Console.WriteLine("Unknown value :" + tuple.Item1.ToString());
                    }
                }
            }
            MouseMoveXY(mouseX, mouseY);
        }
        /*
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_Z).Sleep(1000).KeyUp(VirtualKeyCode.VK_Z);
            inputSimulator.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);
            for (int no = 0; no < 13; no++)
            {
                inputSimulator.Mouse.MoveMouseBy(30, 0);
            }
        */
        public void KeyDown(VirtualKeyCode key)
        {
            inputSimulator.Keyboard.KeyDown(key);
        }

        public void KeyUp(VirtualKeyCode key)
        {
            inputSimulator.Keyboard.KeyUp(key);
        }

        public void MouseMoveXY(int x, int y)
        {
            inputSimulator.Mouse.MoveMouseBy(x, y);
        }

        public void Scroll(int scrollAmount)
        {
            inputSimulator.Mouse.VerticalScroll(scrollAmount);
        }
    }
}
