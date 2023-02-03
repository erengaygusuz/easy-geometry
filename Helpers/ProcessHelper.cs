using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace EasyGeometry.Helpers
{
    public class ProcessHelper
    {
        private const int GWL_STYLE = (-16);
        private const int WS_VISIBLE = 0x10000000;

        private Process process;
        private bool created = false;

        private int windowXPos;
        private int windowYPos;
        private int windowWidth;
        private int windowHeight;

        private IntPtr childHandle;
        private IntPtr parentHandle;

        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, UInt32 dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern long SetWindowPos(IntPtr hwnd, long hWndInsertAfter, long x, long y, long cx, long cy, long wFlags);

        public bool Created
        {
            get { return created; }
            set { created = value; }
        }

        public int SetWindowsXPos
        {
            set { windowXPos = value; }
        }

        public int SetWindowsYPos
        {
            set { windowYPos = value; }
        }

        public int SetWindowsWidth
        {
            set { windowWidth = value; }
        }

        public int SetWindowsHeight
        {
            set { windowHeight = value; }
        }

        public IntPtr ParentHandle
        {
            set { parentHandle = value; }
        }

        public Process Process
        {
            get { return process; }
        }

        public void Start(string exeFilePathWithNameAndExtension, string arguments)
        {
            if (created == false)
            {
                created = true;

                childHandle = IntPtr.Zero;

                if (process != null)
                {
                    process.Kill();
                }                

                try
                {
                    process = new Process();

                    process.StartInfo.FileName = exeFilePathWithNameAndExtension; 
                    process.StartInfo.Arguments = arguments; 

                    process.Start();

                    process.WaitForInputIdle();

                    while (process.MainWindowHandle == IntPtr.Zero)
                    {
                        Thread.Sleep(100);
                        process.Refresh();
                    }

                    childHandle = process.MainWindowHandle;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

                SetParent(childHandle, parentHandle);
                SetWindowLong(childHandle, GWL_STYLE, WS_VISIBLE);
                MoveWindow(childHandle, windowXPos, windowYPos, windowWidth, windowHeight, true);
            }
        }
    
        public void ChildWindowResize()
        {
            if (childHandle != IntPtr.Zero)
            {
                MoveWindow(childHandle, windowXPos, windowYPos, windowWidth, windowHeight, true);
            }
        }
    }
}
