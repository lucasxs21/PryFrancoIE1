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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        int contadorTiempo = 0;
        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            contadorTiempo += 1000;
            if (contadorTiempo > 3000)
            {
                this.Hide();
                frmlogin frm = new frmlogin();
                frm.Show();
                timer.Enabled = false;
            }
        }
    }
}
