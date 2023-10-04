namespace PryFrancoIE1
{
    partial class frmRegistro_proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro_proveedores));
            this.lblN = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpApertura = new System.Windows.Forms.DateTimePicker();
            this.cmbJuzg = new System.Windows.Forms.ComboBox();
            this.cmbJuri = new System.Windows.Forms.ComboBox();
            this.lblLiquidacion = new System.Windows.Forms.Label();
            this.cmbLiqui = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juzgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurisdiccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liquidador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRetorno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(52, 45);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(19, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Nº";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(169, 38);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(134, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entidad:";
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(169, 89);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(134, 20);
            this.txtEntidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apertura";
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(169, 184);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(134, 20);
            this.txtExpediente.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(169, 322);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(134, 20);
            this.txtDireccion.TabIndex = 9;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.Entidad,
            this.Apertura,
            this.Expediente,
            this.juzgado,
            this.jurisdiccion,
            this.Direccion,
            this.Liquidador});
            this.dgvProveedores.Location = new System.Drawing.Point(412, 35);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(844, 372);
            this.dgvProveedores.TabIndex = 10;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nº Expediente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Juzgado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Jurisdiccion";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(52, 329);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Direccion";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Location = new System.Drawing.Point(331, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.Location = new System.Drawing.Point(331, 79);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(331, 368);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpApertura
            // 
            this.dtpApertura.Location = new System.Drawing.Point(169, 136);
            this.dtpApertura.Name = "dtpApertura";
            this.dtpApertura.Size = new System.Drawing.Size(134, 20);
            this.dtpApertura.TabIndex = 28;
            // 
            // cmbJuzg
            // 
            this.cmbJuzg.FormattingEnabled = true;
            this.cmbJuzg.Location = new System.Drawing.Point(169, 231);
            this.cmbJuzg.Name = "cmbJuzg";
            this.cmbJuzg.Size = new System.Drawing.Size(134, 21);
            this.cmbJuzg.TabIndex = 29;
            // 
            // cmbJuri
            // 
            this.cmbJuri.FormattingEnabled = true;
            this.cmbJuri.Location = new System.Drawing.Point(169, 281);
            this.cmbJuri.Name = "cmbJuri";
            this.cmbJuri.Size = new System.Drawing.Size(134, 21);
            this.cmbJuri.TabIndex = 30;
            // 
            // lblLiquidacion
            // 
            this.lblLiquidacion.AutoSize = true;
            this.lblLiquidacion.Location = new System.Drawing.Point(52, 373);
            this.lblLiquidacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLiquidacion.Name = "lblLiquidacion";
            this.lblLiquidacion.Size = new System.Drawing.Size(121, 13);
            this.lblLiquidacion.TabIndex = 31;
            this.lblLiquidacion.Text = "Liquidador Responsable";
            this.lblLiquidacion.Click += new System.EventHandler(this.lblLiquidacion_Click);
            // 
            // cmbLiqui
            // 
            this.cmbLiqui.FormattingEnabled = true;
            this.cmbLiqui.Location = new System.Drawing.Point(169, 370);
            this.cmbLiqui.Name = "cmbLiqui";
            this.cmbLiqui.Size = new System.Drawing.Size(134, 21);
            this.cmbLiqui.TabIndex = 32;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Location = new System.Drawing.Point(331, 122);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // numero
            // 
            this.numero.HeaderText = "N";
            this.numero.Name = "numero";
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.Name = "Entidad";
            // 
            // Apertura
            // 
            this.Apertura.HeaderText = "Apertura";
            this.Apertura.Name = "Apertura";
            // 
            // Expediente
            // 
            this.Expediente.HeaderText = "N expediente";
            this.Expediente.Name = "Expediente";
            // 
            // juzgado
            // 
            this.juzgado.HeaderText = "Juzgado";
            this.juzgado.Name = "juzgado";
            // 
            // jurisdiccion
            // 
            this.jurisdiccion.HeaderText = "Jurisdiccion";
            this.jurisdiccion.Name = "jurisdiccion";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Liquidador
            // 
            this.Liquidador.HeaderText = "Liquidador Responsable";
            this.Liquidador.Name = "Liquidador";
            // 
            // txtRetorno
            // 
            this.txtRetorno.Location = new System.Drawing.Point(12, 422);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(75, 23);
            this.txtRetorno.TabIndex = 34;
            this.txtRetorno.Text = "←";
            this.txtRetorno.UseVisualStyleBackColor = true;
            this.txtRetorno.Click += new System.EventHandler(this.txtRetorno_Click);
            // 
            // frmRegistro_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 450);
            this.Controls.Add(this.txtRetorno);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbLiqui);
            this.Controls.Add(this.lblLiquidacion);
            this.Controls.Add(this.cmbJuri);
            this.Controls.Add(this.cmbJuzg);
            this.Controls.Add(this.dtpApertura);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtExpediente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistro_proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Proveedor de Seguro (PAS)";
            this.Load += new System.EventHandler(this.frmRegistro_proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpApertura;
        private System.Windows.Forms.ComboBox cmbJuzg;
        private System.Windows.Forms.ComboBox cmbJuri;
        private System.Windows.Forms.Label lblLiquidacion;
        private System.Windows.Forms.ComboBox cmbLiqui;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn juzgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurisdiccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liquidador;
        private System.Windows.Forms.Button txtRetorno;
    }
}