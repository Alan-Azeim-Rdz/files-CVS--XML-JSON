using Newtonsoft.Json;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace files_CVS__XML_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnOpen_Click(object sender, EventArgs e)
        {
            string Result = Combox_Selection_File();
            if (Result == null)
            {
                return;
            }
            string acces_route = open_file(Result);
            Data_show_TextBox(acces_route);
            Data_show_ListBox(acces_route);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Obtiene el tipo de archivo seleccionado
            string Result = Combox_Selection_File();
            if (Result == null)
            {
                return;
            }

            // Abre el diálogo para guardar el archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Guardar archivo",
                Filter = "Archivos " + Result + "|*" + Result + "*",
                FileName = "Archivo." + Result,
                AddExtension = true,
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Guarda el contenido según el tipo de archivo seleccionado
                try
                {
                    if (ComboxSeleciont.SelectedIndex == 0) // CSV
                    {
                        File.WriteAllText(filePath, TextBoxData.Text);
                    }
                    else if (ComboxSeleciont.SelectedIndex == 1) // XML
                    {
                        XDocument xmlDoc = XDocument.Parse(TextBoxData.Text);
                        xmlDoc.Save(filePath);
                    }
                    else if (ComboxSeleciont.SelectedIndex == 2) // JSON
                    {
                        var jsonObject = JsonConvert.DeserializeObject<dynamic>(TextBoxData.Text);
                        string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                        File.WriteAllText(filePath, json);
                    }
                    MessageBox.Show("Archivo guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private string Combox_Selection_File()
        {
            if (ComboxSeleciont.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de archivo porfavor");
                return null;
            }
            string File_Select = ComboxSeleciont.SelectedItem.ToString();
            return File_Select;
        }


        private string open_file(string Selection)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "selecciona un archivo",
                Filter = "Archivos " + Selection + "|*" + Selection + "*",
                Multiselect = false,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string Acces_route = openFileDialog.FileName;
                Openfile(Acces_route);
                return Acces_route;
            }
            return null;
        }

        private void Openfile(string Selection)
        {
            try
            {
                if (File.Exists(Selection))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = Selection,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al abrir el archivo: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Data_show_TextBox(string type)
        {
            try
            {
                if (ComboxSeleciont.SelectedIndex == 0)
                {
                    string text = File.ReadAllText(type);
                    TextBoxData.Text = text;
                }
                else if (ComboxSeleciont.SelectedIndex == 1)
                {
                    XDocument xmlDoc = XDocument.Load(type);
                    TextBoxData.Text = xmlDoc.ToString();
                }
                else if (ComboxSeleciont.SelectedIndex == 2)
                {
                    string json = File.ReadAllText(type);
                    var jsonObject = JsonConvert.DeserializeObject<dynamic>(json);
                    TextBoxData.Text = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                }
            }
            catch
            {
                MessageBox.Show("selecciona un archivo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Data_show_ListBox(string type)
        {
            LstbxShowData.Items.Clear();  // Limpiar el ListBox antes de agregar nuevos datos.

            if (ComboxSeleciont.SelectedIndex == 0) // CSV
            {
                string[] lines = File.ReadAllLines(type);

                // Dividir cada línea en columnas
                foreach (var line in lines)
                {
                    var columns = line.Split(',');  // Usar coma como delimitador (ajustar si usas otro delimitador)
                    LstbxShowData.Items.Add(string.Join("\t", columns)); // Usar tabulaciones para separar las columnas en el ListBox
                }
            }
            else if (ComboxSeleciont.SelectedIndex == 1) // XML
            {
                XDocument xmlDoc = XDocument.Load(type);

                // Agregar encabezados
                LstbxShowData.Items.Add("Elemento\tValor");

                // Recorrer todos los elementos en el XML
                foreach (var element in xmlDoc.Descendants())
                {
                    LstbxShowData.Items.Add($"{element.Name}\t{element.Value}"); // Usar tabulaciones para separar nombre y valor
                }
            }
            else if (ComboxSeleciont.SelectedIndex == 2) // JSON
            {
                string json = File.ReadAllText(type);

                // Deserializar el JSON de manera dinámica
                var jsonObject = JsonConvert.DeserializeObject<dynamic>(json);

                // Agregar encabezados
                LstbxShowData.Items.Add("Clave\tValor");

                // Recorrer los datos y agregarlos al ListBox
                foreach (var item in jsonObject)
                {
                    LstbxShowData.Items.Add($"{item.Name}\t{item.Value}"); // Usar tabulaciones para separar la clave y el valor
                }
            }
            return;
        }
    }

}

