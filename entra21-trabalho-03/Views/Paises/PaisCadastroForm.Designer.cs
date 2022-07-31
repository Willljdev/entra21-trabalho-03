namespace entra21_trabalho_03.Views.Paises
{
    partial class PaisCadastroForm
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
            this.labelPais = new System.Windows.Forms.Label();
            this.labelContinente = new System.Windows.Forms.Label();
            this.textBoxContinente = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(121, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(12, 9);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(28, 15);
            this.labelPais.TabIndex = 1;
            this.labelPais.Text = "País";
            // 
            // labelContinente
            // 
            this.labelContinente.AutoSize = true;
            this.labelContinente.Location = new System.Drawing.Point(12, 66);
            this.labelContinente.Name = "labelContinente";
            this.labelContinente.Size = new System.Drawing.Size(66, 15);
            this.labelContinente.TabIndex = 2;
            this.labelContinente.Text = "Continente";
            // 
            // textBoxContinente
            // 
            this.textBoxContinente.Location = new System.Drawing.Point(12, 84);
            this.textBoxContinente.Name = "textBoxContinente";
            this.textBoxContinente.Size = new System.Drawing.Size(121, 23);
            this.textBoxContinente.TabIndex = 4;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(169, 135);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(3, 135);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(84, 135);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 8;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // PaisCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 174);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxContinente);
            this.Controls.Add(this.labelContinente);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.textBoxNome);
            this.Name = "PaisCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de paises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private Label labelPais;
        private Label labelContinente;
        private TextBox textBoxContinente;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private Button buttonMenu;
    }
}