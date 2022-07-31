namespace entra21_trabalho_03.Views.Clubes
{
    partial class ClubeCadastroEdicaoForm
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
            this.labelNomeClube = new System.Windows.Forms.Label();
            this.labelCidadeSede = new System.Windows.Forms.Label();
            this.labelAnoFundacao = new System.Windows.Forms.Label();
            this.textBoxNomeClube = new System.Windows.Forms.TextBox();
            this.textBoxCidadeSede = new System.Windows.Forms.TextBox();
            this.dateTimePickerAnoFundacao = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.comboBoxTecnicoClube = new System.Windows.Forms.ComboBox();
            this.labelTecnico = new System.Windows.Forms.Label();
            this.dateTimePickerHoraFundacao = new System.Windows.Forms.DateTimePicker();
            this.labelHoraFundacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNomeClube
            // 
            this.labelNomeClube.AutoSize = true;
            this.labelNomeClube.Location = new System.Drawing.Point(12, 7);
            this.labelNomeClube.Name = "labelNomeClube";
            this.labelNomeClube.Size = new System.Drawing.Size(91, 15);
            this.labelNomeClube.TabIndex = 0;
            this.labelNomeClube.Text = "Nome do Clube";
            // 
            // labelCidadeSede
            // 
            this.labelCidadeSede.AutoSize = true;
            this.labelCidadeSede.Location = new System.Drawing.Point(12, 49);
            this.labelCidadeSede.Name = "labelCidadeSede";
            this.labelCidadeSede.Size = new System.Drawing.Size(122, 15);
            this.labelCidadeSede.TabIndex = 1;
            this.labelCidadeSede.Text = "Cidade sede do Clube";
            // 
            // labelAnoFundacao
            // 
            this.labelAnoFundacao.AutoSize = true;
            this.labelAnoFundacao.Location = new System.Drawing.Point(12, 87);
            this.labelAnoFundacao.Name = "labelAnoFundacao";
            this.labelAnoFundacao.Size = new System.Drawing.Size(147, 15);
            this.labelAnoFundacao.TabIndex = 3;
            this.labelAnoFundacao.Text = "Ano de fundação do clube";
            // 
            // textBoxNomeClube
            // 
            this.textBoxNomeClube.Location = new System.Drawing.Point(12, 24);
            this.textBoxNomeClube.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNomeClube.Name = "textBoxNomeClube";
            this.textBoxNomeClube.Size = new System.Drawing.Size(196, 23);
            this.textBoxNomeClube.TabIndex = 5;
            // 
            // textBoxCidadeSede
            // 
            this.textBoxCidadeSede.Location = new System.Drawing.Point(12, 64);
            this.textBoxCidadeSede.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCidadeSede.Name = "textBoxCidadeSede";
            this.textBoxCidadeSede.Size = new System.Drawing.Size(196, 23);
            this.textBoxCidadeSede.TabIndex = 6;
            // 
            // dateTimePickerAnoFundacao
            // 
            this.dateTimePickerAnoFundacao.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerAnoFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAnoFundacao.Location = new System.Drawing.Point(12, 104);
            this.dateTimePickerAnoFundacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerAnoFundacao.Name = "dateTimePickerAnoFundacao";
            this.dateTimePickerAnoFundacao.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerAnoFundacao.TabIndex = 7;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 221);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 30);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(188, 221);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(82, 30);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(100, 221);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(82, 30);
            this.buttonMenu.TabIndex = 10;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // comboBoxTecnicoClube
            // 
            this.comboBoxTecnicoClube.BackColor = System.Drawing.Color.Azure;
            this.comboBoxTecnicoClube.DisplayMember = "nome";
            this.comboBoxTecnicoClube.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTecnicoClube.FormattingEnabled = true;
            this.comboBoxTecnicoClube.Location = new System.Drawing.Point(12, 192);
            this.comboBoxTecnicoClube.Name = "comboBoxTecnicoClube";
            this.comboBoxTecnicoClube.Size = new System.Drawing.Size(196, 24);
            this.comboBoxTecnicoClube.TabIndex = 12;
            // 
            // labelTecnico
            // 
            this.labelTecnico.AutoSize = true;
            this.labelTecnico.Location = new System.Drawing.Point(12, 174);
            this.labelTecnico.Name = "labelTecnico";
            this.labelTecnico.Size = new System.Drawing.Size(96, 15);
            this.labelTecnico.TabIndex = 13;
            this.labelTecnico.Text = "Técnico do clube";
            // 
            // dateTimePickerHoraFundacao
            // 
            this.dateTimePickerHoraFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraFundacao.Location = new System.Drawing.Point(12, 148);
            this.dateTimePickerHoraFundacao.Name = "dateTimePickerHoraFundacao";
            this.dateTimePickerHoraFundacao.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerHoraFundacao.TabIndex = 14;
            // 
            // labelHoraFundacao
            // 
            this.labelHoraFundacao.AutoSize = true;
            this.labelHoraFundacao.Location = new System.Drawing.Point(12, 130);
            this.labelHoraFundacao.Name = "labelHoraFundacao";
            this.labelHoraFundacao.Size = new System.Drawing.Size(102, 15);
            this.labelHoraFundacao.TabIndex = 15;
            this.labelHoraFundacao.Text = "Hora de fundação";
            // 
            // ClubeCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 258);
            this.Controls.Add(this.labelHoraFundacao);
            this.Controls.Add(this.dateTimePickerHoraFundacao);
            this.Controls.Add(this.labelTecnico);
            this.Controls.Add(this.comboBoxTecnicoClube);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dateTimePickerAnoFundacao);
            this.Controls.Add(this.textBoxCidadeSede);
            this.Controls.Add(this.textBoxNomeClube);
            this.Controls.Add(this.labelAnoFundacao);
            this.Controls.Add(this.labelCidadeSede);
            this.Controls.Add(this.labelNomeClube);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClubeCadastroEdicaoForm";
            this.Text = "Cadastro e Edição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNomeClube;
        private Label labelCidadeSede;
        private Label labelAnoFundacao;
        private TextBox textBoxNomeClube;
        private TextBox textBoxCidadeSede;
        private DateTimePicker dateTimePickerAnoFundacao;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Button buttonMenu;
        private ComboBox comboBoxTecnicoClube;
        private Label labelTecnico;
        private DateTimePicker dateTimePickerHoraFundacao;
        private Label labelHoraFundacao;
    }
}