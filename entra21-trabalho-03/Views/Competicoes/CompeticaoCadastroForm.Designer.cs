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
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateTermino = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraTermino = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEsportes = new System.Windows.Forms.ComboBox();
            this.labelEsportes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrar.Location = new System.Drawing.Point(174, 256);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 34);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(12, 256);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 34);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMenu.Location = new System.Drawing.Point(93, 256);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 34);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(162, 18);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome da competição";
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataInicio.Location = new System.Drawing.Point(12, 62);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(157, 18);
            this.labelDataInicio.TabIndex = 4;
            this.labelDataInicio.Text = "Data e hora de início";
            // 
            // labelDataTermino
            // 
            this.labelDataTermino.AutoSize = true;
            this.labelDataTermino.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataTermino.Location = new System.Drawing.Point(12, 126);
            this.labelDataTermino.Name = "labelDataTermino";
            this.labelDataTermino.Size = new System.Drawing.Size(175, 18);
            this.labelDataTermino.TabIndex = 5;
            this.labelDataTermino.Text = "Data e hora de término";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(200, 26);
            this.textBoxNome.TabIndex = 6;
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.CalendarFont = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(118, 83);
            this.dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            this.dateTimePickerHoraInicio.Size = new System.Drawing.Size(94, 23);
            this.dateTimePickerHoraInicio.TabIndex = 7;
            // 
            // dateTimePickerDateInicio
            // 
            this.dateTimePickerDateInicio.CalendarFont = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateInicio.Location = new System.Drawing.Point(12, 83);
            this.dateTimePickerDateInicio.Name = "dateTimePickerDateInicio";
            this.dateTimePickerDateInicio.Size = new System.Drawing.Size(94, 23);
            this.dateTimePickerDateInicio.TabIndex = 8;
            // 
            // dateTimePickerDateTermino
            // 
            this.dateTimePickerDateTermino.CalendarFont = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDateTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateTermino.Location = new System.Drawing.Point(12, 147);
            this.dateTimePickerDateTermino.Name = "dateTimePickerDateTermino";
            this.dateTimePickerDateTermino.Size = new System.Drawing.Size(94, 23);
            this.dateTimePickerDateTermino.TabIndex = 9;
            // 
            // dateTimePickerHoraTermino
            // 
            this.dateTimePickerHoraTermino.CalendarFont = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerHoraTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraTermino.Location = new System.Drawing.Point(118, 147);
            this.dateTimePickerHoraTermino.Name = "dateTimePickerHoraTermino";
            this.dateTimePickerHoraTermino.Size = new System.Drawing.Size(94, 23);
            this.dateTimePickerHoraTermino.TabIndex = 10;
            // 
            // comboBoxEsportes
            // 
            this.comboBoxEsportes.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxEsportes.FormattingEnabled = true;
            this.comboBoxEsportes.Location = new System.Drawing.Point(12, 210);
            this.comboBoxEsportes.Name = "comboBoxEsportes";
            this.comboBoxEsportes.Size = new System.Drawing.Size(175, 26);
            this.comboBoxEsportes.TabIndex = 11;
            // 
            // labelEsportes
            // 
            this.labelEsportes.AutoSize = true;
            this.labelEsportes.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEsportes.Location = new System.Drawing.Point(12, 189);
            this.labelEsportes.Name = "labelEsportes";
            this.labelEsportes.Size = new System.Drawing.Size(177, 18);
            this.labelEsportes.TabIndex = 12;
            this.labelEsportes.Text = "Esporte da competição";
            // 
            // CompeticaoCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 302);
            this.Controls.Add(this.labelEsportes);
            this.Controls.Add(this.comboBoxEsportes);
            this.Controls.Add(this.dateTimePickerHoraTermino);
            this.Controls.Add(this.dateTimePickerDateTermino);
            this.Controls.Add(this.dateTimePickerDateInicio);
            this.Controls.Add(this.dateTimePickerHoraInicio);
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
        private DateTimePicker dateTimePickerHoraInicio;
        private DateTimePicker dateTimePickerDateInicio;
        private DateTimePicker dateTimePickerDateTermino;
        private DateTimePicker dateTimePickerHoraTermino;
        private ComboBox comboBoxEsportes;
        private Label labelEsportes;
    }
}