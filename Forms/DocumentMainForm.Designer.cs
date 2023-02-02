namespace EasyGeometry
{
    partial class DocumentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentMainForm));
            this.DocumentTabControl = new System.Windows.Forms.TabControl();
            this.dortgenler = new System.Windows.Forms.TabPage();
            this.dikdortgenler = new System.Windows.Forms.TabPage();
            this.eskenarDortgenler = new System.Windows.Forms.TabPage();
            this.kare = new System.Windows.Forms.TabPage();
            this.yamuk = new System.Windows.Forms.TabPage();
            this.paralelkenar = new System.Windows.Forms.TabPage();
            this.deltoid = new System.Windows.Forms.TabPage();
            this.DocumentTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocumentTabControl
            // 
            this.DocumentTabControl.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.DocumentTabControl.Controls.Add(this.dortgenler);
            this.DocumentTabControl.Controls.Add(this.dikdortgenler);
            this.DocumentTabControl.Controls.Add(this.eskenarDortgenler);
            this.DocumentTabControl.Controls.Add(this.kare);
            this.DocumentTabControl.Controls.Add(this.yamuk);
            this.DocumentTabControl.Controls.Add(this.paralelkenar);
            this.DocumentTabControl.Controls.Add(this.deltoid);
            this.DocumentTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocumentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.DocumentTabControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentTabControl.ItemSize = new System.Drawing.Size(50, 150);
            this.DocumentTabControl.Location = new System.Drawing.Point(0, 0);
            this.DocumentTabControl.Multiline = true;
            this.DocumentTabControl.Name = "DocumentTabControl";
            this.DocumentTabControl.SelectedIndex = 0;
            this.DocumentTabControl.Size = new System.Drawing.Size(859, 561);
            this.DocumentTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.DocumentTabControl.TabIndex = 0;
            this.DocumentTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.DocumentTabControl.SelectedIndexChanged += new System.EventHandler(this.DocumentTabControl_SelectedIndexChanged);
            // 
            // dortgenler
            // 
            this.dortgenler.AutoScroll = true;
            this.dortgenler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dortgenler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dortgenler.Location = new System.Drawing.Point(4, 4);
            this.dortgenler.Name = "dortgenler";
            this.dortgenler.Size = new System.Drawing.Size(701, 553);
            this.dortgenler.TabIndex = 0;
            this.dortgenler.Text = "Dörtgenler";
            this.dortgenler.UseVisualStyleBackColor = true;
            // 
            // dikdortgenler
            // 
            this.dikdortgenler.AutoScroll = true;
            this.dikdortgenler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dikdortgenler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dikdortgenler.Location = new System.Drawing.Point(4, 4);
            this.dikdortgenler.Name = "dikdortgenler";
            this.dikdortgenler.Size = new System.Drawing.Size(701, 553);
            this.dikdortgenler.TabIndex = 1;
            this.dikdortgenler.Text = "Dikdörtgenler";
            this.dikdortgenler.UseVisualStyleBackColor = true;
            // 
            // eskenarDortgenler
            // 
            this.eskenarDortgenler.AutoScroll = true;
            this.eskenarDortgenler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eskenarDortgenler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eskenarDortgenler.Location = new System.Drawing.Point(4, 4);
            this.eskenarDortgenler.Name = "eskenarDortgenler";
            this.eskenarDortgenler.Size = new System.Drawing.Size(701, 553);
            this.eskenarDortgenler.TabIndex = 2;
            this.eskenarDortgenler.Text = "Eşkenar Dörtgenler";
            this.eskenarDortgenler.UseVisualStyleBackColor = true;
            // 
            // kare
            // 
            this.kare.AutoScroll = true;
            this.kare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kare.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare.Location = new System.Drawing.Point(4, 4);
            this.kare.Name = "kare";
            this.kare.Size = new System.Drawing.Size(701, 553);
            this.kare.TabIndex = 3;
            this.kare.Text = "Kare";
            this.kare.UseVisualStyleBackColor = true;
            // 
            // yamuk
            // 
            this.yamuk.AutoScroll = true;
            this.yamuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yamuk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yamuk.Location = new System.Drawing.Point(4, 4);
            this.yamuk.Name = "yamuk";
            this.yamuk.Size = new System.Drawing.Size(701, 553);
            this.yamuk.TabIndex = 4;
            this.yamuk.Text = "Yamuk";
            this.yamuk.UseVisualStyleBackColor = true;
            // 
            // paralelkenar
            // 
            this.paralelkenar.AutoScroll = true;
            this.paralelkenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paralelkenar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paralelkenar.Location = new System.Drawing.Point(4, 4);
            this.paralelkenar.Name = "paralelkenar";
            this.paralelkenar.Size = new System.Drawing.Size(701, 553);
            this.paralelkenar.TabIndex = 5;
            this.paralelkenar.Text = "Paralelkenar";
            this.paralelkenar.UseVisualStyleBackColor = true;
            // 
            // deltoid
            // 
            this.deltoid.AutoScroll = true;
            this.deltoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deltoid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltoid.Location = new System.Drawing.Point(4, 4);
            this.deltoid.Name = "deltoid";
            this.deltoid.Size = new System.Drawing.Size(701, 553);
            this.deltoid.TabIndex = 6;
            this.deltoid.Text = "Deltoid";
            this.deltoid.UseVisualStyleBackColor = true;
            // 
            // DocumentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(859, 561);
            this.Controls.Add(this.DocumentTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentMainForm";
            this.Text = "Dökümanlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocumentMainForm_FormClosing);
            this.Load += new System.EventHandler(this.DocumentMainForm_Load);
            this.SizeChanged += new System.EventHandler(this.DocumentMainForm_SizeChanged);
            this.DocumentTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DocumentTabControl;
        private System.Windows.Forms.TabPage dortgenler;
        private System.Windows.Forms.TabPage dikdortgenler;
        private System.Windows.Forms.TabPage eskenarDortgenler;
        private System.Windows.Forms.TabPage kare;
        private System.Windows.Forms.TabPage yamuk;
        private System.Windows.Forms.TabPage paralelkenar;
        private System.Windows.Forms.TabPage deltoid;
    }
}