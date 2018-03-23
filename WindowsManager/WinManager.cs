using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Threading;

namespace WindowManager
{
    public class WinManager
    {
        private IntPtr WinPtr = IntPtr.Zero;

        private const string TMWindowName = "Tactical Monsters Rumble Arena";

        public WinManager()
        {
            GetTMWindow();
        }

        public IntPtr GetTMWindow()
        {
            if (WinPtr != IntPtr.Zero)
                return WinPtr;

            IntPtr wPtr = GetWindowByName(TMWindowName);

            if (wPtr == IntPtr.Zero)
            {
                throw new Exception("Cannot find TM window!");
            }

            WinPtr = GetWindowByName(TMWindowName);

            return WinPtr;
        }

        public Bitmap GetScreenPart(int top, int left, int width, int height)
        {
            User32.Rect rect = new User32.Rect();

            User32.GetWindowRect(WinPtr, ref rect);

            var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(rect.left + left, rect.top + top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);

            //bmp.Save("c:\\tmp\\test.png", ImageFormat.Png);

            return bmp;
        }

        public bool VerifyPart(string partName)
        {
            TMScreens tmScreens = new TMScreens();

            TMPart part = tmScreens.GetPart(partName);

            Bitmap bitmap = GetScreenPart(part.Position.Top, part.Position.Left, part.Position.Width, part.Position.Height);

            return tmScreens.CompareImages(part, bitmap);
        }

        public bool VerifyPart(TMScreens tmScreens, TMPart part)
        {
            Bitmap bitmap = GetScreenPart(part.Position.Top, part.Position.Left, part.Position.Width, part.Position.Height);

            return tmScreens.CompareImages(part, bitmap);
        }

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public void LeftMouseClick(int xpos, int ypos)
        {
            User32.Rect rect = new User32.Rect();

            User32.GetWindowRect(WinPtr, ref rect);

            User32.SetCursorPos(rect.left + xpos, rect.top + ypos);
            
            Thread.Sleep(100);

            User32.mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            User32.mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        }

        private IntPtr GetWindowByName(string wName)
        {
            IntPtr hWnd = IntPtr.Zero;
            foreach (Process pList in Process.GetProcesses())
            {
                if (pList.MainWindowTitle.Contains(wName))
                {
                    hWnd = pList.MainWindowHandle;
                }
            }
            return hWnd;
        }
    }
}
