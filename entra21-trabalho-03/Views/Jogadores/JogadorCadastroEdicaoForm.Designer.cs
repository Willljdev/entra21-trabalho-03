namespace entra21_trabalho_03.Views.Jogadores
{
    partial class JogadorCadastroEdicaoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelPosicao = new System.Windows.Forms.Label();
            this.labelClube = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxPosicao = new System.Windows.Forms.ComboBox();
            this.comboBoxClube = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // labelPosicao
            // 
            this.labelPosicao.AutoSize = true;
            this.labelPosicao.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPosicao.Location = new System.Drawing.Point(12, 53);
            this.labelPosicao.Name = "labelPosicao";
            this.labelPosicao.Size = new System.Drawing.Size(65, 18);
            this.labelPosicao.TabIndex = 2;
            this.labelPosicao.Text = "Posição";
            // 
            // labelClube
            // 
            this.labelClube.AutoSize = true;
            this.labelClube.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelClube.Location = new System.Drawing.Point(12, 97);
            this.labelClube.Name = "labelClube";
            this.labelClube.Size = new System.Drawing.Size(49, 18);
            this.labelClube.TabIndex = 4;
            this.labelClube.Text = "Clube";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCpf.Location = new System.Drawing.Point(12, 141);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(36, 18);
            this.labelCpf.TabIndex = 6;
            this.labelCpf.Text = "CPF";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataNascimento.Location = new System.Drawing.Point(12, 185);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(153, 18);
            this.labelDataNascimento.TabIndex = 8;
            this.labelDataNascimento.Text = "Data de nascimento";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.Azure;
            this.textBoxNome.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(230, 22);
            this.textBoxNome.TabIndex = 9;
            // 
            // comboBoxPosicao
            // 
            this.comboBoxPosicao.BackColor = System.Drawing.Color.Azure;
            this.comboBoxPosicao.DisplayMember = "nome";
            this.comboBoxPosicao.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPosicao.FormattingEnabled = true;
            this.comboBoxPosicao.Location = new System.Drawing.Point(12, 71);
            this.comboBoxPosicao.Name = "comboBoxPosicao";
            this.comboBoxPosicao.Size = new System.Drawing.Size(230, 24);
            this.comboBoxPosicao.TabIndex = 10;
            // 
            // comboBoxClube
            // 
            this.comboBoxClube.BackColor = System.Drawing.Color.Azure;
            this.comboBoxClube.DisplayMember = "nome";
            this.comboBoxClube.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxClube.FormattingEnabled = true;
            this.comboBoxClube.Items.AddRange(new object[] {
            "Flamengo"});
            this.comboBoxClube.Location = new System.Drawing.Point(12, 115);
            this.comboBoxClube.Name = "comboBoxClube";
            this.comboBoxClube.Size = new System.Drawing.Size(230, 24);
            this.comboBoxClube.TabIndex = 11;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.CalendarForeColor = System.Drawing.Color.SkyBlue;
            this.dateTimePickerDataNascimento.CalendarMonthBackground = System.Drawing.Color.SkyBlue;
            this.dateTimePickerDataNascimento.CalendarTitleBackColor = System.Drawing.Color.SkyBlue;
            this.dateTimePickerDataNascimento.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePickerDataNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(12, 203);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(230, 26);
            this.dateTimePickerDataNascimento.TabIndex = 13;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Azure;
            this.buttonCancelar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(12, 235);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(88, 31);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.Azure;
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(154, 235);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(88, 31);
            this.buttonSalvar.TabIndex = 15;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(12, 162);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(230, 22);
            this.maskedTextBoxCpf.TabIndex = 16;
            // 
            // JogadorCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(254, 271);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.comboBoxClube);
            this.Controls.Add(this.comboBoxPosicao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelClube);
            this.Controls.Add(this.labelPosicao);
            this.Controls.Add(this.label1);
            this.Name = "JogadorCadastroEdicaoForm";
            this.Text = "Cadastro de jogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelPosicao;
        private Label labelClube;
        private Label labelCpf;
        private Label labelDataNascimento;
        private TextBox textBoxNome;
        private ComboBox comboBoxPosicao;
        private ComboBox comboBoxClube;
        private DateTimePicker dateTimePickerDataNascimento;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private MaskedTextBox maskedTextBoxCpf;
    }
}