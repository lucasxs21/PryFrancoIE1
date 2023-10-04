namespace PryFrancoIE1
{
    partial class frmProvedores_Activos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProvedores_Activos));
            this.tvCarpetas = new System.Windows.Forms.TreeView();
            this.rtbContenido = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRetorno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvCarpetas
            // 
            this.tvCarpetas.Location = new System.Drawing.Point(12, 3);
            this.tvCarpetas.Name = "tvCarpetas";
            this.tvCarpetas.Size = new System.Drawing.Size(277, 143);
            this.tvCarpetas.TabIndex = 0;
            this.tvCarpetas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // rtbContenido
            // 
            this.rtbContenido.Location = new System.Drawing.Point(12, 152);
            this.rtbContenido.Name = "rtbContenido";
            this.rtbContenido.ReadOnly = true;
            this.rtbContenido.Size = new System.Drawing.Size(776, 254);
            this.rtbContenido.TabIndex = 1;
            this.rtbContenido.Text = "";
            this.rtbContenido.TextChanged += new System.EventHandler(this.rtbContenido_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONE UN ARCHIVO";
            // 
            // txtRetorno
            // 
            this.txtRetorno.Location = new System.Drawing.Point(12, 415);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(75, 23);
            this.txtRetorno.TabIndex = 35;
            this.txtRetorno.Text = "←";
            this.txtRetorno.UseVisualStyleBackColor = true;
            this.txtRetorno.Click += new System.EventHandler(this.txtRetorno_Click);
            // 
            // frmProvedores_Activos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRetorno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbContenido);
            this.Controls.Add(this.tvCarpetas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProvedores_Activos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProvedores_Activos";
            this.Load += new System.EventHandler(this.frmProvedores_Activos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvCarpetas;
        private System.Windows.Forms.RichTextBox rtbContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtRetorno;
    }
}