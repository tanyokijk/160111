using System;
using System.Runtime.InteropServices;
namespace SimpleProject
{
    public class DllImportExample
    {
        [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern int MessageBoxW(IntPtr hWnd, string text, string caption, uint type);
    }
    class Program
    {
        static void Main(string[] args)
        {
            DllImportExample.MessageBoxW(IntPtr.Zero, "Випробовування пройшло успішно", "Тест DllImportAttribute", 0);
        }
    }
}
