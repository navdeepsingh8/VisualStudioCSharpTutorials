// PInvokeTest.cs
using System;
using System.Runtime.InteropServices;

class PlatformInvokeTest
{
    [DllImport("user32.dll",   EntryPoint="MessageBox", CharSet = CharSet.Unicode)]
    public static extern int MBox(IntPtr hWnd, String text, String caption, uint type);


    public static void Main()
    {
        //puts("Test");
        //_flushall();
        MBox(new IntPtr(0), "Hello World!", "Hello Dialog",0);
    }
}