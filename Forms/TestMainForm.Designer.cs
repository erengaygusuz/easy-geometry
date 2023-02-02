namespace EasyGeometry
{
    partial class TestMainForm
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
            this.TestTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.TestTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestTabControl
            // 
            this.TestTabControl.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.TestTabControl.Controls.Add(this.tabPage1);
            this.TestTabControl.Controls.Add(this.tabPage2);
            this.TestTabControl.Controls.Add(this.tabPage3);
            this.TestTabControl.Controls.Add(this.tabPage4);
            this.TestTabControl.Controls.Add(this.tabPage5);
            this.TestTabControl.Controls.Add(this.tabPage6);
            this.TestTabControl.Controls.Add(this.tabPage7);
            this.TestTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TestTabControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestTabControl.ItemSize = new System.Drawing.Size(50, 150);
            this.TestTabControl.Location = new System.Drawing.Point(0, 0);
            this.TestTabControl.Multiline = true;
            this.TestTabControl.Name = "TestTabControl";
            this.TestTabControl.SelectedIndex = 0;
            this.TestTabControl.Size = new System.Drawing.Size(859, 561);
            this.TestTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TestTabControl.TabIndex = 0;
            this.TestTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dörtgenler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dikdörtgenler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(701, 553);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eşkenar Dörtgenler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(701, 553);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kare";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(701, 553);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Yamuk";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(701, 553);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Paralelkenar";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(701, 553);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Deltoid";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // TestMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(859, 561);
            this.Controls.Add(this.TestTabControl);
            this.Name = "TestMainForm";
            this.Text = "TestMainForm";
            this.Load += new System.EventHandler(this.TestMainForm_Load);
            this.SizeChanged += new System.EventHandler(this.TestMainForm_SizeChanged);
            this.TestTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TestTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
    }
}