namespace PryFrancoIE1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusgeneral = new System.Windows.Forms.StatusStrip();
            this.statusFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerhora = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusgeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.listadoReportesToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem1});
            this.gestionToolStripMenuItem.Enabled = false;
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            // 
            // registroDeProveedoresToolStripMenuItem
            // 
            this.registroDeProveedoresToolStripMenuItem.Name = "registroDeProveedoresToolStripMenuItem";
            this.registroDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.registroDeProveedoresToolStripMenuItem.Text = "Registro de proveedores";
            this.registroDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.registroDeProveedoresToolStripMenuItem_Click);
            // 
            // listadoReportesToolStripMenuItem
            // 
            this.listadoReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.listadoReportesToolStripMenuItem.Name = "listadoReportesToolStripMenuItem";
            this.listadoReportesToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.listadoReportesToolStripMenuItem.Text = "Listado/Reportes";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activosToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // activosToolStripMenuItem
            // 
            this.activosToolStripMenuItem.Name = "activosToolStripMenuItem";
            this.activosToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.activosToolStripMenuItem.Text = "Activos";
            this.activosToolStripMenuItem.Click += new System.EventHandler(this.activosToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Enabled = false;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // registrarNuevoUsuarioToolStripMenuItem
            // 
            this.registrarNuevoUsuarioToolStripMenuItem.Name = "registrarNuevoUsuarioToolStripMenuItem";
            this.registrarNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.registrarNuevoUsuarioToolStripMenuItem.Text = "Registrar Nuevo Usuario";
            this.registrarNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoUsuarioToolStripMenuItem_Click);
            // 
            // statusgeneral
            // 
            this.statusgeneral.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusgeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusFecha,
            this.statusHora,
            this.statusUser});
            this.statusgeneral.Location = new System.Drawing.Point(0, 528);
            this.statusgeneral.Name = "statusgeneral";
            this.statusgeneral.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.statusgeneral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusgeneral.Size = new System.Drawing.Size(1067, 26);
            this.statusgeneral.TabIndex = 1;
            this.statusgeneral.Text = "statusStrip1";
            this.statusgeneral.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusgeneral_ItemClicked);
            // 
            // statusFecha
            // 
            this.statusFecha.Name = "statusFecha";
            this.statusFecha.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.statusFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusFecha.Size = new System.Drawing.Size(45, 20);
            this.statusFecha.Text = "fecha";
            // 
            // statusHora
            // 
            this.statusHora.Name = "statusHora";
            this.statusHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusHora.Size = new System.Drawing.Size(39, 20);
            this.statusHora.Text = "hora";
            // 
            // statusUser
            // 
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(57, 20);
            this.statusUser.Text = "usuario";
            this.statusUser.Click += new System.EventHandler(this.toolStripStatusLabel1_Click_1);
            // 
            // timerhora
            // 
            this.timerhora.Enabled = true;
            this.timerhora.Interval = 1000;
            this.timerhora.Tick += new System.EventHandler(this.timerhora_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Esperanza Seguros";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryFrancoIE1.Properties.Resources.FOTOS_04;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusgeneral);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esperanza seguros ";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusgeneral.ResumeLayout(false);
            this.statusgeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusgeneral;
        private System.Windows.Forms.ToolStripStatusLabel statusFecha;
        private System.Windows.Forms.ToolStripStatusLabel statusHora;
        private System.Windows.Forms.Timer timerhora;
        private System.Windows.Forms.ToolStripStatusLabel statusUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoUsuarioToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem listadoReportesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
    }
}

