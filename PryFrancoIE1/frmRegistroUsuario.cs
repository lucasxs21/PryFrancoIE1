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
    public partial class frmRegistroUsuario : Form
    {
        private bool drawing;
        private Point previousPoint;
        private Bitmap drawingBitmap;
        public frmRegistroUsuario()
        {
            InitializeComponent();
            InitializeDrawing();
        }
        private void InitializeDrawing()
        {
            drawingBitmap = new Bitmap(pbxFirma.Width, pbxFirma.Height);
            pbxFirma.Image = drawingBitmap;
        }

        private void frmRegistroUsuario_Load(object sender, EventArgs e)
        {

        }
        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContra.Text;
            bool permisoProv = optRegistro.Checked;
            bool permisoActiv = optActivos.Checked;
            Image firma = pbxFirma.Image;

            ClsvalidacionID registro = new ClsvalidacionID();
            registro.InsertarUsuario(usuario, contrasena, permisoProv, permisoActiv, firma);
        }

        private void pbxFirma_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            previousPoint = e.Location;
        }

        private void pbxFirma_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void pbxFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    g.DrawLine(new Pen(Color.Black, 2), previousPoint, e.Location);
                }

                pbxFirma.Invalidate();
                previousPoint = e.Location;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(drawingBitmap))
            {
                g.Clear(Color.White);
            }
            pbxFirma.Invalidate();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtContra.Enabled = true;
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled=true;                                                  
        }
    }
}
