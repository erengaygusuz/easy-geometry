namespace EasyGeometry
{
    partial class AppMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMainForm));
            this.AppMainTitle = new System.Windows.Forms.PictureBox();
            this.TestButton = new System.Windows.Forms.PictureBox();
            this.VideoButton = new System.Windows.Forms.PictureBox();
            this.DocumentButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppMainTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentButton)).BeginInit();
            this.SuspendLayout();
            // 
            // AppMainTitle
            // 
            this.AppMainTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppMainTitle.BackgroundImage")));
            this.AppMainTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppMainTitle.Location = new System.Drawing.Point(185, 44);
            this.AppMainTitle.Name = "AppMainTitle";
            this.AppMainTitle.Size = new System.Drawing.Size(471, 59);
            this.AppMainTitle.TabIndex = 8;
            this.AppMainTitle.TabStop = false;
            // 
            // TestButton
            // 
            this.TestButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TestButton.BackgroundImage")));
            this.TestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestButton.Location = new System.Drawing.Point(599, 402);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(100, 100);
            this.TestButton.TabIndex = 6;
            this.TestButton.TabStop = false;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // VideoButton
            // 
            this.VideoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VideoButton.BackgroundImage")));
            this.VideoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VideoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VideoButton.Location = new System.Drawing.Point(381, 407);
            this.VideoButton.Name = "VideoButton";
            this.VideoButton.Size = new System.Drawing.Size(90, 90);
            this.VideoButton.TabIndex = 5;
            this.VideoButton.TabStop = false;
            this.VideoButton.Click += new System.EventHandler(this.VideoButton_Click);
            // 
            // DocumentButton
            // 
            this.DocumentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DocumentButton.BackgroundImage")));
            this.DocumentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DocumentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocumentButton.Location = new System.Drawing.Point(128, 402);
            this.DocumentButton.Name = "DocumentButton";
            this.DocumentButton.Size = new System.Drawing.Size(100, 100);
            this.DocumentButton.TabIndex = 4;
            this.DocumentButton.TabStop = false;
            this.DocumentButton.Click += new System.EventHandler(this.DocumentButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 170);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(859, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppMainTitle);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.VideoButton);
            this.Controls.Add(this.DocumentButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(879, 604);
            this.MinimumSize = new System.Drawing.Size(879, 604);
            this.Name = "AppMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KOLAY GEOMETRİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppMainTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox AppMainTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox DocumentButton;
        private System.Windows.Forms.PictureBox VideoButton;
        private System.Windows.Forms.PictureBox TestButton;
    }
}

