using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace files_CVS__XML_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Combox_Selection_File();

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            string Result = Combox_Selection_File();
            if (Result == null)
            {
                return;
            }
            string acces_route = open_file(Result);
            Data_show_ListBox(acces_route);

        }



        private void BtnSave_Click(object sender, EventArgs e)
        {
            Combox_Selection_File();
        }

        //metodo de verifiacion de eleccion del Combo Box
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


        //metodo para abrir archivos 
        private string open_file(string Selection)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "seleciona un archivo",
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
                        UseShellExecute = true // Abre con el programa predeterminado
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

        //metodo para mostrar los datos del archivo en la listbox
        private void Data_show_ListBox (string type)
        {
            if (ComboxSeleciont.SelectedIndex == 0)
            {

                string[] lines = File.ReadAllLines(type);

                foreach (var line in lines)
                {
                    LstbxShowData.Items.Add(line);
                }
            }
            else if (ComboxSeleciont.SelectedIndex == 1)
            {
                XDocument xmlDoc = XDocument.Load(type);

                // Recorrer todos los elementos en el XML
                foreach (var element in xmlDoc.Descendants())
                {
                    LstbxShowData.Items.Add(element.Name + ": " + element.Value);
                }

            }
            else if (ComboxSeleciont.SelectedIndex == 2)
            {

                string json = File.ReadAllText(type);

                // Deserializar el JSON de manera dinámica
                var jsonObject = JsonConvert.DeserializeObject<dynamic>(json);

                // Recorrer los datos y agregarlos al ListBox
                foreach (var item in jsonObject)
                {
                    LstbxShowData.Items.Add(item);
                }
            }
            return;
        }
    }
}
