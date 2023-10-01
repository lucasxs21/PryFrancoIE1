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
    public partial class frmRegistro_proveedores : Form
    {
        public frmRegistro_proveedores()
        {
            InitializeComponent();
        }
        clsProveedores ObjP = new clsProveedores();

        private void lblLiquidacion_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            string entidad = txtEntidad.Text;
            string apertura = dtpApertura.Value.ToShortDateString();
            string expediente = txtExpediente.Text;
            string juzgado = cmbJuzg.Text;
            string juris = cmbJuri.Text;
            string liqui = cmbLiqui.Text;
            string direccion = txtDireccion.Text;



            ObjP.Registrar(numero, entidad, apertura, expediente, juzgado, juris, direccion, liqui);
            ObjP.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);
        }

        private void frmRegistro_proveedores_Load(object sender, EventArgs e)
        {
            ObjP.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                txtNumero.Text = fila.Cells[0].Value.ToString();
                txtEntidad.Text = fila.Cells[1].Value.ToString();
                txtNumero.Text = fila.Cells[2].Value.ToString();
                //dtpApertura.Value = Convert.ToDateTime(fila.Cells[3].Value.ToString());
                txtExpediente.Text = fila.Cells[4].Value.ToString();
                cmbJuzg.Text = fila.Cells[5].Value.ToString();
                cmbJuri.Text = fila.Cells[6].Value.ToString();
                //cmbLiqui.Text = fila.Cells[8].Value.ToString();
                txtDireccion.Text = fila.Cells[7].Value.ToString();
            }
        }
    }
}
