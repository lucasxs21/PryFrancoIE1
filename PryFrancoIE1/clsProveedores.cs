using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PryFrancoIE1
{
    class clsProveedores
    {

        
        public void CargarInfo(DataGridView grilla, ComboBox cmbJuzg, ComboBox cmbJuri, ComboBox cmbLiqui)
        {
            string archivoProveedor = "Listado de aseguradores.csv";

            try
            {
                
                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        string[] separador = readLine.Split(';');
                        foreach (string columna in separador)
                        {
                            grilla.Columns.Add(columna, columna);
                        }
                        HashSet<string> jurisdicciones = new HashSet<string>();
                        HashSet<string> responsables = new HashSet<string>();
                        HashSet<string> juzgados = new HashSet<string>();

                        while (!sr.EndOfStream)
                        {
                            readLine = sr.ReadLine();
                            separador = readLine.Split(';');
                            grilla.Rows.Add(separador);

                            juzgados.Add(separador[4]);
                            jurisdicciones.Add(separador[5]);
                            responsables.Add(separador[7]);

                        }

                        foreach (string jurisdiccion in jurisdicciones)
                        {
                            cmbJuri.Items.Add(jurisdiccion);
                        }

                        foreach (string juzgado in juzgados)
                        {
                            cmbJuzg.Items.Add(juzgado);
                        }

                        foreach (string liquida in responsables)
                        {
                            cmbLiqui.Items.Add(liquida);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "ERROR", MessageBoxButtons.OK);
            }   
        }

        public void Registrar(Int32 id, string entidad, string Apertura, string expendiente, string juzg, string juri, string direccion, string liquidador)
        {
            string archivoProveedor = "Listado de aseguradores.csv";

            try
            {
                List<int> idsExistentes = new List<int>();

                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine;
                    while ((readLine = sr.ReadLine()) != null)
                    {
                        string[] separador = readLine.Split(';');

                        if (separador.Length >= 1 && int.TryParse(separador[0], out int existingID))
                        {
                            idsExistentes.Add(existingID);
                        }
                    }
                }

                if (!idsExistentes.Contains(id))
                {
                    string nuevoRegistro = $"{id};{entidad};{Apertura};{expendiente};{juzg};{juri};{direccion};{liquidador};";

                    using (StreamWriter sw = new StreamWriter(archivoProveedor, true))
                    {
                        sw.WriteLine(nuevoRegistro);
                    }
                }
                else
                {
                    MessageBox.Show("El ID ya existe en el archivo.", "ERROR", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        public void Modificar(TextBox id, TextBox entidad, DateTimePicker apertura, TextBox expediente, ComboBox juzg, ComboBox juri, ComboBox liquidador, TextBox direccion)
        {

        }
    
    }
}
