﻿using System;
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
        clsProveedores ObjProv = new clsProveedores();

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


            try
            {
                ObjProv.Registrar(numero, entidad, apertura, expediente, juzgado, juris, direccion, liqui);
                limpiarGrilla();
                ObjProv.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);
                btnAgregar.Enabled = false;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "", MessageBoxButtons.OK);
            }
        }

        private void frmRegistro_proveedores_Load(object sender, EventArgs e)
        {
            ObjProv.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProveedores.Rows[e.RowIndex];

                string numeroRegistro = selectedRow.Cells[0].Value.ToString();
                string entidad = selectedRow.Cells[1].Value.ToString();
                DateTime apertura = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                string numExpediente = selectedRow.Cells[3].Value.ToString();
                string juzgado = selectedRow.Cells[4].Value.ToString();
                string jurisdiccion = selectedRow.Cells[5].Value.ToString();
                string direccion = selectedRow.Cells[6].Value.ToString();
                string responsable = selectedRow.Cells[7].Value.ToString();

                txtNumero.Text = numeroRegistro;
                txtEntidad.Text = entidad;
                dtpApertura.Value = apertura;
                txtExpediente.Text = numExpediente;
                cmbJuzg.Text = juzgado;
                cmbJuri.Text = jurisdiccion;
                txtDireccion.Text = direccion;
                cmbLiqui.Text = responsable;

                txtNumero.ReadOnly = true;
                btnModificar.Enabled = true;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int numero = Convert.ToInt32(txtNumero.Text);
            string entidad = txtEntidad.Text;
            string apertura = dtpApertura.Value.ToShortDateString();
            string expediente = txtExpediente.Text;
            string juzgado = cmbJuzg.Text;
            string juris = cmbJuri.Text;
            string liqui = cmbLiqui.Text;
            string direccion = txtDireccion.Text;


            try
            {
                ObjProv.Modificar(numero, entidad, apertura, expediente, juzgado, juris, direccion, liqui);
                limpiarGrilla();
                ObjProv.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);
                btnAgregar.Enabled = false;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "", MessageBoxButtons.OK);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Estás seguro de que deseas eliminar?", "Confirmación", MessageBoxButtons.YesNo);
            int numero = Convert.ToInt32(txtNumero.Text);

            if (pregunta == DialogResult.Yes)
            {
                ObjProv.Eliminar(numero);
                limpiarGrilla();
                ObjProv.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtDireccion.Text = "";
            txtEntidad.Text = "";
            txtExpediente.Text = "";
            txtNumero.Text = "";
            cmbJuri.SelectedIndex = -1;
            cmbJuzg.SelectedIndex = -1;
            cmbLiqui.SelectedIndex = -1;
        }

        //limpiar grilla
        private void limpiarGrilla()
        {
            dgvProveedores.Rows.Clear();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != null)
            {
                btnLimpiar.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != null && txtEntidad.Text != null && txtExpediente.Text != null && txtDireccion.Text != null && cmbLiqui.SelectedIndex != -1 && cmbJuzg.SelectedIndex != -1 && cmbJuri.SelectedIndex != -1)
            {
                btnAgregar.Enabled = true;
            }
        }

        private void txtRetorno_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();

            frm.Show();
            this.Hide();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
