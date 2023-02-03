using EasyGeometry.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyGeometry
{
    public partial class TestMainForm : Form
    {
        private ProcessHelper processHelper;

        private string exeFilePathWithNameAndExtension;
        private string arguments;

        public TestMainForm()
        {
            processHelper = new ProcessHelper();

            InitializeComponent();

            processHelper.ParentHandle = this.TestTabControl.TabPages[TestTabControl.SelectedIndex].Handle;

            SetProcessWindowBounds();

            exeFilePathWithNameAndExtension = Application.StartupPath + "\\external\\adobe-flash-player\\flashplayer_32_sa.exe";
            arguments = Application.StartupPath + "\\data\\test\\" + this.TestTabControl.TabPages[TestTabControl.SelectedIndex].Name + ".swf";
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

        private void TestTabControl_DrawItem(object sender, DrawItemEventArgs e)
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
            SetProcessWindowBounds();
            processHelper.ChildWindowResize();

            base.OnResize(e);
        }

        private void TestMainForm_SizeChanged(object sender, EventArgs e)
        {
            SetProcessWindowBounds();
            processHelper.ChildWindowResize();

            base.OnResize(e);
        }

        private void TestMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            processHelper.Process.Kill();
            AppMainForm.isTestMainOpened = false;
        }

        private void TestTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            processHelper.ParentHandle = this.TestTabControl.TabPages[TestTabControl.SelectedIndex].Handle;
            arguments = Application.StartupPath + "\\data\\test\\" + this.TestTabControl.TabPages[TestTabControl.SelectedIndex].Name + ".swf";

            processHelper.Created = false;

            processHelper.Start(exeFilePathWithNameAndExtension, arguments);

            base.OnVisibleChanged(e);
        }
    
        private void SetProcessWindowBounds()
        {
            processHelper.SetWindowsXPos = 0;
            processHelper.SetWindowsYPos = -20;
            processHelper.SetWindowsWidth = this.TestTabControl.TabPages[TestTabControl.SelectedIndex].Width;
            processHelper.SetWindowsHeight = this.TestTabControl.TabPages[TestTabControl.SelectedIndex].Height + 20;
        }
    }
}
