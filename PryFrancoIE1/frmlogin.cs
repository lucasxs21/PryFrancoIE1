using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Microsoft.Win32;

namespace PryFrancoIE1
{
    public partial class frmlogin : Form
    {
        
        public frmlogin()
        {
            InitializeComponent();
            
        }
        ClsvalidacionID validacion = new ClsvalidacionID();
        int contador = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validacion.ValidarUsuario(txtUsuario.Text , txtContra.Text))
            {
                //StreamWriter sw = new StreamWriter("logGenerales", true);
                //sw.WriteLine(txtUsuario.Text + "-Fecha-" + DateTime.Now + btnLogin.Text);
                //sw.Close();

                string Usuario = txtUsuario.Text;
                DateTime fecha = DateTime.Now;
                string Accion = btnLogin.Text;

                ClsvalidacionID registro = new ClsvalidacionID();
                registro.CargarLogs(Usuario, fecha, Accion);


                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                this.Hide();

                

            }
            else
            {
                contador++;
                MessageBox.Show("Usuario o contraseña incorrecta");
                if (contador == 3)
                {
                    MessageBox.Show("Demasiados intentos");
                    this.Close();

                }
            }
            //permisos 
            

            string usuario = txtUsuario.Text;

            ClsvalidacionID.Usuario = usuario;

            

        }



        private void frmlogin_Load(object sender, EventArgs e)
        {
           
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtContra.Enabled = true;
        }

        private void lblOlvideUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Admin", "Su Usuario es:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblOlvideContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Admin", "Su Contraseña es:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Llama al método del botón
                btnLogin_Click(btnLogin, EventArgs.Empty);
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Llama al método del botón
                btnLogin_Click(btnLogin, EventArgs.Empty);
            }
        }
    }
}
