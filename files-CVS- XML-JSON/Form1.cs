using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml;

namespace files_CVS__XML_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LstbxShowData.DoubleClick += EditarItem;
        }

        private void BtnCVSCreate_Click(object sender, EventArgs e)
        {
            if (LstbxShowData.Items.Count == 0)
            {
                MessageBox.Show("No hay datos en la lista para guardar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Guardar archivo CSV",
                Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*",
                DefaultExt = "csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear una lista con los elementos del ListBox
                    List<string> lineas = new List<string>();
                    foreach (var item in LstbxShowData.Items)
                    {
                        lineas.Add(item.ToString());
                    }

                    // Escribir los datos en el archivo CSV
                    File.WriteAllLines(saveFileDialog.FileName, lineas);

                    MessageBox.Show("¡Archivo CSV creado exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }


        private void BtnOpenCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Seleciona el archivo",
                Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LstbxShowData.Items.Clear();
                LblSelectFile.Text = openFileDialog.FileName;

                foreach (var linea in File.ReadLines(openFileDialog.FileName))
                {
                    LstbxShowData.Items.Add(linea);
                }
            }
            else
            {
                MessageBox.Show("No seleciono ningun archivo");
            }
        }

        private void BtnSaveCSV_Click(object sender, EventArgs e)
        {
            if (LstbxShowData.Items.Count == 0)
            {
                MessageBox.Show("No hay datos para guardar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Guardar archivo CSV",
                Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*",
                DefaultExt = "csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear una lista con los datos del ListBox
                    List<string> lineas = new List<string>();
                    foreach (var item in LstbxShowData.Items)
                    {
                        lineas.Add(item.ToString());
                    }

                    // Guardar el archivo CSV con los datos modificados
                    File.WriteAllLines(saveFileDialog.FileName, lineas);

                    MessageBox.Show("¡Archivo CSV modificado y guardado exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }
        private void BtnXMLCreate_Click(object sender, EventArgs e)
        {
            if (LstbxShowData.Items.Count == 0)
            {
                MessageBox.Show("No hay datos en la lista para guardar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Guardar archivo XML",
                Filter = "Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*",
                DefaultExt = "xml"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear un objeto XmlDocument para estructurar el archivo XML
                    System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();

                    // Crear la raíz del documento XML
                    XmlElement root = xmlDoc.CreateElement("Items");
                    xmlDoc.AppendChild(root);

                    // Recorrer los elementos del ListBox y agregarlos al XML
                    foreach (var item in LstbxShowData.Items)
                    {
                        XmlElement element = xmlDoc.CreateElement("Item");
                        element.InnerText = item.ToString();
                        root.AppendChild(element);
                    }

                    // Guardar el archivo XML
                    xmlDoc.Save(saveFileDialog.FileName);

                    MessageBox.Show("¡Archivo XML creado exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo XML: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }

        private void BtnOpenXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Selecciona el archivo XML",
                Filter = "Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LstbxShowData.Items.Clear();
                LblSelectFile.Text = openFileDialog.FileName;

                try
                {
                    // Cargar el archivo XML
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(openFileDialog.FileName);

                    // Buscar todos los elementos "Item" en el archivo XML
                    XmlNodeList items = xmlDoc.GetElementsByTagName("Item");

                    // Agregar cada "Item" al ListBox
                    foreach (XmlNode item in items)
                    {
                        LstbxShowData.Items.Add(item.InnerText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo XML: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No seleccionó ningún archivo.");
            }
        }


        private void BtnSaveXML_Click(object sender, EventArgs e)
        {
            if (LstbxShowData.Items.Count == 0)
            {
                MessageBox.Show("No hay datos para guardar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Guardar archivo XML",
                Filter = "Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*",
                DefaultExt = "xml"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear un objeto XmlDocument para estructurar el archivo XML
                    System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();

                    // Crear la raíz del documento XML
                    XmlElement root = xmlDoc.CreateElement("Items");
                    xmlDoc.AppendChild(root);

                    // Recorrer los elementos del ListBox y agregarlos al XML
                    foreach (var item in LstbxShowData.Items)
                    {
                        XmlElement element = xmlDoc.CreateElement("Item");
                        element.InnerText = item.ToString();
                        root.AppendChild(element);
                    }

                    // Guardar el archivo XML
                    xmlDoc.Save(saveFileDialog.FileName);

                    MessageBox.Show("¡Archivo XML creado y guardado exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo XML: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }

            private void BtnJSONCreate_Click(object sender, EventArgs e)
        {
            if (LstbxShowData.Items.Count == 0)
            {
                MessageBox.Show("No hay datos para guardar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Guardar archivo JSON",
                Filter = "Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*",
                DefaultExt = "json"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear un diccionario o lista de objetos para convertir a JSON
                    List<string> lineas = new List<string>();
                    foreach (var item in LstbxShowData.Items)
                    {
                        lineas.Add(item.ToString());
                    }

                    // Convertir la lista a un formato JSON
                    string json = JsonConvert.SerializeObject(lineas, Newtonsoft.Json.Formatting.Indented);

                    // Guardar el archivo JSON
                    File.WriteAllText(saveFileDialog.FileName, json);

                    MessageBox.Show("¡Archivo JSON creado exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo JSON: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }



        private void BtnOpenJSON_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Selecciona el archivo JSON",
                Filter = "Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LstbxShowData.Items.Clear();
                LblSelectFile.Text = openFileDialog.FileName;

                try
                {
                    // Leer el archivo JSON completo
                    string json = File.ReadAllText(openFileDialog.FileName);

                    // Deserializar el JSON dinámicamente
                    JArray jsonArray = JArray.Parse(json);

                    // Procesar cada elemento del JSON
                    foreach (JToken token in jsonArray)
                    {
                        if (token.Type == JTokenType.Object)
                        {
                            // Si el token es un objeto, procesarlo como JObject
                            JObject obj = (JObject)token;
                            foreach (var property in obj.Properties())
                            {
                                LstbxShowData.Items.Add($"{property.Name}: {property.Value}");
                            }
                        }
                        else if (token.Type == JTokenType.Array)
                        {
                            // Si el token es una lista, procesarlo como JArray
                            JArray array = (JArray)token;
                            foreach (var item in array)
                            {
                                LstbxShowData.Items.Add(item.ToString());
                            }
                        }
                        else
                        {
                            // Si es otro tipo de dato (ej. string, int, etc.), agregarlo directamente
                            LstbxShowData.Items.Add(token.ToString());
                        }
                    }
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Error al leer el archivo JSON: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No seleccionó ningún archivo.");
            }
        }




        private void BtnSaveJSON_Click(object sender, EventArgs e)
        {
            if (LstbxShowData.Items.Count == 0)
            {
                MessageBox.Show("No hay datos para guardar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Guardar archivo JSON",
                Filter = "Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*",
                DefaultExt = "json"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear una lista con los datos del ListBox
                    List<string> lineas = new List<string>();
                    foreach (var item in LstbxShowData.Items)
                    {
                        lineas.Add(item.ToString());
                    }

                    // Convertir la lista a formato JSON
                    string json = JsonConvert.SerializeObject(lineas,Newtonsoft.Json.Formatting.Indented);

                    // Guardar el archivo JSON
                    File.WriteAllText(saveFileDialog.FileName, json);

                    MessageBox.Show("¡Archivo JSON guardado exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo JSON: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }

        private void EditarItem(object sender, EventArgs e)
        {
            if (LstbxShowData.SelectedItem == null) return;

            int index = LstbxShowData.SelectedIndex;

            string nuevoValor = Prompt("Editar Registro", LstbxShowData.SelectedItem.ToString());

            if (!string.IsNullOrEmpty(nuevoValor))
            {
                LstbxShowData.Items[index] = nuevoValor;
            }
        }
        private string Prompt(string mensaje, string valorPorDefecto)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(mensaje, "Editar", valorPorDefecto);
        }

    }
}
