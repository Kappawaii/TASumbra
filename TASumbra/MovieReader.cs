using System;
using System.Collections.Generic;
using System.Data;
using WindowsInput.Native;

namespace TASumbra
{
    class MovieReader
    {
        Dictionary<string, VirtualKeyCode> dicKeyBinds;
        readonly string[] Keys =
            {
            "Run", "Forwards", "Backwards", "Left", "Right",
            "LMB", "RMB", "Crouch", "Inventory"
            };
        readonly VirtualKeyCode[] Binds =
            {
            VirtualKeyCode.LSHIFT, VirtualKeyCode.VK_Z, VirtualKeyCode.VK_S, VirtualKeyCode.VK_Q, VirtualKeyCode.VK_D,
            VirtualKeyCode.LBUTTON, VirtualKeyCode.RBUTTON, VirtualKeyCode.LCONTROL, VirtualKeyCode.TAB
            };
        readonly string[] Axes =
            {
            "MouseX", "MouseY"
            };

        public MovieReader()
        {
            dicKeyBinds = new Dictionary<string, VirtualKeyCode>();
            for (int i = 0; i < Keys.Length; i++)
            {
                dicKeyBinds.Add(Keys[i], Binds[i]);
            }
        }

        public List<Tuple<string, VirtualKeyCode, object>> ReadMovieRow(DataRow row)
        {
            List<Tuple<string, VirtualKeyCode, object>> tuples = new List<Tuple<string, VirtualKeyCode, object>>();
            foreach (string columnName in Keys)
            {
                string cellValue = row[columnName].ToString();
                if (cellValue != "/")
                {
                    tuples.Add(new Tuple<string, VirtualKeyCode, object>(columnName, dicKeyBinds[columnName], cellValue));
                }
            }
            foreach (string columnName in Axes)
            {
                int cellValue;
                try
                {
                    cellValue = int.Parse(row[columnName].ToString());
                }
                catch (Exception e)
                {
                    if (e is FormatException || e is OverflowException)
                    {
                        cellValue = 0;
                    }
                    throw;
                }
                if (cellValue.ToString() != "")
                {
                    tuples.Add(new Tuple<string, VirtualKeyCode, object>(columnName, VirtualKeyCode.NONAME, cellValue));
                }
            }
            return tuples;
        }
    }
}
