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
    public partial class AppMainForm : Form
    {
        public AppMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void DocumentButton_Click(object sender, EventArgs e)
        {
            DocumentMainForm documentMainForm = new DocumentMainForm();
            documentMainForm.ShowDialog();
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            VideoMainForm videoMainForm = new VideoMainForm();
            videoMainForm.ShowDialog();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            TestMainForm testMainForm = new TestMainForm();
            testMainForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
