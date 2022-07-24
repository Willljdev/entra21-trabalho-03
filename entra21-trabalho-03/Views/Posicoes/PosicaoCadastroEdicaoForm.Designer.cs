namespace entra21_trabalho_03.Views.Posicoes
{
    partial class PosicaoCadastroEdicaoForm
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
            this.labelPosicao = new System.Windows.Forms.Label();
            this.textBoxPosicao = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPosicao
            // 
            this.labelPosicao.AutoSize = true;
            this.labelPosicao.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPosicao.Location = new System.Drawing.Point(12, 9);
            this.labelPosicao.Name = "labelPosicao";
            this.labelPosicao.Size = new System.Drawing.Size(65, 18);
            this.labelPosicao.TabIndex = 0;
            this.labelPosicao.Text = "Posição";
            // 
            // textBoxPosicao
            // 
            this.textBoxPosicao.BackColor = System.Drawing.Color.Azure;
            this.textBoxPosicao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPosicao.Location = new System.Drawing.Point(12, 31);
            this.textBoxPosicao.Name = "textBoxPosicao";
            this.textBoxPosicao.Size = new System.Drawing.Size(216, 26);
            this.textBoxPosicao.TabIndex = 1;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.Azure;
            this.buttonSalvar.Location = new System.Drawing.Point(153, 60);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 34);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Azure;
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonCancelar.Location = new System.Drawing.Point(72, 60);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 34);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // PosicaoCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(240, 102);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxPosicao);
            this.Controls.Add(this.labelPosicao);
            this.Name = "PosicaoCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Posições";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPosicao;
        private TextBox textBoxPosicao;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}