using EasyGeometry.Helpers;
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
        private ProcessHelper processHelper;

        private string exeFilePathWithNameAndExtension;
        private string arguments;

        public VideoMainForm()
        {
            processHelper = new ProcessHelper();

            InitializeComponent();

            processHelper.ParentHandle = this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Handle;

            SetProcessWindowBounds();

            exeFilePathWithNameAndExtension = Application.StartupPath + "\\external\\mp-classic\\mpc-hc64.exe";
            arguments = Application.StartupPath + "\\data\\video\\" + VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Name + ".mp4" + " /open";
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            this.Invalidate();
            base.OnSizeChanged(e);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            processHelper.Start(exeFilePathWithNameAndExtension, arguments);

            base.OnVisibleChanged(e);
        }

        private void VideoTabControl_DrawItem(object sender, DrawItemEventArgs e)
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
            SetProcessWindowBounds();
            processHelper.ChildWindowResize();

            base.OnResize(e);
        }

        private void VideoMainForm_SizeChanged(object sender, EventArgs e)
        {
            SetProcessWindowBounds();
            processHelper.ChildWindowResize();

            base.OnResize(e);
        }

        private void VideoMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            processHelper.Process.Kill();
            AppMainForm.isVideoMainOpened = false;
        }

        private void VideoTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            processHelper.ParentHandle = this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Handle;
            arguments = Application.StartupPath + "\\data\\video\\" + VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Name + ".mp4" + " /open";

            processHelper.Created = false;

            processHelper.Start(exeFilePathWithNameAndExtension, arguments);

            base.OnVisibleChanged(e);
        }

        private void SetProcessWindowBounds()
        {
            processHelper.SetWindowsXPos = 0;
            processHelper.SetWindowsYPos = -70;
            processHelper.SetWindowsWidth = this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Width;
            processHelper.SetWindowsHeight = this.VideoTabControl.TabPages[VideoTabControl.SelectedIndex].Height + 70;
        }
    }
}
