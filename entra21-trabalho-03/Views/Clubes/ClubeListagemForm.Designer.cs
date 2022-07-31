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
            this.ColumnTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataFundacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidadeSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelListagemClubes = new System.Windows.Forms.Label();
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
            this.ColumnTecnico,
            this.ColumnNome,
            this.ColumnDataFundacao,
            this.ColumnCidadeSede});
            this.dataGridViewListaClubes.Location = new System.Drawing.Point(10, 46);
            this.dataGridViewListaClubes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListaClubes.Name = "dataGridViewListaClubes";
            this.dataGridViewListaClubes.ReadOnly = true;
            this.dataGridViewListaClubes.RowHeadersWidth = 51;
            this.dataGridViewListaClubes.RowTemplate.Height = 29;
            this.dataGridViewListaClubes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaClubes.Size = new System.Drawing.Size(652, 290);
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
            // ColumnTecnico
            // 
            this.ColumnTecnico.HeaderText = "Técnico";
            this.ColumnTecnico.Name = "ColumnTecnico";
            this.ColumnTecnico.ReadOnly = true;
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
            this.buttonEditar.Location = new System.Drawing.Point(490, 10);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(82, 32);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(581, 11);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(82, 31);
            this.buttonCadastrar.TabIndex = 2;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(314, 11);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(82, 31);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(402, 10);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(82, 32);
            this.buttonApagar.TabIndex = 4;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click_2);
            // 
            // labelListagemClubes
            // 
            this.labelListagemClubes.AutoSize = true;
            this.labelListagemClubes.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelListagemClubes.Location = new System.Drawing.Point(9, 13);
            this.labelListagemClubes.Name = "labelListagemClubes";
            this.labelListagemClubes.Size = new System.Drawing.Size(277, 22);
            this.labelListagemClubes.TabIndex = 5;
            this.labelListagemClubes.Text = "Listagem de clubes cadastrados";
            // 
            // ClubeListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 347);
            this.Controls.Add(this.labelListagemClubes);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewListaClubes);
            this.Name = "ClubeListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClubeListagemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClubes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewListaClubes;
        private Button buttonEditar;
        private Button buttonCadastrar;
        private Button buttonMenu;
        private Button buttonApagar;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnTecnico;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnDataFundacao;
        private DataGridViewTextBoxColumn ColumnCidadeSede;
        private Label labelListagemClubes;
    }
}