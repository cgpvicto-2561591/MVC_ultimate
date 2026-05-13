namespace MVC_ultimate
{
    partial class FormPecheur
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
            labelTitre = new Label();
            textBoxNomLac = new TextBox();
            comboBoxZone = new ComboBox();
            listBoxLacZone = new ListBox();
            buttonAjouter = new Button();
            labelChoixZone = new Label();
            labelChoixLac = new Label();
            buttonClearList = new Button();
            SuspendLayout();
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            labelTitre.Location = new Point(104, 24);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(112, 41);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Les lac";
            // 
            // textBoxNomLac
            // 
            textBoxNomLac.Location = new Point(493, 64);
            textBoxNomLac.Name = "textBoxNomLac";
            textBoxNomLac.Size = new Size(272, 27);
            textBoxNomLac.TabIndex = 1;
            textBoxNomLac.TextChanged += textBoxNomLac_TextChanged;
            // 
            // comboBoxZone
            // 
            comboBoxZone.FormattingEnabled = true;
            comboBoxZone.Location = new Point(493, 135);
            comboBoxZone.Name = "comboBoxZone";
            comboBoxZone.Size = new Size(272, 28);
            comboBoxZone.TabIndex = 2;
            comboBoxZone.SelectedIndexChanged += comboBoxZone_SelectedIndexChanged;
            // 
            // listBoxLacZone
            // 
            listBoxLacZone.FormattingEnabled = true;
            listBoxLacZone.Location = new Point(104, 112);
            listBoxLacZone.Name = "listBoxLacZone";
            listBoxLacZone.Size = new Size(357, 284);
            listBoxLacZone.TabIndex = 3;
            listBoxLacZone.SelectedIndexChanged += listBoxLacZone_SelectedIndexChanged;
            // 
            // buttonAjouter
            // 
            buttonAjouter.BackColor = SystemColors.ActiveCaption;
            buttonAjouter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAjouter.Location = new Point(493, 182);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(94, 53);
            buttonAjouter.TabIndex = 4;
            buttonAjouter.Text = "ajouter";
            buttonAjouter.UseVisualStyleBackColor = false;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // labelChoixZone
            // 
            labelChoixZone.AutoSize = true;
            labelChoixZone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelChoixZone.Location = new Point(493, 112);
            labelChoixZone.Name = "labelChoixZone";
            labelChoixZone.Size = new Size(149, 20);
            labelChoixZone.TabIndex = 5;
            labelChoixZone.Text = "Choissisez une Zone";
            // 
            // labelChoixLac
            // 
            labelChoixLac.AutoSize = true;
            labelChoixLac.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelChoixLac.Location = new Point(493, 41);
            labelChoixLac.Name = "labelChoixLac";
            labelChoixLac.Size = new Size(158, 20);
            labelChoixLac.TabIndex = 6;
            labelChoixLac.Text = "Entrer un nom de Lac";
            // 
            // buttonClearList
            // 
            buttonClearList.BackColor = Color.IndianRed;
            buttonClearList.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonClearList.Location = new Point(671, 182);
            buttonClearList.Name = "buttonClearList";
            buttonClearList.Size = new Size(94, 53);
            buttonClearList.TabIndex = 7;
            buttonClearList.Text = "Clear";
            buttonClearList.UseVisualStyleBackColor = false;
            buttonClearList.Click += buttonClearList_Click;
            // 
            // FormPecheur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClearList);
            Controls.Add(labelChoixLac);
            Controls.Add(labelChoixZone);
            Controls.Add(buttonAjouter);
            Controls.Add(listBoxLacZone);
            Controls.Add(comboBoxZone);
            Controls.Add(textBoxNomLac);
            Controls.Add(labelTitre);
            Name = "FormPecheur";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitre;
        private TextBox textBoxNomLac;
        private ComboBox comboBoxZone;
        private ListBox listBoxLacZone;
        private Button buttonAjouter;
        private Label labelChoixZone;
        private Label labelChoixLac;
        private Button buttonClearList;
    }
}
