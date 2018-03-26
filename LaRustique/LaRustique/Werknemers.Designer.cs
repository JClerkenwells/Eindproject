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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.klantenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveringenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factuurMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plattegrondMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logUitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.werknemersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLbWerknemers = new System.Windows.Forms.ListBox();
            this.aGbWerknemers = new System.Windows.Forms.GroupBox();
            this.btnLaadGegevens = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.aGbGegevens = new System.Windows.Forms.GroupBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.aLabelID = new System.Windows.Forms.Label();
            this.aLabelAdmin = new System.Windows.Forms.Label();
            this.aLabelNaam = new System.Windows.Forms.Label();
            this.aLabelEmail = new System.Windows.Forms.Label();
            this.btnWerknmrToevoegen = new System.Windows.Forms.Button();
            this.aLabelTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.aGbWerknemers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.aGbGegevens.SuspendLayout();
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
            this.klantenMenuItem.Size = new System.Drawing.Size(148, 22);
            this.klantenMenuItem.Text = "Klanten";
            // 
            // reserveringenMenuItem
            // 
            this.reserveringenMenuItem.Name = "reserveringenMenuItem";
            this.reserveringenMenuItem.Size = new System.Drawing.Size(148, 22);
            this.reserveringenMenuItem.Text = "Reserveringen";
            // 
            // factuurMenuItem
            // 
            this.factuurMenuItem.Name = "factuurMenuItem";
            this.factuurMenuItem.Size = new System.Drawing.Size(148, 22);
            this.factuurMenuItem.Text = "Factuur";
            // 
            // plattegrondMenuItem
            // 
            this.plattegrondMenuItem.Name = "plattegrondMenuItem";
            this.plattegrondMenuItem.Size = new System.Drawing.Size(148, 22);
            this.plattegrondMenuItem.Text = "Plattegrond";
            // 
            // logUitMenuItem
            // 
            this.logUitMenuItem.Name = "logUitMenuItem";
            this.logUitMenuItem.Size = new System.Drawing.Size(148, 22);
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
            // aLbWerknemers
            // 
            this.aLbWerknemers.FormattingEnabled = true;
            this.aLbWerknemers.Location = new System.Drawing.Point(6, 56);
            this.aLbWerknemers.Name = "aLbWerknemers";
            this.aLbWerknemers.Size = new System.Drawing.Size(153, 329);
            this.aLbWerknemers.TabIndex = 6;
            // 
            // aGbWerknemers
            // 
            this.aGbWerknemers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aGbWerknemers.Controls.Add(this.btnLaadGegevens);
            this.aGbWerknemers.Controls.Add(this.aLbWerknemers);
            this.aGbWerknemers.Location = new System.Drawing.Point(13, 58);
            this.aGbWerknemers.Name = "aGbWerknemers";
            this.aGbWerknemers.Size = new System.Drawing.Size(202, 391);
            this.aGbWerknemers.TabIndex = 7;
            this.aGbWerknemers.TabStop = false;
            this.aGbWerknemers.Text = "Werknemers";
            // 
            // btnLaadGegevens
            // 
            this.btnLaadGegevens.Location = new System.Drawing.Point(6, 19);
            this.btnLaadGegevens.Name = "btnLaadGegevens";
            this.btnLaadGegevens.Size = new System.Drawing.Size(190, 23);
            this.btnLaadGegevens.TabIndex = 7;
            this.btnLaadGegevens.Text = "Laad Gegevens";
            this.btnLaadGegevens.UseVisualStyleBackColor = true;
            this.btnLaadGegevens.Click += new System.EventHandler(this.btnLaadGegevens_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWerknmrToevoegen);
            this.groupBox1.Controls.Add(this.btnVerwijder);
            this.groupBox1.Controls.Add(this.btnWijzig);
            this.groupBox1.Controls.Add(this.aGbGegevens);
            this.groupBox1.Location = new System.Drawing.Point(221, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 385);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(7, 20);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(100, 25);
            this.btnVerwijder.TabIndex = 4;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Visible = false;
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(118, 20);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(100, 25);
            this.btnWijzig.TabIndex = 3;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Visible = false;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // aGbGegevens
            // 
            this.aGbGegevens.Controls.Add(this.txtAdmin);
            this.aGbGegevens.Controls.Add(this.txtTel);
            this.aGbGegevens.Controls.Add(this.txtEmail);
            this.aGbGegevens.Controls.Add(this.txtNaam);
            this.aGbGegevens.Controls.Add(this.txtID);
            this.aGbGegevens.Controls.Add(this.aLabelID);
            this.aGbGegevens.Controls.Add(this.aLabelAdmin);
            this.aGbGegevens.Controls.Add(this.aLabelTel);
            this.aGbGegevens.Controls.Add(this.aLabelNaam);
            this.aGbGegevens.Controls.Add(this.aLabelEmail);
            this.aGbGegevens.Location = new System.Drawing.Point(6, 56);
            this.aGbGegevens.Name = "aGbGegevens";
            this.aGbGegevens.Size = new System.Drawing.Size(218, 159);
            this.aGbGegevens.TabIndex = 2;
            this.aGbGegevens.TabStop = false;
            this.aGbGegevens.Visible = false;
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(112, 124);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.ReadOnly = true;
            this.txtAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtAdmin.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(112, 46);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.ReadOnly = true;
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(112, 20);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // aLabelID
            // 
            this.aLabelID.AutoSize = true;
            this.aLabelID.Location = new System.Drawing.Point(6, 23);
            this.aLabelID.Name = "aLabelID";
            this.aLabelID.Size = new System.Drawing.Size(18, 13);
            this.aLabelID.TabIndex = 0;
            this.aLabelID.Text = "ID";
            // 
            // aLabelAdmin
            // 
            this.aLabelAdmin.AutoSize = true;
            this.aLabelAdmin.Location = new System.Drawing.Point(6, 127);
            this.aLabelAdmin.Name = "aLabelAdmin";
            this.aLabelAdmin.Size = new System.Drawing.Size(36, 13);
            this.aLabelAdmin.TabIndex = 1;
            this.aLabelAdmin.Text = "Admin";
            // 
            // aLabelNaam
            // 
            this.aLabelNaam.AutoSize = true;
            this.aLabelNaam.Location = new System.Drawing.Point(6, 49);
            this.aLabelNaam.Name = "aLabelNaam";
            this.aLabelNaam.Size = new System.Drawing.Size(35, 13);
            this.aLabelNaam.TabIndex = 0;
            this.aLabelNaam.Text = "Naam";
            // 
            // aLabelEmail
            // 
            this.aLabelEmail.AutoSize = true;
            this.aLabelEmail.Location = new System.Drawing.Point(5, 75);
            this.aLabelEmail.Name = "aLabelEmail";
            this.aLabelEmail.Size = new System.Drawing.Size(36, 13);
            this.aLabelEmail.TabIndex = 0;
            this.aLabelEmail.Text = "E-Mail";
            // 
            // btnWerknmrToevoegen
            // 
            this.btnWerknmrToevoegen.Location = new System.Drawing.Point(434, 20);
            this.btnWerknmrToevoegen.Name = "btnWerknmrToevoegen";
            this.btnWerknmrToevoegen.Size = new System.Drawing.Size(190, 25);
            this.btnWerknmrToevoegen.TabIndex = 5;
            this.btnWerknmrToevoegen.Text = "Werknemer Toevoegen";
            this.btnWerknmrToevoegen.UseVisualStyleBackColor = true;
            this.btnWerknmrToevoegen.Click += new System.EventHandler(this.btnWerknmrToevoegen_Click);
            // 
            // aLabelTel
            // 
            this.aLabelTel.AutoSize = true;
            this.aLabelTel.Location = new System.Drawing.Point(5, 101);
            this.aLabelTel.Name = "aLabelTel";
            this.aLabelTel.Size = new System.Drawing.Size(22, 13);
            this.aLabelTel.TabIndex = 0;
            this.aLabelTel.Text = "Tel";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(112, 98);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 2;
            // 
            // Werknemers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aGbWerknemers);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Werknemers";
            this.Text = "Werknemers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.aGbWerknemers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.aGbGegevens.ResumeLayout(false);
            this.aGbGegevens.PerformLayout();
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
        private System.Windows.Forms.ListBox aLbWerknemers;
        private System.Windows.Forms.GroupBox aGbWerknemers;
        private System.Windows.Forms.Button btnLaadGegevens;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.GroupBox aGbGegevens;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label aLabelID;
        private System.Windows.Forms.Label aLabelAdmin;
        private System.Windows.Forms.Label aLabelNaam;
        private System.Windows.Forms.Label aLabelEmail;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Button btnWerknmrToevoegen;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label aLabelTel;
    }
}