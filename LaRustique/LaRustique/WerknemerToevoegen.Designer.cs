namespace LaRustique
{
    partial class WerknemerToevoegen
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
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.aGbGegevens = new System.Windows.Forms.GroupBox();
            this.aRbAdminNee = new System.Windows.Forms.RadioButton();
            this.aRbAdminJa = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.aLabelAdmin = new System.Windows.Forms.Label();
            this.aLabelNaam = new System.Windows.Forms.Label();
            this.aLabelEmail = new System.Windows.Forms.Label();
            this.aLabelPass = new System.Windows.Forms.Label();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWachtwoordCheck = new System.Windows.Forms.TextBox();
            this.aLabelTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.aGbGegevens.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.Location = new System.Drawing.Point(149, 242);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuleer.TabIndex = 7;
            this.btnAnnuleer.Text = "Annuleer";
            this.btnAnnuleer.UseVisualStyleBackColor = true;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(20, 242);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 6;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // aGbGegevens
            // 
            this.aGbGegevens.Controls.Add(this.aRbAdminNee);
            this.aGbGegevens.Controls.Add(this.aRbAdminJa);
            this.aGbGegevens.Controls.Add(this.txtTel);
            this.aGbGegevens.Controls.Add(this.txtWachtwoordCheck);
            this.aGbGegevens.Controls.Add(this.txtWachtwoord);
            this.aGbGegevens.Controls.Add(this.txtEmail);
            this.aGbGegevens.Controls.Add(this.aLabelTel);
            this.aGbGegevens.Controls.Add(this.txtNaam);
            this.aGbGegevens.Controls.Add(this.label1);
            this.aGbGegevens.Controls.Add(this.aLabelAdmin);
            this.aGbGegevens.Controls.Add(this.aLabelPass);
            this.aGbGegevens.Controls.Add(this.aLabelNaam);
            this.aGbGegevens.Controls.Add(this.aLabelEmail);
            this.aGbGegevens.Location = new System.Drawing.Point(12, 12);
            this.aGbGegevens.Name = "aGbGegevens";
            this.aGbGegevens.Size = new System.Drawing.Size(218, 207);
            this.aGbGegevens.TabIndex = 5;
            this.aGbGegevens.TabStop = false;
            // 
            // aRbAdminNee
            // 
            this.aRbAdminNee.AutoSize = true;
            this.aRbAdminNee.Location = new System.Drawing.Point(112, 174);
            this.aRbAdminNee.Name = "aRbAdminNee";
            this.aRbAdminNee.Size = new System.Drawing.Size(45, 17);
            this.aRbAdminNee.TabIndex = 4;
            this.aRbAdminNee.TabStop = true;
            this.aRbAdminNee.Text = "Nee";
            this.aRbAdminNee.UseVisualStyleBackColor = true;
            // 
            // aRbAdminJa
            // 
            this.aRbAdminJa.AutoSize = true;
            this.aRbAdminJa.Location = new System.Drawing.Point(112, 150);
            this.aRbAdminJa.Name = "aRbAdminJa";
            this.aRbAdminJa.Size = new System.Drawing.Size(36, 17);
            this.aRbAdminJa.TabIndex = 3;
            this.aRbAdminJa.TabStop = true;
            this.aRbAdminJa.Text = "Ja";
            this.aRbAdminJa.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 41);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(112, 15);
            this.txtNaam.MaxLength = 50;
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 0;
            // 
            // aLabelAdmin
            // 
            this.aLabelAdmin.AutoSize = true;
            this.aLabelAdmin.Location = new System.Drawing.Point(6, 155);
            this.aLabelAdmin.Name = "aLabelAdmin";
            this.aLabelAdmin.Size = new System.Drawing.Size(36, 13);
            this.aLabelAdmin.TabIndex = 1;
            this.aLabelAdmin.Text = "Admin";
            // 
            // aLabelNaam
            // 
            this.aLabelNaam.AutoSize = true;
            this.aLabelNaam.Location = new System.Drawing.Point(6, 18);
            this.aLabelNaam.Name = "aLabelNaam";
            this.aLabelNaam.Size = new System.Drawing.Size(35, 13);
            this.aLabelNaam.TabIndex = 0;
            this.aLabelNaam.Text = "Naam";
            // 
            // aLabelEmail
            // 
            this.aLabelEmail.AutoSize = true;
            this.aLabelEmail.Location = new System.Drawing.Point(5, 44);
            this.aLabelEmail.Name = "aLabelEmail";
            this.aLabelEmail.Size = new System.Drawing.Size(36, 13);
            this.aLabelEmail.TabIndex = 0;
            this.aLabelEmail.Text = "E-Mail";
            // 
            // aLabelPass
            // 
            this.aLabelPass.AutoSize = true;
            this.aLabelPass.Location = new System.Drawing.Point(5, 70);
            this.aLabelPass.Name = "aLabelPass";
            this.aLabelPass.Size = new System.Drawing.Size(68, 13);
            this.aLabelPass.TabIndex = 0;
            this.aLabelPass.Text = "Wachtwoord";
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(112, 67);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(100, 20);
            this.txtWachtwoord.TabIndex = 2;
            this.txtWachtwoord.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Herhaal Wachtwoord";
            // 
            // txtWachtwoordCheck
            // 
            this.txtWachtwoordCheck.Location = new System.Drawing.Point(112, 93);
            this.txtWachtwoordCheck.Name = "txtWachtwoordCheck";
            this.txtWachtwoordCheck.Size = new System.Drawing.Size(100, 20);
            this.txtWachtwoordCheck.TabIndex = 3;
            this.txtWachtwoordCheck.UseSystemPasswordChar = true;
            // 
            // aLabelTel
            // 
            this.aLabelTel.AutoSize = true;
            this.aLabelTel.Location = new System.Drawing.Point(5, 122);
            this.aLabelTel.Name = "aLabelTel";
            this.aLabelTel.Size = new System.Drawing.Size(22, 13);
            this.aLabelTel.TabIndex = 0;
            this.aLabelTel.Text = "Tel";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(112, 119);
            this.txtTel.MaxLength = 12;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 4;
            // 
            // WerknemerToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 288);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.aGbGegevens);
            this.Name = "WerknemerToevoegen";
            this.Text = "WerknemerToevoegen";
            this.aGbGegevens.ResumeLayout(false);
            this.aGbGegevens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.GroupBox aGbGegevens;
        private System.Windows.Forms.RadioButton aRbAdminNee;
        private System.Windows.Forms.RadioButton aRbAdminJa;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtWachtwoordCheck;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label aLabelTel;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aLabelAdmin;
        private System.Windows.Forms.Label aLabelPass;
        private System.Windows.Forms.Label aLabelNaam;
        private System.Windows.Forms.Label aLabelEmail;
    }
}