using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyGeometry
{
    public partial class TestMainForm : Form
    {
        bool created = false;
        IntPtr appWin;

        private const int SWP_NOOWNERZORDER = 0x200;
        private const int SWP_NOREDRAW = 0x8;
        private const int SWP_NOZORDER = 0x4;
        private const int SWP_SHOWWINDOW = 0x0040;
        private const int WS_EX_MDICHILD = 0x40;
        private const int SWP_FRAMECHANGED = 0x20;
        private const int SWP_NOACTIVATE = 0x10;
        private const int SWP_ASYNCWINDOWPOS = 0x4000;
        private const int SWP_NOMOVE = 0x2;
        private const int SWP_NOSIZE = 0x1;
        private const int GWL_STYLE = (-16);
        private const int WS_VISIBLE = 0x10000000;
        private const int WM_CLOSE = 0x10;
        private const int WS_CHILD = 0x40000000;

        private string swf = "E:\\ProjectFiles\\DesktopProjects\\easy-geometry\\alistirma\\deltoid.swf";

        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, UInt32 dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern long SetWindowPos(IntPtr hwnd, long hWndInsertAfter, long x, long y, long cx, long cy, long wFlags);

        public TestMainForm()
        {
            InitializeComponent();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            this.Invalidate();
            base.OnSizeChanged(e);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {

            // If control needs to be initialized/created
            if (created == false)
            {
                // Mark that control is created
                created = true;

                // Initialize handle value to invalid
                appWin = IntPtr.Zero;

                // Start the remote application
                Process proc = null;
                try
                {

                    proc = new Process();

                    proc.StartInfo.FileName = "E:\\ProjectFiles\\DesktopProjects\\easy-geometry\\external\\adobe-flash-player\\flashplayer_32_sa.exe";
                    proc.StartInfo.Arguments = swf;

                    proc.Start();

                    proc.WaitForInputIdle();

                    while (proc.MainWindowHandle == IntPtr.Zero)
                    {
                        Thread.Sleep(100);
                        proc.Refresh();
                    }

                    // Get the main handle
                    appWin = proc.MainWindowHandle;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                }

                SetParent(proc.MainWindowHandle, this.TestTabControl.TabPages[0].Handle);
                SetWindowLong(proc.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
                MoveWindow(proc.MainWindowHandle, 0, -20, this.TestTabControl.TabPages[0].Width, this.TestTabControl.TabPages[0].Height + 20, true);
            }

            base.OnVisibleChanged(e);
        }

        private void TestMainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.TestTabControl.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.TestTabControl.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.TestTabControl.Font, Brushes.Black, x, y);
        }

        protected override void OnResize(EventArgs e)
        {
            if (appWin != IntPtr.Zero)
            {
                MoveWindow(appWin, 0, -70, this.TestTabControl.TabPages[0].Width, this.TestTabControl.TabPages[0].Height + 70, true);
            }
            base.OnResize(e);
        }

        private void TestMainForm_SizeChanged(object sender, EventArgs e)
        {
            if (appWin != IntPtr.Zero)
            {
                MoveWindow(appWin, 0, -20, this.TestTabControl.TabPages[0].Width, this.TestTabControl.TabPages[0].Height + 20, true);
            }
            base.OnResize(e);
        }
    }
}
