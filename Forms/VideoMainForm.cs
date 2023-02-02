using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace EasyGeometry
{
    public partial class VideoMainForm : Form
    {
        private Process proc;
        private bool created = false;
        private IntPtr appWin;

        private const int GWL_STYLE = (-16);
        private const int WS_VISIBLE = 0x10000000;

        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, UInt32 dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern long SetWindowPos(IntPtr hwnd, long hWndInsertAfter, long x, long y, long cx, long cy, long wFlags);

        public VideoMainForm()
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
            if (created == false)
            {
                created = true;

                appWin = IntPtr.Zero;

                proc = null;

                try
                {
                    proc = new Process();

                    proc.StartInfo.FileName = Application.StartupPath + "\\external\\mp-classic\\mpc-hc64.exe";
                    proc.StartInfo.Arguments = Application.StartupPath + "\\data\\video\\" + VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Name + ".mp4" +" /open";

                    proc.Start();

                    proc.WaitForInputIdle();

                    while (proc.MainWindowHandle == IntPtr.Zero)
                    {
                        Thread.Sleep(100);
                        proc.Refresh();
                    }

                    appWin = proc.MainWindowHandle;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                }

                SetParent(proc.MainWindowHandle, this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Handle);
                SetWindowLong(proc.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
                MoveWindow(proc.MainWindowHandle, 0, -70, this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Width, this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Height + 70, true);

            }

            base.OnVisibleChanged(e);
        }

        private void VideoMainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.VideoTabControl.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.VideoTabControl.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.VideoTabControl.Font, Brushes.Black, x, y);
        }

        protected override void OnResize(EventArgs e)
        {
            if (appWin != IntPtr.Zero)
            {
                MoveWindow(appWin, 0, -70, this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Width, this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Height + 70, true);
            }

            base.OnResize(e);
        }

        private void VideoMainForm_SizeChanged(object sender, EventArgs e)
        {
            if (appWin != IntPtr.Zero)
            {
                MoveWindow(appWin, 0, -70, this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Width, this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Height + 70, true);
            }

            base.OnResize(e);
        }

        private void VideoMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            proc.Kill();
            AppMainForm.isVideoMainOpened = false;
        }

        private void VideoTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            created = false;

            if (created == false)
            {
                created = true;

                appWin = IntPtr.Zero;

                proc.Kill();

                try
                {
                    proc = new Process();

                    proc.StartInfo.FileName = Application.StartupPath + "\\external\\mp-classic\\mpc-hc64.exe";
                    proc.StartInfo.Arguments = Application.StartupPath + "\\data\\video\\" + VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Name + ".mp4" + " /open";

                    proc.Start();

                    proc.WaitForInputIdle();

                    while (proc.MainWindowHandle == IntPtr.Zero)
                    {
                        Thread.Sleep(100);
                        proc.Refresh();
                    }

                    appWin = proc.MainWindowHandle;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                }

                SetParent(proc.MainWindowHandle, this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Handle);
                SetWindowLong(proc.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
                MoveWindow(proc.MainWindowHandle, 0, -70, this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Width, this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Height + 70, true);

            }

            base.OnVisibleChanged(e);
        }
    }
}
