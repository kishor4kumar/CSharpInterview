using System;
using System.Runtime.InteropServices;

namespace Patterns
{
    public class Printer : IDisposable
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string libraryName);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);

        private IntPtr hModule;
        private IntPtr handleGetPrinterInfo;

        public Printer()
        {
            hModule = LoadLibrary("PrinterInfo.dll");
            handleGetPrinterInfo = GetProcAddress(hModule, "getPrinterInfo");
        }

        public void DisplayPrinterDetails()
        {

        }

        public void Dispose()
        {
        }
    }
}
