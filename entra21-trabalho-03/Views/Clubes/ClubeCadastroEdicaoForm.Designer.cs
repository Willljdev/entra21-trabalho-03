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
            this.SuspendLayout();
            // 
            // labelNomeClube
            // 
            this.labelNomeClube.AutoSize = true;
            this.labelNomeClube.Location = new System.Drawing.Point(12, 9);
            this.labelNomeClube.Name = "labelNomeClube";
            this.labelNomeClube.Size = new System.Drawing.Size(114, 20);
            this.labelNomeClube.TabIndex = 0;
            this.labelNomeClube.Text = "Nome do Clube";
            // 
            // labelCidadeSede
            // 
            this.labelCidadeSede.AutoSize = true;
            this.labelCidadeSede.Location = new System.Drawing.Point(12, 62);
            this.labelCidadeSede.Name = "labelCidadeSede";
            this.labelCidadeSede.Size = new System.Drawing.Size(155, 20);
            this.labelCidadeSede.TabIndex = 1;
            this.labelCidadeSede.Text = "Cidade sede do Clube";
            // 
            // labelAnoFundacao
            // 
            this.labelAnoFundacao.AutoSize = true;
            this.labelAnoFundacao.Location = new System.Drawing.Point(12, 115);
            this.labelAnoFundacao.Name = "labelAnoFundacao";
            this.labelAnoFundacao.Size = new System.Drawing.Size(185, 20);
            this.labelAnoFundacao.TabIndex = 3;
            this.labelAnoFundacao.Text = "Ano de fundação do clube";
            // 
            // textBoxNomeClube
            // 
            this.textBoxNomeClube.Location = new System.Drawing.Point(12, 32);
            this.textBoxNomeClube.Name = "textBoxNomeClube";
            this.textBoxNomeClube.Size = new System.Drawing.Size(224, 27);
            this.textBoxNomeClube.TabIndex = 5;
            // 
            // textBoxCidadeSede
            // 
            this.textBoxCidadeSede.Location = new System.Drawing.Point(12, 85);
            this.textBoxCidadeSede.Name = "textBoxCidadeSede";
            this.textBoxCidadeSede.Size = new System.Drawing.Size(224, 27);
            this.textBoxCidadeSede.TabIndex = 6;
            // 
            // dateTimePickerAnoFundacao
            // 
            this.dateTimePickerAnoFundacao.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerAnoFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAnoFundacao.Location = new System.Drawing.Point(12, 138);
            this.dateTimePickerAnoFundacao.Name = "dateTimePickerAnoFundacao";
            this.dateTimePickerAnoFundacao.Size = new System.Drawing.Size(101, 27);
            this.dateTimePickerAnoFundacao.TabIndex = 7;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 361);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(212, 361);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(112, 361);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(94, 29);
            this.buttonMenu.TabIndex = 10;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            // 
            // ClubeCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 397);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dateTimePickerAnoFundacao);
            this.Controls.Add(this.textBoxCidadeSede);
            this.Controls.Add(this.textBoxNomeClube);
            this.Controls.Add(this.labelAnoFundacao);
            this.Controls.Add(this.labelCidadeSede);
            this.Controls.Add(this.labelNomeClube);
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
    }
}