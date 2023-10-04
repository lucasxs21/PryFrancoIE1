using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFrancoIE1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timerhora_Tick(object sender, EventArgs e)
        {
            statusHora.Text = DateTime.Now.ToLongTimeString();
            statusFecha.Text = DateTime.Now.ToLongDateString();
            statusUser.Text = "Admin";
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro_proveedores frm = new frmRegistro_proveedores();

            frm.Show();
            this.Hide();

        }

        private void statusgeneral_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvedores_Activos frm = new frmProvedores_Activos();

            frm.Show();
            this.Hide();

        }
    }
}
