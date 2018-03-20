namespace LaRustique
{
    partial class Startpagina
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Klant = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.factuurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plattegrondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logUitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGroupBox = new System.Windows.Forms.GroupBox();
            this.aLabelNaam = new System.Windows.Forms.Label();
            this.aLabelEmail = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.aGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Klant,
            this.toolStripMenuItem2,
            this.factuurToolStripMenuItem,
            this.plattegrondToolStripMenuItem,
            this.logUitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // Klant
            // 
            this.Klant.Name = "Klant";
            this.Klant.Size = new System.Drawing.Size(152, 22);
            this.Klant.Text = "Klanten";
            this.Klant.Click += new System.EventHandler(this.Klant_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem2.Text = "Reserveringen";
            // 
            // factuurToolStripMenuItem
            // 
            this.factuurToolStripMenuItem.Name = "factuurToolStripMenuItem";
            this.factuurToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.factuurToolStripMenuItem.Text = "Factuur";
            // 
            // plattegrondToolStripMenuItem
            // 
            this.plattegrondToolStripMenuItem.Name = "plattegrondToolStripMenuItem";
            this.plattegrondToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.plattegrondToolStripMenuItem.Text = "Plattegrond";
            // 
            // logUitToolStripMenuItem
            // 
            this.logUitToolStripMenuItem.Name = "logUitToolStripMenuItem";
            this.logUitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.logUitToolStripMenuItem.Text = "Log Uit";
            this.logUitToolStripMenuItem.Click += new System.EventHandler(this.logUitToolStripMenuItem_Click);
            // 
            // aGroupBox
            // 
            this.aGroupBox.Controls.Add(this.aLabelEmail);
            this.aGroupBox.Controls.Add(this.aLabelNaam);
            this.aGroupBox.Location = new System.Drawing.Point(336, 12);
            this.aGroupBox.Name = "aGroupBox";
            this.aGroupBox.Size = new System.Drawing.Size(214, 187);
            this.aGroupBox.TabIndex = 4;
            this.aGroupBox.TabStop = false;
            // 
            // aLabelNaam
            // 
            this.aLabelNaam.AutoSize = true;
            this.aLabelNaam.Location = new System.Drawing.Point(27, 16);
            this.aLabelNaam.Name = "aLabelNaam";
            this.aLabelNaam.Size = new System.Drawing.Size(35, 13);
            this.aLabelNaam.TabIndex = 0;
            this.aLabelNaam.Text = "label1";
            // 
            // aLabelEmail
            // 
            this.aLabelEmail.AutoSize = true;
            this.aLabelEmail.Location = new System.Drawing.Point(27, 52);
            this.aLabelEmail.Name = "aLabelEmail";
            this.aLabelEmail.Size = new System.Drawing.Size(39, 13);
            this.aLabelEmail.TabIndex = 1;
            this.aLabelEmail.Text = "aLabel";
            // 
            // Startpagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.aGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Startpagina";
            this.Text = "Startpagina";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.aGroupBox.ResumeLayout(false);
            this.aGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Klant;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem factuurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plattegrondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logUitToolStripMenuItem;
        private System.Windows.Forms.GroupBox aGroupBox;
        private System.Windows.Forms.Label aLabelNaam;
        private System.Windows.Forms.Label aLabelEmail;
    }
}