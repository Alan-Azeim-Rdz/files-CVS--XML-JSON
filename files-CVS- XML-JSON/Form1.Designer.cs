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
            BtnCreate = new Button();
            LblSelectFile = new Label();
            LstbxShowData = new ListBox();
            BtnOpen = new Button();
            BtnSave = new Button();
            ComboxSeleciont = new ComboBox();
            SuspendLayout();
            // 
            // BtnCreate
            // 
            BtnCreate.Location = new Point(70, 132);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(85, 62);
            BtnCreate.TabIndex = 0;
            BtnCreate.Text = "Create";
            BtnCreate.UseVisualStyleBackColor = true;
            BtnCreate.Click += BtnCreate_Click;
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
            LstbxShowData.Location = new Point(237, 12);
            LstbxShowData.Name = "LstbxShowData";
            LstbxShowData.Size = new Size(428, 454);
            LstbxShowData.TabIndex = 4;
            // 
            // BtnOpen
            // 
            BtnOpen.Location = new Point(65, 232);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(90, 62);
            BtnOpen.TabIndex = 5;
            BtnOpen.Text = "Open";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(65, 322);
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
            ComboxSeleciont.Items.AddRange(new object[] { "CVS", "XML", "JASON" });
            ComboxSeleciont.Location = new Point(55, 41);
            ComboxSeleciont.Name = "ComboxSeleciont";
            ComboxSeleciont.Size = new Size(121, 23);
            ComboxSeleciont.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 517);
            Controls.Add(ComboxSeleciont);
            Controls.Add(BtnSave);
            Controls.Add(BtnOpen);
            Controls.Add(LstbxShowData);
            Controls.Add(LblSelectFile);
            Controls.Add(BtnCreate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCreate;
        private Label LblSelectFile;
        private ListBox LstbxShowData;
        private Button BtnOpen;
        private Button BtnSave;
        private ComboBox ComboxSeleciont;
    }
}
