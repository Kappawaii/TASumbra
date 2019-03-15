using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace TASumbra
{
    class MemoryReader
    {
        private const int PROCESS_WM_READ = 0x0010;
        private const int clockFirstAddr = 0x2DCAF0;
        private const int clockOffset1 = 0x188;
        private const int clockOffset2 = 0x4C;
        private const int clockOffset3 = 0x1C;

        int penumbraHandle;
        Process process;

        byte[] buffer = new byte[4];
        int bytesRead = 0;

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern IntPtr CloseProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        public void Destroy()
        {
            try
            {
                CloseProcess(PROCESS_WM_READ, false, process.Id);
            }
            catch (Exception)
            {

            }
        }

        public bool InitPenumbraMemoryReader()
        {
            Process[] processes = Process.GetProcessesByName("Penumbra");
            if (processes.Length < 1)
            {
                return false;
            }
            process = processes[0];
            penumbraHandle = (int)OpenProcess(PROCESS_WM_READ, false, process.Id);
            return true;
        }

        public float GetGameClock()
        {
            //get first pointer addr
            ReadProcessMemory(penumbraHandle, 0x6DCAF0, buffer, buffer.Length, ref bytesRead);
            // follow pointer path with offsets (thanks Kotti)
            ReadProcessMemory(penumbraHandle, BitConverter.ToInt32(buffer, 0) + 0x188, buffer, buffer.Length, ref bytesRead);
            ReadProcessMemory(penumbraHandle, BitConverter.ToInt32(buffer, 0) + 0x4C, buffer, buffer.Length, ref bytesRead);
            ReadProcessMemory(penumbraHandle, BitConverter.ToInt32(buffer, 0) + 0x1C, buffer, buffer.Length, ref bytesRead);
            return BitConverter.ToSingle(buffer, 0);
        }
    }
}
