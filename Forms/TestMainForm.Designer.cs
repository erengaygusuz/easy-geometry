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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestMainForm));
            this.TestTabControl = new System.Windows.Forms.TabControl();
            this.dortgenler = new System.Windows.Forms.TabPage();
            this.dikdortgenler = new System.Windows.Forms.TabPage();
            this.eskenarDortgenler = new System.Windows.Forms.TabPage();
            this.kare = new System.Windows.Forms.TabPage();
            this.yamuk = new System.Windows.Forms.TabPage();
            this.paralelkenar = new System.Windows.Forms.TabPage();
            this.deltoid = new System.Windows.Forms.TabPage();
            this.TestTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestTabControl
            // 
            this.TestTabControl.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.TestTabControl.Controls.Add(this.dortgenler);
            this.TestTabControl.Controls.Add(this.dikdortgenler);
            this.TestTabControl.Controls.Add(this.eskenarDortgenler);
            this.TestTabControl.Controls.Add(this.kare);
            this.TestTabControl.Controls.Add(this.yamuk);
            this.TestTabControl.Controls.Add(this.paralelkenar);
            this.TestTabControl.Controls.Add(this.deltoid);
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
            this.TestTabControl.SelectedIndexChanged += new System.EventHandler(this.TestTabControl_SelectedIndexChanged);
            // 
            // dortgenler
            // 
            this.dortgenler.Location = new System.Drawing.Point(4, 4);
            this.dortgenler.Name = "dortgenler";
            this.dortgenler.Padding = new System.Windows.Forms.Padding(3);
            this.dortgenler.Size = new System.Drawing.Size(701, 553);
            this.dortgenler.TabIndex = 0;
            this.dortgenler.Text = "Dörtgenler";
            this.dortgenler.UseVisualStyleBackColor = true;
            // 
            // dikdortgenler
            // 
            this.dikdortgenler.Location = new System.Drawing.Point(4, 4);
            this.dikdortgenler.Name = "dikdortgenler";
            this.dikdortgenler.Padding = new System.Windows.Forms.Padding(3);
            this.dikdortgenler.Size = new System.Drawing.Size(701, 553);
            this.dikdortgenler.TabIndex = 1;
            this.dikdortgenler.Text = "Dikdörtgenler";
            this.dikdortgenler.UseVisualStyleBackColor = true;
            // 
            // eskenarDortgenler
            // 
            this.eskenarDortgenler.Location = new System.Drawing.Point(4, 4);
            this.eskenarDortgenler.Name = "eskenarDortgenler";
            this.eskenarDortgenler.Size = new System.Drawing.Size(701, 553);
            this.eskenarDortgenler.TabIndex = 2;
            this.eskenarDortgenler.Text = "Eşkenar Dörtgenler";
            this.eskenarDortgenler.UseVisualStyleBackColor = true;
            // 
            // kare
            // 
            this.kare.Location = new System.Drawing.Point(4, 4);
            this.kare.Name = "kare";
            this.kare.Size = new System.Drawing.Size(701, 553);
            this.kare.TabIndex = 3;
            this.kare.Text = "Kare";
            this.kare.UseVisualStyleBackColor = true;
            // 
            // yamuk
            // 
            this.yamuk.Location = new System.Drawing.Point(4, 4);
            this.yamuk.Name = "yamuk";
            this.yamuk.Size = new System.Drawing.Size(701, 553);
            this.yamuk.TabIndex = 4;
            this.yamuk.Text = "Yamuk";
            this.yamuk.UseVisualStyleBackColor = true;
            // 
            // paralelkenar
            // 
            this.paralelkenar.Location = new System.Drawing.Point(4, 4);
            this.paralelkenar.Name = "paralelkenar";
            this.paralelkenar.Size = new System.Drawing.Size(701, 553);
            this.paralelkenar.TabIndex = 5;
            this.paralelkenar.Text = "Paralelkenar";
            this.paralelkenar.UseVisualStyleBackColor = true;
            // 
            // deltoid
            // 
            this.deltoid.Location = new System.Drawing.Point(4, 4);
            this.deltoid.Name = "deltoid";
            this.deltoid.Size = new System.Drawing.Size(701, 553);
            this.deltoid.TabIndex = 6;
            this.deltoid.Text = "Deltoid";
            this.deltoid.UseVisualStyleBackColor = true;
            // 
            // TestMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(859, 561);
            this.Controls.Add(this.TestTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestMainForm";
            this.Text = "Testler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestMainForm_FormClosing);
            this.Load += new System.EventHandler(this.TestMainForm_Load);
            this.SizeChanged += new System.EventHandler(this.TestMainForm_SizeChanged);
            this.TestTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TestTabControl;
        private System.Windows.Forms.TabPage dortgenler;
        private System.Windows.Forms.TabPage dikdortgenler;
        private System.Windows.Forms.TabPage eskenarDortgenler;
        private System.Windows.Forms.TabPage kare;
        private System.Windows.Forms.TabPage yamuk;
        private System.Windows.Forms.TabPage paralelkenar;
        private System.Windows.Forms.TabPage deltoid;
    }
}