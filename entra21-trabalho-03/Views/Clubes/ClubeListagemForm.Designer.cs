namespace entra21_trabalho_03.Views.Clubes
{
    partial class ClubeListagemForm
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
            this.dataGridViewListaClubes = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataFundacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidadeSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClubes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaClubes
            // 
            this.dataGridViewListaClubes.AllowUserToAddRows = false;
            this.dataGridViewListaClubes.AllowUserToDeleteRows = false;
            this.dataGridViewListaClubes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaClubes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnDataFundacao,
            this.ColumnCidadeSede});
            this.dataGridViewListaClubes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewListaClubes.Name = "dataGridViewListaClubes";
            this.dataGridViewListaClubes.ReadOnly = true;
            this.dataGridViewListaClubes.RowHeadersWidth = 51;
            this.dataGridViewListaClubes.RowTemplate.Height = 29;
            this.dataGridViewListaClubes.Size = new System.Drawing.Size(558, 312);
            this.dataGridViewListaClubes.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 125;
            // 
            // ColumnDataFundacao
            // 
            this.ColumnDataFundacao.HeaderText = "Data de fundação";
            this.ColumnDataFundacao.MinimumWidth = 6;
            this.ColumnDataFundacao.Name = "ColumnDataFundacao";
            this.ColumnDataFundacao.ReadOnly = true;
            this.ColumnDataFundacao.Width = 125;
            // 
            // ColumnCidadeSede
            // 
            this.ColumnCidadeSede.HeaderText = "Cidade Sede";
            this.ColumnCidadeSede.MinimumWidth = 6;
            this.ColumnCidadeSede.Name = "ColumnCidadeSede";
            this.ColumnCidadeSede.ReadOnly = true;
            this.ColumnCidadeSede.Width = 125;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(380, 330);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 29);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(480, 330);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(94, 29);
            this.buttonCadastrar.TabIndex = 2;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(280, 330);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(94, 29);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            // 
            // ClubeListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 365);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewListaClubes);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClubeListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClubeListagemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClubes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewListaClubes;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnDataFundacao;
        private DataGridViewTextBoxColumn ColumnCidadeSede;
        private Button buttonEditar;
        private Button buttonCadastrar;
        private Button buttonMenu;
    }
}