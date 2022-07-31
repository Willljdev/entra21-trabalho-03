namespace entra21_trabalho_03.Views.Competicoes
{
    partial class CompeticaoCadastroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.labelDataTermino = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataTermino = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEsportes = new System.Windows.Forms.ComboBox();
            this.labelEsportes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(174, 207);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 207);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(93, 207);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(122, 15);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome da competição";
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Location = new System.Drawing.Point(11, 116);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(76, 15);
            this.labelDataInicio.TabIndex = 4;
            this.labelDataInicio.Text = "Data te início";
            // 
            // labelDataTermino
            // 
            this.labelDataTermino.AutoSize = true;
            this.labelDataTermino.Location = new System.Drawing.Point(12, 160);
            this.labelDataTermino.Name = "labelDataTermino";
            this.labelDataTermino.Size = new System.Drawing.Size(76, 15);
            this.labelDataTermino.TabIndex = 5;
            this.labelDataTermino.Text = "Data término";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(200, 23);
            this.textBoxNome.TabIndex = 6;
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(12, 134);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDataInicio.TabIndex = 7;
            // 
            // dateTimePickerDataTermino
            // 
            this.dateTimePickerDataTermino.Location = new System.Drawing.Point(12, 178);
            this.dateTimePickerDataTermino.Name = "dateTimePickerDataTermino";
            this.dateTimePickerDataTermino.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDataTermino.TabIndex = 8;
            // 
            // comboBoxEsportes
            // 
            this.comboBoxEsportes.FormattingEnabled = true;
            this.comboBoxEsportes.Location = new System.Drawing.Point(13, 81);
            this.comboBoxEsportes.Name = "comboBoxEsportes";
            this.comboBoxEsportes.Size = new System.Drawing.Size(121, 23);
            this.comboBoxEsportes.TabIndex = 9;
            // 
            // labelEsportes
            // 
            this.labelEsportes.AutoSize = true;
            this.labelEsportes.Location = new System.Drawing.Point(13, 63);
            this.labelEsportes.Name = "labelEsportes";
            this.labelEsportes.Size = new System.Drawing.Size(51, 15);
            this.labelEsportes.TabIndex = 10;
            this.labelEsportes.Text = "Esportes";
            // 
            // CompeticaoCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 331);
            this.Controls.Add(this.labelEsportes);
            this.Controls.Add(this.comboBoxEsportes);
            this.Controls.Add(this.dateTimePickerDataTermino);
            this.Controls.Add(this.dateTimePickerDataInicio);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelDataTermino);
            this.Controls.Add(this.labelDataInicio);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "CompeticaoCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de competições";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCadastrar;
        private Button buttonCancelar;
        private Button buttonMenu;
        private Label labelNome;
        private Label labelDataInicio;
        private Label labelDataTermino;
        private TextBox textBoxNome;
        private DateTimePicker dateTimePickerDataInicio;
        private DateTimePicker dateTimePickerDataTermino;
        private ComboBox comboBoxEsportes;
        private Label labelEsportes;
    }
}