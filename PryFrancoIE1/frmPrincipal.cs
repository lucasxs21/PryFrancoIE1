using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PryFrancoIE1
{
    public partial class frmPrincipal : Form
    {
        private string usuario;
        public frmPrincipal()
        {
            InitializeComponent();
            this.usuario = usuario;        
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        

            ClsvalidacionID registro1 = new ClsvalidacionID();

            string rolUsuario = registro1.ObtenerRolUsuario();

            if (rolUsuario == "Admin")
            {
                // Habilita el botón

                gestionToolStripMenuItem.Enabled = true;
                usuarioToolStripMenuItem.Enabled = true;
            }
            else
            {

                gestionToolStripMenuItem.Enabled = false;
                usuarioToolStripMenuItem.Enabled = false;
            }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timerhora_Tick(object sender, EventArgs e)
        {
            statusHora.Text = DateTime.Now.ToLongTimeString();
            statusFecha.Text = DateTime.Now.ToLongDateString();
            statusUser.Text = ClsvalidacionID.Usuario;

           

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Usuario = ClsvalidacionID.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = registroDeProveedoresToolStripMenuItem.Text;

            ClsvalidacionID registro = new ClsvalidacionID();
            registro.CargarLogs(Usuario, fecha, Accion); 

            frmRegistro_proveedores frm = new frmRegistro_proveedores();

            frm.Show();
            this.Hide();

        }

        private void statusgeneral_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Usuario = ClsvalidacionID.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = activosToolStripMenuItem.Text;

            ClsvalidacionID registro = new ClsvalidacionID();
            registro.CargarLogs(Usuario, fecha, Accion);

            frmProvedores_Activos frm = new frmProvedores_Activos();

            frm.Show();
            this.Hide();

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Usuario = ClsvalidacionID.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = registrarNuevoUsuarioToolStripMenuItem.Text;

            ClsvalidacionID registro = new ClsvalidacionID();
            registro.CargarLogs(Usuario, fecha, Accion);

            frmRegistroUsuario frm = new frmRegistroUsuario();

            frm.Show();
            //this.Hide();

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
