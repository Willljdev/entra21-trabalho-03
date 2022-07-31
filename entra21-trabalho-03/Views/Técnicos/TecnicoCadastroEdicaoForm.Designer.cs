namespace entra21_trabalho_03.Views.Técnicos
{
    partial class TecnicoCadastroEdicaoForm
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
            this.labelNomeTecnico = new System.Windows.Forms.Label();
            this.textBoxNomeTecnico = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelCidadeNatal = new System.Windows.Forms.Label();
            this.textBoxCidadeNatal = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeTecnico
            // 
            this.labelNomeTecnico.AutoSize = true;
            this.labelNomeTecnico.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNomeTecnico.Location = new System.Drawing.Point(10, 4);
            this.labelNomeTecnico.Name = "labelNomeTecnico";
            this.labelNomeTecnico.Size = new System.Drawing.Size(131, 18);
            this.labelNomeTecnico.TabIndex = 0;
            this.labelNomeTecnico.Text = "Nome do técnico";
            // 
            // textBoxNomeTecnico
            // 
            this.textBoxNomeTecnico.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNomeTecnico.Location = new System.Drawing.Point(10, 24);
            this.textBoxNomeTecnico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNomeTecnico.Name = "textBoxNomeTecnico";
            this.textBoxNomeTecnico.Size = new System.Drawing.Size(241, 26);
            this.textBoxNomeTecnico.TabIndex = 1;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCpf.Location = new System.Drawing.Point(10, 52);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(117, 18);
            this.labelCpf.TabIndex = 2;
            this.labelCpf.Text = "CPF do técnico";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(10, 72);
            this.maskedTextBoxCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(162, 26);
            this.maskedTextBoxCpf.TabIndex = 3;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataNascimento.Location = new System.Drawing.Point(10, 100);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(153, 18);
            this.labelDataNascimento.TabIndex = 4;
            this.labelDataNascimento.Text = "Data de nascimento\r\n";
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.CalendarFont = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(10, 120);
            this.dateTimePickerDataNascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerDataNascimento.TabIndex = 5;
            // 
            // labelCidadeNatal
            // 
            this.labelCidadeNatal.AutoSize = true;
            this.labelCidadeNatal.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCidadeNatal.Location = new System.Drawing.Point(9, 145);
            this.labelCidadeNatal.Name = "labelCidadeNatal";
            this.labelCidadeNatal.Size = new System.Drawing.Size(99, 18);
            this.labelCidadeNatal.TabIndex = 6;
            this.labelCidadeNatal.Text = "Cidade natal";
            // 
            // textBoxCidadeNatal
            // 
            this.textBoxCidadeNatal.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCidadeNatal.Location = new System.Drawing.Point(9, 165);
            this.textBoxCidadeNatal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCidadeNatal.Name = "textBoxCidadeNatal";
            this.textBoxCidadeNatal.Size = new System.Drawing.Size(162, 26);
            this.textBoxCidadeNatal.TabIndex = 7;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(9, 195);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 32);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(97, 195);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(82, 32);
            this.buttonMenu.TabIndex = 11;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(185, 195);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(82, 32);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // TecnicoCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 232);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxCidadeNatal);
            this.Controls.Add(this.labelCidadeNatal);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.textBoxNomeTecnico);
            this.Controls.Add(this.labelNomeTecnico);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TecnicoCadastroEdicaoForm";
            this.Text = "TecnicoCadastroEdicaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNomeTecnico;
        private TextBox textBoxNomeTecnico;
        private Label labelCpf;
        private MaskedTextBox maskedTextBoxCpf;
        private Label labelDataNascimento;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label labelCidadeNatal;
        private TextBox textBoxCidadeNatal;
        private Button buttonCancelar;
        private Button buttonMenu;
        private Button buttonSalvar;
    }
}