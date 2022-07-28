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
            this.labelClubeAtual = new System.Windows.Forms.Label();
            this.comboBoxClubeAtual = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeTecnico
            // 
            this.labelNomeTecnico.AutoSize = true;
            this.labelNomeTecnico.Location = new System.Drawing.Point(12, 9);
            this.labelNomeTecnico.Name = "labelNomeTecnico";
            this.labelNomeTecnico.Size = new System.Drawing.Size(124, 20);
            this.labelNomeTecnico.TabIndex = 0;
            this.labelNomeTecnico.Text = "Nome do técnico";
            // 
            // textBoxNomeTecnico
            // 
            this.textBoxNomeTecnico.Location = new System.Drawing.Point(12, 32);
            this.textBoxNomeTecnico.Name = "textBoxNomeTecnico";
            this.textBoxNomeTecnico.Size = new System.Drawing.Size(275, 27);
            this.textBoxNomeTecnico.TabIndex = 1;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(12, 62);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(107, 20);
            this.labelCpf.TabIndex = 2;
            this.labelCpf.Text = "CPF do técnico";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(12, 85);
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(184, 27);
            this.maskedTextBoxCpf.TabIndex = 3;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(12, 115);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(216, 20);
            this.labelDataNascimento.TabIndex = 4;
            this.labelDataNascimento.Text = "Data de nascimento do técnico";
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(12, 138);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerDataNascimento.TabIndex = 5;
            // 
            // labelCidadeNatal
            // 
            this.labelCidadeNatal.AutoSize = true;
            this.labelCidadeNatal.Location = new System.Drawing.Point(12, 168);
            this.labelCidadeNatal.Name = "labelCidadeNatal";
            this.labelCidadeNatal.Size = new System.Drawing.Size(93, 20);
            this.labelCidadeNatal.TabIndex = 6;
            this.labelCidadeNatal.Text = "Cidade natal";
            // 
            // textBoxCidadeNatal
            // 
            this.textBoxCidadeNatal.Location = new System.Drawing.Point(12, 191);
            this.textBoxCidadeNatal.Name = "textBoxCidadeNatal";
            this.textBoxCidadeNatal.Size = new System.Drawing.Size(184, 27);
            this.textBoxCidadeNatal.TabIndex = 7;
            // 
            // labelClubeAtual
            // 
            this.labelClubeAtual.AutoSize = true;
            this.labelClubeAtual.Location = new System.Drawing.Point(12, 221);
            this.labelClubeAtual.Name = "labelClubeAtual";
            this.labelClubeAtual.Size = new System.Drawing.Size(86, 20);
            this.labelClubeAtual.TabIndex = 8;
            this.labelClubeAtual.Text = "Clube Atual";
            // 
            // comboBoxClubeAtual
            // 
            this.comboBoxClubeAtual.FormattingEnabled = true;
            this.comboBoxClubeAtual.Location = new System.Drawing.Point(12, 244);
            this.comboBoxClubeAtual.Name = "comboBoxClubeAtual";
            this.comboBoxClubeAtual.Size = new System.Drawing.Size(184, 28);
            this.comboBoxClubeAtual.TabIndex = 9;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 297);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(112, 297);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(94, 29);
            this.buttonMenu.TabIndex = 11;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(212, 297);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // TecnicoCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 340);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxClubeAtual);
            this.Controls.Add(this.labelClubeAtual);
            this.Controls.Add(this.textBoxCidadeNatal);
            this.Controls.Add(this.labelCidadeNatal);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.textBoxNomeTecnico);
            this.Controls.Add(this.labelNomeTecnico);
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
        private Label labelClubeAtual;
        private ComboBox comboBoxClubeAtual;
        private Button buttonCancelar;
        private Button buttonMenu;
        private Button buttonSalvar;
    }
}