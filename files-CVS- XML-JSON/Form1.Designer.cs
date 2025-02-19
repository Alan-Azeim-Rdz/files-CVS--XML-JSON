namespace files_CVS__XML_JSON
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCSVCreate = new Button();
            BtnXMLCreate = new Button();
            BtnJSONCreate = new Button();
            LblSelectFile = new Label();
            LstbxShowData = new ListBox();
            BtnOpenCSV = new Button();
            BtnSaveCSV = new Button();
            BtnOpenXML = new Button();
            BtnSaveXML = new Button();
            BtnOpenJSON = new Button();
            BtnSaveJSON = new Button();
            SuspendLayout();
            // 
            // BtnCSVCreate
            // 
            BtnCSVCreate.Location = new Point(44, 41);
            BtnCSVCreate.Name = "BtnCSVCreate";
            BtnCSVCreate.Size = new Size(85, 62);
            BtnCSVCreate.TabIndex = 0;
            BtnCSVCreate.Text = "Create CSV";
            BtnCSVCreate.UseVisualStyleBackColor = true;
            BtnCSVCreate.Click += BtnCVSCreate_Click;
            // 
            // BtnXMLCreate
            // 
            BtnXMLCreate.Location = new Point(44, 164);
            BtnXMLCreate.Name = "BtnXMLCreate";
            BtnXMLCreate.Size = new Size(85, 62);
            BtnXMLCreate.TabIndex = 1;
            BtnXMLCreate.Text = "Create XML ";
            BtnXMLCreate.UseVisualStyleBackColor = true;
            BtnXMLCreate.Click += BtnXMLCreate_Click;
            // 
            // BtnJSONCreate
            // 
            BtnJSONCreate.Location = new Point(44, 294);
            BtnJSONCreate.Name = "BtnJSONCreate";
            BtnJSONCreate.Size = new Size(85, 62);
            BtnJSONCreate.TabIndex = 2;
            BtnJSONCreate.Text = "Create JSON ";
            BtnJSONCreate.UseVisualStyleBackColor = true;
            BtnJSONCreate.Click += BtnJSONCreate_Click;
            // 
            // LblSelectFile
            // 
            LblSelectFile.AutoSize = true;
            LblSelectFile.Location = new Point(364, 19);
            LblSelectFile.Name = "LblSelectFile";
            LblSelectFile.Size = new Size(0, 15);
            LblSelectFile.TabIndex = 3;
            // 
            // LstbxShowData
            // 
            LstbxShowData.FormattingEnabled = true;
            LstbxShowData.ItemHeight = 15;
            LstbxShowData.Location = new Point(387, 41);
            LstbxShowData.Name = "LstbxShowData";
            LstbxShowData.Size = new Size(428, 454);
            LstbxShowData.TabIndex = 4;
            // 
            // BtnOpenCSV
            // 
            BtnOpenCSV.Location = new Point(147, 41);
            BtnOpenCSV.Name = "BtnOpenCSV";
            BtnOpenCSV.Size = new Size(90, 62);
            BtnOpenCSV.TabIndex = 5;
            BtnOpenCSV.Text = "Open CSV";
            BtnOpenCSV.UseVisualStyleBackColor = true;
            BtnOpenCSV.Click += BtnOpenCSV_Click;
            // 
            // BtnSaveCSV
            // 
            BtnSaveCSV.Location = new Point(258, 41);
            BtnSaveCSV.Name = "BtnSaveCSV";
            BtnSaveCSV.Size = new Size(90, 62);
            BtnSaveCSV.TabIndex = 6;
            BtnSaveCSV.Text = "Save CSV";
            BtnSaveCSV.UseVisualStyleBackColor = true;
            BtnSaveCSV.Click += BtnSaveCSV_Click;
            // 
            // BtnOpenXML
            // 
            BtnOpenXML.Location = new Point(152, 164);
            BtnOpenXML.Name = "BtnOpenXML";
            BtnOpenXML.Size = new Size(85, 62);
            BtnOpenXML.TabIndex = 7;
            BtnOpenXML.Text = "Open XML";
            BtnOpenXML.UseVisualStyleBackColor = true;
            BtnOpenXML.Click += BtnOpenXML_Click;
            // 
            // BtnSaveXML
            // 
            BtnSaveXML.Location = new Point(263, 164);
            BtnSaveXML.Name = "BtnSaveXML";
            BtnSaveXML.Size = new Size(85, 62);
            BtnSaveXML.TabIndex = 8;
            BtnSaveXML.Text = "Create XML ";
            BtnSaveXML.UseVisualStyleBackColor = true;
            BtnSaveXML.Click += BtnSaveXML_Click;
            // 
            // BtnOpenJSON
            // 
            BtnOpenJSON.Location = new Point(152, 294);
            BtnOpenJSON.Name = "BtnOpenJSON";
            BtnOpenJSON.Size = new Size(85, 62);
            BtnOpenJSON.TabIndex = 9;
            BtnOpenJSON.Text = "Open JSON";
            BtnOpenJSON.UseVisualStyleBackColor = true;
            BtnOpenJSON.Click += BtnOpenJSON_Click;
            // 
            // BtnSaveJSON
            // 
            BtnSaveJSON.Location = new Point(263, 294);
            BtnSaveJSON.Name = "BtnSaveJSON";
            BtnSaveJSON.Size = new Size(85, 62);
            BtnSaveJSON.TabIndex = 10;
            BtnSaveJSON.Text = "Save JSON";
            BtnSaveJSON.UseVisualStyleBackColor = true;
            BtnSaveJSON.Click += BtnSaveJSON_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 520);
            Controls.Add(BtnSaveJSON);
            Controls.Add(BtnOpenJSON);
            Controls.Add(BtnSaveXML);
            Controls.Add(BtnOpenXML);
            Controls.Add(BtnSaveCSV);
            Controls.Add(BtnOpenCSV);
            Controls.Add(LstbxShowData);
            Controls.Add(LblSelectFile);
            Controls.Add(BtnJSONCreate);
            Controls.Add(BtnXMLCreate);
            Controls.Add(BtnCSVCreate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCSVCreate;
        private Button BtnXMLCreate;
        private Button BtnJSONCreate;
        private Label LblSelectFile;
        private ListBox LstbxShowData;
        private Button BtnOpenCSV;
        private Button BtnSaveCSV;
        private Button BtnOpenXML;
        private Button BtnSaveXML;
        private Button BtnOpenJSON;
        private Button BtnSaveJSON;
    }
}
