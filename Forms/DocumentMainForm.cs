using EasyGeometry.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyGeometry
{
    public partial class DocumentMainForm : Form
    {
        private ProcessHelper processHelper;

        private string exeFilePathWithNameAndExtension;
        private string arguments;

        public DocumentMainForm()
        {
            processHelper = new ProcessHelper();

            InitializeComponent();

            processHelper.ParentHandle = this.DocumentTabControl.TabPages[DocumentTabControl.SelectedIndex].Handle;

            SetProcessWindowBounds();

            exeFilePathWithNameAndExtension = Application.StartupPath + "\\external\\sumatra-pdf\\sumatra-pdf.exe";
            arguments = Application.StartupPath + "\\data\\document\\" + DocumentTabControl.TabPages[DocumentTabControl.SelectedIndex].Name + ".pdf";
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

        private void DocumentTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.DocumentTabControl.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.DocumentTabControl.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.DocumentTabControl.Font, Brushes.Black, x, y);
        }

        protected override void OnResize(EventArgs e)
        {
            SetProcessWindowBounds();

            processHelper.ChildWindowResize();

            base.OnResize(e);
        }

        private void DocumentMainForm_SizeChanged(object sender, EventArgs e)
        {
            SetProcessWindowBounds();

            processHelper.ChildWindowResize();

            base.OnResize(e);
        }

        private void DocumentMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            processHelper.Process.Kill();
            AppMainForm.isDocumentMainOpened = false;
        }

        private void DocumentTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            processHelper.ParentHandle = this.DocumentTabControl.TabPages[DocumentTabControl.SelectedIndex].Handle;
            arguments = Application.StartupPath + "\\data\\document\\" + DocumentTabControl.TabPages[DocumentTabControl.SelectedIndex].Name + ".pdf";

            processHelper.Created = false;

            processHelper.Start(exeFilePathWithNameAndExtension, arguments);

            base.OnVisibleChanged(e);
        }

        private void SetProcessWindowBounds()
        {
            processHelper.SetWindowsXPos = 0;
            processHelper.SetWindowsYPos = -70;
            processHelper.SetWindowsWidth = this.DocumentTabControl.TabPages[DocumentTabControl.SelectedIndex].Width;
            processHelper.SetWindowsHeight = this.DocumentTabControl.TabPages[DocumentTabControl.SelectedIndex].Height + 70;
        }
    }
}
