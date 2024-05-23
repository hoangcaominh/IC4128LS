using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace IC4128LS
{
    internal class THProcess
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesRead);

        private IntPtr handle;

        public IntPtr Handle { get => handle; }

        public bool FindProcess()
        {
            var proc = Process.GetProcessesByName("th128");
            if (proc.Length > 0)
            {
                // PROCESS_VM_READ (0x10)
                handle = OpenProcess(0x10, false, proc.FirstOrDefault().Id);
                return handle != null;
            }
            else
            {
                return false;
            }
        }

        public void ReadMemory(uint address, int offset, int size, ref byte target)
        {
            byte[] buffer = new byte[1];
            IntPtr bytesRead = IntPtr.Zero;
            bool read = ReadProcessMemory(handle, (IntPtr)(address + offset), buffer, size, out bytesRead);
            target = buffer[0];
        }

        public void ReadMemory(uint address, int offset, int size, ref ushort target)
        {
            byte[] buffer = new byte[2];
            IntPtr bytesRead = IntPtr.Zero;
            bool read = ReadProcessMemory(handle, (IntPtr)(address + offset), buffer, size, out bytesRead);
            target = BitConverter.ToUInt16(buffer, 0);
        }

        public void ReadMemory(uint address, int offset, int size, ref int target)
        {
            byte[] buffer = new byte[4];
            IntPtr bytesRead = IntPtr.Zero;
            bool read = ReadProcessMemory(handle, (IntPtr)(address + offset), buffer, size, out bytesRead);
            target = BitConverter.ToInt32(buffer, 0);
        }

        public void ReadMemory(uint address, int offset, int size, ref uint target)
        {
            byte[] buffer = new byte[4];
            IntPtr bytesRead = IntPtr.Zero;
            bool read = ReadProcessMemory(handle, (IntPtr)(address + offset), buffer, size, out bytesRead);
            target = BitConverter.ToUInt32(buffer, 0);
        }
    }
}
