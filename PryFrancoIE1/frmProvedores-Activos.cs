using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFrancoIE1
{
    public partial class frmProvedores_Activos : Form
    {
        public frmProvedores_Activos()
        {
            InitializeComponent();
        }
        // Ruta de la carpeta principal del proyecto
        //string rutaProyecto = @"C:\Users\Lucas Franco\source\repos\PryFrancoIE154\PryFrancoIE1\Proveedores";
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Comprueba si el nodo seleccionado es un archivo (en lugar de una carpeta)
            if (selectedNode.Tag != null)
            {
                string archivoSeleccionado = selectedNode.Tag.ToString(); // Obtiene la ruta completa del archivo

                try
                {
                    // Lee el contenido del archivo
                    string contenido = File.ReadAllText(archivoSeleccionado);

                    rtbContenido.Visible = true;
                    // Muestra el contenido en el RichTextBox
                    rtbContenido.Text = contenido;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
            else
            {
                // Si no es un archivo, borra el contenido del RichTextBox
                rtbContenido.Text = "";
            }

        }

        private void frmProvedores_Activos_Load(object sender, EventArgs e)
        {
            //string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            //string carpetaProveedores = "Proveedores";

            //string rutaCompleta = Path.Combine(rutaBase, carpetaProveedores);

            string rutaCompleta = @"../../Proveedores";

            // Agregar la carpeta principal al árbol
            TreeNode rootNode = new TreeNode("Carpetas y Archivos del Proyecto");
            tvCarpetas.Nodes.Add(rootNode);

            // Llamamos a un método recursivo para agregar carpetas y archivos
            AgregarCarpetasYArchivos(rootNode, rutaCompleta);

        }
        private void AgregarCarpetasYArchivos(TreeNode parentNode, string ruta)
        {
            try
            {
                // Obtener carpetas y archivos dentro de la ruta especificada
                string[] carpetas = Directory.GetDirectories(ruta);
                string[] archivos = Directory.GetFiles(ruta);

                // Agregar carpetas al nodo actual
                foreach (string nombrecarpeta in carpetas)
                {
                    TreeNode carpetaNode = new TreeNode(Path.GetFileName(nombrecarpeta));
                    parentNode.Nodes.Add(carpetaNode);

                    // Llamar recursivamente para agregar carpetas y archivos dentro de esta carpeta
                    AgregarCarpetasYArchivos(carpetaNode, nombrecarpeta);
                }

                // Agregar archivos al nodo actual
                foreach (string nombreArchivo in archivos)
                {
                    TreeNode archivoNode = new TreeNode(Path.GetFileName(nombreArchivo));
                    archivoNode.Tag = nombreArchivo; // Almacena la ruta completa del archivo como un valor asociado
                    parentNode.Nodes.Add(archivoNode);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al acceder a carpetas/archivos
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtRetorno_Click(object sender, EventArgs e)
        {

            string Usuario = ClsvalidacionID.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = "Pagina Principal";

            ClsvalidacionID registro = new ClsvalidacionID();
            registro.CargarLogs(Usuario, fecha, Accion);

            frmPrincipal frm = new frmPrincipal();

            frm.Show();
            this.Hide();
        }

        private void rtbContenido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
