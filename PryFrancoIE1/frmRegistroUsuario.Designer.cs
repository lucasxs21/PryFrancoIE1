namespace PryFrancoIE1
{
    partial class frmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroUsuario));
            this.gpbFirma = new System.Windows.Forms.GroupBox();
            this.pbxFirma = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.optRegistro = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optActivos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbFirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFirma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFirma
            // 
            this.gpbFirma.Controls.Add(this.pbxFirma);
            this.gpbFirma.Controls.Add(this.btnLimpiar);
            this.gpbFirma.Location = new System.Drawing.Point(20, 286);
            this.gpbFirma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbFirma.Name = "gpbFirma";
            this.gpbFirma.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbFirma.Size = new System.Drawing.Size(275, 251);
            this.gpbFirma.TabIndex = 19;
            this.gpbFirma.TabStop = false;
            this.gpbFirma.Text = "¡Firme aqui!";
            // 
            // pbxFirma
            // 
            this.pbxFirma.BackColor = System.Drawing.Color.White;
            this.pbxFirma.Location = new System.Drawing.Point(11, 15);
            this.pbxFirma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxFirma.Name = "pbxFirma";
            this.pbxFirma.Size = new System.Drawing.Size(256, 187);
            this.pbxFirma.TabIndex = 8;
            this.pbxFirma.TabStop = false;
            this.pbxFirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxFirma_MouseDown);
            this.pbxFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxFirma_MouseMove);
            this.pbxFirma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxFirma_MouseUp);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(85, 209);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtContra
            // 
            this.txtContra.Enabled = false;
            this.txtContra.Location = new System.Drawing.Point(105, 129);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '+';
            this.txtContra.Size = new System.Drawing.Size(160, 22);
            this.txtContra.TabIndex = 15;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(16, 129);
            this.lblContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(76, 16);
            this.lblContra.TabIndex = 14;
            this.lblContra.Text = "Contraseña";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(105, 556);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(16, 81);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(105, 78);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(160, 22);
            this.txtUsuario.TabIndex = 11;
            // 
            // optRegistro
            // 
            this.optRegistro.AutoSize = true;
            this.optRegistro.Location = new System.Drawing.Point(8, 23);
            this.optRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optRegistro.Name = "optRegistro";
            this.optRegistro.Size = new System.Drawing.Size(180, 20);
            this.optRegistro.TabIndex = 20;
            this.optRegistro.TabStop = true;
            this.optRegistro.Text = "Registro de Proveedores";
            this.optRegistro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optActivos);
            this.groupBox1.Controls.Add(this.optRegistro);
            this.groupBox1.Location = new System.Drawing.Point(20, 186);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(275, 92);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // optActivos
            // 
            this.optActivos.AutoSize = true;
            this.optActivos.Location = new System.Drawing.Point(8, 52);
            this.optActivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optActivos.Name = "optActivos";
            this.optActivos.Size = new System.Drawing.Size(146, 20);
            this.optActivos.TabIndex = 21;
            this.optActivos.TabStop = true;
            this.optActivos.Text = "Provedores Activos";
            this.optActivos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Crear Usuario";
            // 
            // frmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbFirma);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegistroUsuario";
            this.Text = "Registro de Usuario";
            this.Load += new System.EventHandler(this.frmRegistroUsuario_Load);
            this.gpbFirma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFirma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFirma;
        private System.Windows.Forms.PictureBox pbxFirma;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.RadioButton optRegistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optActivos;
        private System.Windows.Forms.Label label1;
    }
}