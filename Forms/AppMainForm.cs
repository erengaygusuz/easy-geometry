using System;
using System.Windows.Forms;

namespace EasyGeometry
{
    public partial class AppMainForm : Form
    {
        public static bool isDocumentMainOpened;
        public static bool isTestMainOpened;
        public static bool isVideoMainOpened;

        public AppMainForm()
        {
            InitializeComponent();
        }

        private void DocumentButton_Click(object sender, EventArgs e)
        {
            if (!isDocumentMainOpened)
            {
                isDocumentMainOpened = true;

                DocumentMainForm documentMainForm = new DocumentMainForm();
                documentMainForm.Show();
            }
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            if (!isVideoMainOpened)
            {
                isVideoMainOpened = true;

                VideoMainForm videoMainForm = new VideoMainForm();
                videoMainForm.Show();
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            if (!isTestMainOpened)
            {
                isTestMainOpened = true;

                TestMainForm testMainForm = new TestMainForm();
                testMainForm.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
