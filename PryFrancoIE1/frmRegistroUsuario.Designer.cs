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
            this.pbxFirma = new System.Windows.Forms.PictureBox();
            this.gpbFirma.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFirma
            // 
            this.gpbFirma.Controls.Add(this.pbxFirma);
            this.gpbFirma.Controls.Add(this.btnLimpiar);
            this.gpbFirma.Location = new System.Drawing.Point(15, 232);
            this.gpbFirma.Name = "gpbFirma";
            this.gpbFirma.Size = new System.Drawing.Size(206, 204);
            this.gpbFirma.TabIndex = 19;
            this.gpbFirma.TabStop = false;
            this.gpbFirma.Text = "¡Firme aqui!";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(64, 170);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtContra
            // 
            this.txtContra.Enabled = false;
            this.txtContra.Location = new System.Drawing.Point(79, 105);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '+';
            this.txtContra.Size = new System.Drawing.Size(121, 20);
            this.txtContra.TabIndex = 15;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(12, 105);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 14;
            this.lblContra.Text = "Contraseña";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(79, 452);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 66);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(79, 63);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 11;
            // 
            // optRegistro
            // 
            this.optRegistro.AutoSize = true;
            this.optRegistro.Location = new System.Drawing.Point(6, 19);
            this.optRegistro.Name = "optRegistro";
            this.optRegistro.Size = new System.Drawing.Size(142, 17);
            this.optRegistro.TabIndex = 20;
            this.optRegistro.TabStop = true;
            this.optRegistro.Text = "Registro de Proveedores";
            this.optRegistro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optActivos);
            this.groupBox1.Controls.Add(this.optRegistro);
            this.groupBox1.Location = new System.Drawing.Point(15, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 75);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // optActivos
            // 
            this.optActivos.AutoSize = true;
            this.optActivos.Location = new System.Drawing.Point(6, 42);
            this.optActivos.Name = "optActivos";
            this.optActivos.Size = new System.Drawing.Size(117, 17);
            this.optActivos.TabIndex = 21;
            this.optActivos.TabStop = true;
            this.optActivos.Text = "Provedores Activos";
            this.optActivos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Crear Usuario";
            // 
            // pbxFirma
            // 
            this.pbxFirma.BackColor = System.Drawing.Color.White;
            this.pbxFirma.Location = new System.Drawing.Point(8, 12);
            this.pbxFirma.Name = "pbxFirma";
            this.pbxFirma.Size = new System.Drawing.Size(192, 152);
            this.pbxFirma.TabIndex = 8;
            this.pbxFirma.TabStop = false;
            // 
            // frmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbFirma);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroUsuario";
            this.Text = "Registro de Usuario";
            this.Load += new System.EventHandler(this.frmRegistroUsuario_Load);
            this.gpbFirma.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFirma)).EndInit();
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