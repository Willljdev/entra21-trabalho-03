namespace entra21_trabalho_03.Views.Paises
{
    partial class EsporteCadastroForm
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelContinente = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLocalPraticado = new System.Windows.Forms.Label();
            this.comboBoxClube = new System.Windows.Forms.ComboBox();
            this.labelClube = new System.Windows.Forms.Label();
            this.textBoxLocalPraticado = new System.Windows.Forms.TextBox();
            this.numericUpDownJogadores = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownClube = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJogadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClube)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(12, 30);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(193, 26);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(133, 18);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome do esporte";
            // 
            // labelContinente
            // 
            this.labelContinente.AutoSize = true;
            this.labelContinente.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContinente.Location = new System.Drawing.Point(12, 56);
            this.labelContinente.Name = "labelContinente";
            this.labelContinente.Size = new System.Drawing.Size(236, 17);
            this.labelContinente.TabIndex = 2;
            this.labelContinente.Text = "Quantidades de jogadores por time";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(173, 247);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 30);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(11, 247);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(87, 30);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantidade de atletas no clube";
            // 
            // labelLocalPraticado
            // 
            this.labelLocalPraticado.AutoSize = true;
            this.labelLocalPraticado.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLocalPraticado.Location = new System.Drawing.Point(12, 148);
            this.labelLocalPraticado.Name = "labelLocalPraticado";
            this.labelLocalPraticado.Size = new System.Drawing.Size(110, 17);
            this.labelLocalPraticado.TabIndex = 12;
            this.labelLocalPraticado.Text = "Local praticado";
            // 
            // comboBoxClube
            // 
            this.comboBoxClube.DisplayMember = "nome";
            this.comboBoxClube.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxClube.FormattingEnabled = true;
            this.comboBoxClube.Location = new System.Drawing.Point(11, 215);
            this.comboBoxClube.Name = "comboBoxClube";
            this.comboBoxClube.Size = new System.Drawing.Size(121, 26);
            this.comboBoxClube.TabIndex = 17;
            // 
            // labelClube
            // 
            this.labelClube.AutoSize = true;
            this.labelClube.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelClube.Location = new System.Drawing.Point(12, 194);
            this.labelClube.Name = "labelClube";
            this.labelClube.Size = new System.Drawing.Size(53, 18);
            this.labelClube.TabIndex = 18;
            this.labelClube.Text = "Clube ";
            // 
            // textBoxLocalPraticado
            // 
            this.textBoxLocalPraticado.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxLocalPraticado.Location = new System.Drawing.Point(12, 168);
            this.textBoxLocalPraticado.Name = "textBoxLocalPraticado";
            this.textBoxLocalPraticado.Size = new System.Drawing.Size(139, 26);
            this.textBoxLocalPraticado.TabIndex = 19;
            // 
            // numericUpDownJogadores
            // 
            this.numericUpDownJogadores.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownJogadores.Location = new System.Drawing.Point(12, 76);
            this.numericUpDownJogadores.Name = "numericUpDownJogadores";
            this.numericUpDownJogadores.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownJogadores.TabIndex = 20;
            // 
            // numericUpDownClube
            // 
            this.numericUpDownClube.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownClube.Location = new System.Drawing.Point(13, 122);
            this.numericUpDownClube.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownClube.Name = "numericUpDownClube";
            this.numericUpDownClube.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownClube.TabIndex = 21;
            // 
            // EsporteCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(255, 288);
            this.Controls.Add(this.numericUpDownClube);
            this.Controls.Add(this.numericUpDownJogadores);
            this.Controls.Add(this.textBoxLocalPraticado);
            this.Controls.Add(this.labelClube);
            this.Controls.Add(this.comboBoxClube);
            this.Controls.Add(this.labelLocalPraticado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelContinente);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "EsporteCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de paises";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJogadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelContinente;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private Label label1;
        private Label labelLocalPraticado;
        private ComboBox comboBoxClube;
        private Label labelClube;
        private TextBox textBoxLocalPraticado;
        private NumericUpDown numericUpDownJogadores;
        private NumericUpDown numericUpDownClube;
    }
}