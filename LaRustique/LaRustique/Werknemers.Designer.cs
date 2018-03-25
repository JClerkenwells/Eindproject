namespace LaRustique
{
    partial class Werknemers
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.klantenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveringenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factuurMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plattegrondMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logUitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.werknemersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.aLbWerknemers = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.werknemersMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klantenMenuItem,
            this.reserveringenMenuItem,
            this.factuurMenuItem,
            this.plattegrondMenuItem,
            this.logUitMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // klantenMenuItem
            // 
            this.klantenMenuItem.Name = "klantenMenuItem";
            this.klantenMenuItem.Size = new System.Drawing.Size(152, 22);
            this.klantenMenuItem.Text = "Klanten";
            // 
            // reserveringenMenuItem
            // 
            this.reserveringenMenuItem.Name = "reserveringenMenuItem";
            this.reserveringenMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reserveringenMenuItem.Text = "Reserveringen";
            // 
            // factuurMenuItem
            // 
            this.factuurMenuItem.Name = "factuurMenuItem";
            this.factuurMenuItem.Size = new System.Drawing.Size(152, 22);
            this.factuurMenuItem.Text = "Factuur";
            // 
            // plattegrondMenuItem
            // 
            this.plattegrondMenuItem.Name = "plattegrondMenuItem";
            this.plattegrondMenuItem.Size = new System.Drawing.Size(152, 22);
            this.plattegrondMenuItem.Text = "Plattegrond";
            // 
            // logUitMenuItem
            // 
            this.logUitMenuItem.Name = "logUitMenuItem";
            this.logUitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logUitMenuItem.Text = "Log Uit";
            this.logUitMenuItem.Click += new System.EventHandler(this.logUitMenuItem_Click);
            // 
            // werknemersMenuItem
            // 
            this.werknemersMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.werknemersMenuItem.Name = "werknemersMenuItem";
            this.werknemersMenuItem.Size = new System.Drawing.Size(85, 20);
            this.werknemersMenuItem.Text = "Werknemers";
            this.werknemersMenuItem.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // aLbWerknemers
            // 
            this.aLbWerknemers.FormattingEnabled = true;
            this.aLbWerknemers.Location = new System.Drawing.Point(336, 12);
            this.aLbWerknemers.Name = "aLbWerknemers";
            this.aLbWerknemers.Size = new System.Drawing.Size(153, 225);
            this.aLbWerknemers.TabIndex = 6;
            // 
            // Werknemers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.aLbWerknemers);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Werknemers";
            this.Text = "Werknemers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem klantenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveringenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factuurMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plattegrondMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logUitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem werknemersMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox aLbWerknemers;
    }
}