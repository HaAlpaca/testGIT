namespace DangBaTai_201200323
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HCNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hìnhTrònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hìnhTamGiácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảiPhươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bậcNhấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bậcHaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tinhToolStripMenuItem,
            this.giảiPhươngTrìnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tinhToolStripMenuItem
            // 
            this.tinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HCNToolStripMenuItem,
            this.hìnhTrònToolStripMenuItem,
            this.hìnhTamGiácToolStripMenuItem});
            this.tinhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhToolStripMenuItem.Name = "tinhToolStripMenuItem";
            this.tinhToolStripMenuItem.Size = new System.Drawing.Size(167, 35);
            this.tinhToolStripMenuItem.Text = "TÍnh diện tích";
            // 
            // HCNToolStripMenuItem
            // 
            this.HCNToolStripMenuItem.Image = global::DangBaTai_201200323.Properties.Resources.cong;
            this.HCNToolStripMenuItem.Name = "HCNToolStripMenuItem";
            this.HCNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.HCNToolStripMenuItem.Size = new System.Drawing.Size(396, 36);
            this.HCNToolStripMenuItem.Text = "Hình chữ nhật ";
            this.HCNToolStripMenuItem.Click += new System.EventHandler(this.HCNToolStripMenuItem_Click);
            // 
            // hìnhTrònToolStripMenuItem
            // 
            this.hìnhTrònToolStripMenuItem.Name = "hìnhTrònToolStripMenuItem";
            this.hìnhTrònToolStripMenuItem.Size = new System.Drawing.Size(396, 36);
            this.hìnhTrònToolStripMenuItem.Text = "Hình tròn ";
            this.hìnhTrònToolStripMenuItem.Click += new System.EventHandler(this.hìnhTrònToolStripMenuItem_Click);
            // 
            // hìnhTamGiácToolStripMenuItem
            // 
            this.hìnhTamGiácToolStripMenuItem.Name = "hìnhTamGiácToolStripMenuItem";
            this.hìnhTamGiácToolStripMenuItem.Size = new System.Drawing.Size(396, 36);
            this.hìnhTamGiácToolStripMenuItem.Text = "Hình tam giác";
            this.hìnhTamGiácToolStripMenuItem.Click += new System.EventHandler(this.hìnhTamGiácToolStripMenuItem_Click);
            // 
            // giảiPhươngTrìnhToolStripMenuItem
            // 
            this.giảiPhươngTrìnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bậcNhấtToolStripMenuItem,
            this.bậcHaiToolStripMenuItem});
            this.giảiPhươngTrìnhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giảiPhươngTrìnhToolStripMenuItem.Name = "giảiPhươngTrìnhToolStripMenuItem";
            this.giảiPhươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(216, 35);
            this.giảiPhươngTrìnhToolStripMenuItem.Text = "Giải phương trình ";
            // 
            // bậcNhấtToolStripMenuItem
            // 
            this.bậcNhấtToolStripMenuItem.Name = "bậcNhấtToolStripMenuItem";
            this.bậcNhấtToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.bậcNhấtToolStripMenuItem.Text = "Bậc nhất";
            // 
            // bậcHaiToolStripMenuItem
            // 
            this.bậcHaiToolStripMenuItem.Name = "bậcHaiToolStripMenuItem";
            this.bậcHaiToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.bậcHaiToolStripMenuItem.Text = "Bậc hai";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "denmo MenuStrip";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HCNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hìnhTrònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hìnhTamGiácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảiPhươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bậcNhấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bậcHaiToolStripMenuItem;
    }
}

