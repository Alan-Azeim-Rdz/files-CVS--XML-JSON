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
            LblSelectFile = new Label();
            BtnOpen = new Button();
            BtnSave = new Button();
            ComboxSeleciont = new ComboBox();
            TextBoxData = new TextBox();
            LstbxShowData = new ListBox();
            SuspendLayout();
            // 
            // LblSelectFile
            // 
            LblSelectFile.AutoSize = true;
            LblSelectFile.Location = new Point(364, 19);
            LblSelectFile.Name = "LblSelectFile";
            LblSelectFile.Size = new Size(0, 15);
            LblSelectFile.TabIndex = 3;
            // 
            // BtnOpen
            // 
            BtnOpen.Location = new Point(65, 141);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(90, 62);
            BtnOpen.TabIndex = 5;
            BtnOpen.Text = "Open";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(65, 257);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(90, 62);
            BtnSave.TabIndex = 6;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // ComboxSeleciont
            // 
            ComboxSeleciont.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboxSeleciont.FormattingEnabled = true;
            ComboxSeleciont.Items.AddRange(new object[] { "csv", "xml", "jason" });
            ComboxSeleciont.Location = new Point(55, 41);
            ComboxSeleciont.Name = "ComboxSeleciont";
            ComboxSeleciont.Size = new Size(121, 23);
            ComboxSeleciont.TabIndex = 7;
            // 
            // TextBoxData
            // 
            TextBoxData.Location = new Point(738, 19);
            TextBoxData.Multiline = true;
            TextBoxData.Name = "TextBoxData";
            TextBoxData.Size = new Size(423, 464);
            TextBoxData.TabIndex = 8;
            // 
            // LstbxShowData
            // 
            LstbxShowData.FormattingEnabled = true;
            LstbxShowData.ItemHeight = 15;
            LstbxShowData.Location = new Point(244, 19);
            LstbxShowData.Name = "LstbxShowData";
            LstbxShowData.Size = new Size(456, 469);
            LstbxShowData.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 517);
            Controls.Add(LstbxShowData);
            Controls.Add(TextBoxData);
            Controls.Add(ComboxSeleciont);
            Controls.Add(BtnSave);
            Controls.Add(BtnOpen);
            Controls.Add(LblSelectFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblSelectFile;
        private Button BtnOpen;
        private Button BtnSave;
        private ComboBox ComboxSeleciont;
        private TextBox TextBoxData;
        private ListBox LstbxShowData;
    }
}
