namespace LaRustique
{
    partial class WerknemerWijzig
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
            this.aGbGegevens = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.aLabelID = new System.Windows.Forms.Label();
            this.aLabelAdmin = new System.Windows.Forms.Label();
            this.aLabelNaam = new System.Windows.Forms.Label();
            this.aLabelEmail = new System.Windows.Forms.Label();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.aRbAdminJa = new System.Windows.Forms.RadioButton();
            this.aRbAdminNee = new System.Windows.Forms.RadioButton();
            this.aGbGegevens.SuspendLayout();
            this.SuspendLayout();
            // 
            // aGbGegevens
            // 
            this.aGbGegevens.Controls.Add(this.aRbAdminNee);
            this.aGbGegevens.Controls.Add(this.aRbAdminJa);
            this.aGbGegevens.Controls.Add(this.txtEmail);
            this.aGbGegevens.Controls.Add(this.txtNaam);
            this.aGbGegevens.Controls.Add(this.txtID);
            this.aGbGegevens.Controls.Add(this.aLabelID);
            this.aGbGegevens.Controls.Add(this.aLabelAdmin);
            this.aGbGegevens.Controls.Add(this.aLabelNaam);
            this.aGbGegevens.Controls.Add(this.aLabelEmail);
            this.aGbGegevens.Location = new System.Drawing.Point(12, 12);
            this.aGbGegevens.Name = "aGbGegevens";
            this.aGbGegevens.Size = new System.Drawing.Size(218, 160);
            this.aGbGegevens.TabIndex = 3;
            this.aGbGegevens.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(112, 46);
            this.txtNaam.Name = "txtNaam";
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
            this.aLabelAdmin.Location = new System.Drawing.Point(6, 101);
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
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(21, 205);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(75, 23);
            this.btnWijzig.TabIndex = 4;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.Location = new System.Drawing.Point(136, 205);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuleer.TabIndex = 4;
            this.btnAnnuleer.Text = "Annuleer";
            this.btnAnnuleer.UseVisualStyleBackColor = true;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // aRbAdminJa
            // 
            this.aRbAdminJa.AutoSize = true;
            this.aRbAdminJa.Location = new System.Drawing.Point(112, 96);
            this.aRbAdminJa.Name = "aRbAdminJa";
            this.aRbAdminJa.Size = new System.Drawing.Size(36, 17);
            this.aRbAdminJa.TabIndex = 3;
            this.aRbAdminJa.TabStop = true;
            this.aRbAdminJa.Text = "Ja";
            this.aRbAdminJa.UseVisualStyleBackColor = true;
            // 
            // aRbAdminNee
            // 
            this.aRbAdminNee.AutoSize = true;
            this.aRbAdminNee.Location = new System.Drawing.Point(112, 120);
            this.aRbAdminNee.Name = "aRbAdminNee";
            this.aRbAdminNee.Size = new System.Drawing.Size(45, 17);
            this.aRbAdminNee.TabIndex = 4;
            this.aRbAdminNee.TabStop = true;
            this.aRbAdminNee.Text = "Nee";
            this.aRbAdminNee.UseVisualStyleBackColor = true;
            // 
            // WerknemerWijzig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 240);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.aGbGegevens);
            this.Name = "WerknemerWijzig";
            this.Text = "Gegevens Wijzigen";
            this.aGbGegevens.ResumeLayout(false);
            this.aGbGegevens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox aGbGegevens;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label aLabelID;
        private System.Windows.Forms.Label aLabelAdmin;
        private System.Windows.Forms.Label aLabelNaam;
        private System.Windows.Forms.Label aLabelEmail;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.RadioButton aRbAdminNee;
        private System.Windows.Forms.RadioButton aRbAdminJa;
    }
}