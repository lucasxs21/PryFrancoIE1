﻿namespace PryFrancoIE1
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblini = new System.Windows.Forms.Label();
            this.lblOlvideUser = new System.Windows.Forms.LinkLabel();
            this.lblOlvideContra = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(94, 62);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 65);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario ";
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(77, 187);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Confirmar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(12, 134);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 3;
            this.lblContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.Enabled = false;
            this.txtContra.Location = new System.Drawing.Point(94, 131);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '+';
            this.txtContra.Size = new System.Drawing.Size(121, 20);
            this.txtContra.TabIndex = 4;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // lblini
            // 
            this.lblini.AutoSize = true;
            this.lblini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblini.Location = new System.Drawing.Point(48, 9);
            this.lblini.Name = "lblini";
            this.lblini.Size = new System.Drawing.Size(154, 20);
            this.lblini.TabIndex = 5;
            this.lblini.Text = "Acceso al sistema";
            // 
            // lblOlvideUser
            // 
            this.lblOlvideUser.AutoSize = true;
            this.lblOlvideUser.Location = new System.Drawing.Point(96, 85);
            this.lblOlvideUser.Name = "lblOlvideUser";
            this.lblOlvideUser.Size = new System.Drawing.Size(87, 13);
            this.lblOlvideUser.TabIndex = 6;
            this.lblOlvideUser.TabStop = true;
            this.lblOlvideUser.Text = "Olvidé mi usuario";
            this.lblOlvideUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOlvideUser_LinkClicked);
            // 
            // lblOlvideContra
            // 
            this.lblOlvideContra.AutoSize = true;
            this.lblOlvideContra.Location = new System.Drawing.Point(96, 159);
            this.lblOlvideContra.Name = "lblOlvideContra";
            this.lblOlvideContra.Size = new System.Drawing.Size(106, 13);
            this.lblOlvideContra.TabIndex = 7;
            this.lblOlvideContra.TabStop = true;
            this.lblOlvideContra.Text = "Olvidé mi contraseña";
            this.lblOlvideContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOlvideContra_LinkClicked);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 239);
            this.Controls.Add(this.lblOlvideContra);
            this.Controls.Add(this.lblOlvideUser);
            this.Controls.Add(this.lblini);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblini;
        private System.Windows.Forms.LinkLabel lblOlvideUser;
        private System.Windows.Forms.LinkLabel lblOlvideContra;
    }
}