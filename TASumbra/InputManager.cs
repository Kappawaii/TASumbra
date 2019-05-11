using System;
using System.Collections.Generic;
using WindowsInput;
using WindowsInput.Native;

namespace TASumbra
{
    class InputManager
    {
        private InputSimulator inputSimulator;
        private readonly IMouseSimulator mouse;
        private readonly IKeyboardSimulator keyboard;

        public IInputDeviceStateAdaptor InputDeviceStateAdaptor
        {
            get => inputSimulator.InputDeviceState;
        }

        public InputManager()
        {
            inputSimulator = new InputSimulator();
            mouse = inputSimulator.Mouse;
            keyboard = inputSimulator.Keyboard;
        }

        public void MultipleInputs(List<Tuple<string, VirtualKeyCode, object>> inputs)
        {
            int mouseX = 0;
            int mouseY = 0;
            foreach (Tuple<string, VirtualKeyCode, object> tuple in inputs)
            {
                if (tuple.Item3 is string item3String)
                {
                    Console.WriteLine(tuple.Item1);
                    if (tuple.Item1.EndsWith("MB"))
                    {
                        if (tuple.Item1.StartsWith("L"))
                        {
                            if (item3String.Equals("Up"))
                            {
                                LMBUp();
                            }
                            else if (item3String.Equals("Down"))
                            {
                                LMBDown();
                            }
                        }
                        else if (tuple.Item1.StartsWith("R"))
                        {
                            if (item3String.Equals("Up"))
                            {
                                RMBUp();
                            }
                            else if (item3String.Equals("Down"))
                            {
                                RMBDown();
                            }
                        }
                    }
                    else if (item3String == "Up")
                    {
                        Console.WriteLine(tuple.Item2+"Up");
                        KeyUp(tuple.Item2);
                    }
                    else if (item3String == "Down")
                    {
                        Console.WriteLine(tuple.Item2 + "Down");
                        KeyDown(tuple.Item2);
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

        public void Reset()
        {
            foreach (VirtualKeyCode keyCode in Enum.GetValues(typeof(VirtualKeyCode)))
            {
                keyboard.KeyUp(keyCode);
            }
            RMBUp();
            LMBUp();
        }

        public void KeyDown(VirtualKeyCode key)
        {
            keyboard.KeyDown(key);
        }

        public void KeyUp(VirtualKeyCode key)
        {
            keyboard.KeyUp(key);
        }

        public void LMBDown()
        {
            mouse.LeftButtonDown();
        }

        public void LMBUp()
        {
            mouse.LeftButtonUp();
        }

        public void RMBDown()
        {
            mouse.RightButtonDown();
        }

        public void RMBUp()
        {
            mouse.RightButtonUp();
        }

        public void MouseMoveXY(int x, int y)
        {
            mouse.MoveMouseBy(x, y);
        }

        public void Scroll(int scrollAmount)
        {
            mouse.VerticalScroll(scrollAmount);
        }
    }
}
