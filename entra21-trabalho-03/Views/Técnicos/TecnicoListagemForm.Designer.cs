namespace entra21_trabalho_03.Views.Técnicos
{
    partial class TecnicoListagemForm
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
            this.dataGridViewListaTecnicos = new System.Windows.Forms.DataGridView();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaTecnicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaTecnicos
            // 
            this.dataGridViewListaTecnicos.AllowUserToAddRows = false;
            this.dataGridViewListaTecnicos.AllowUserToDeleteRows = false;
            this.dataGridViewListaTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaTecnicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnClube,
            this.ColumnCpf,
            this.ColumnDataNascimento});
            this.dataGridViewListaTecnicos.Location = new System.Drawing.Point(10, 27);
            this.dataGridViewListaTecnicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListaTecnicos.Name = "dataGridViewListaTecnicos";
            this.dataGridViewListaTecnicos.ReadOnly = true;
            this.dataGridViewListaTecnicos.RowHeadersWidth = 51;
            this.dataGridViewListaTecnicos.RowTemplate.Height = 29;
            this.dataGridViewListaTecnicos.Size = new System.Drawing.Size(477, 302);
            this.dataGridViewListaTecnicos.TabIndex = 0;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(297, 384);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(82, 22);
            this.buttonCadastrar.TabIndex = 1;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(209, 384);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(82, 22);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(122, 384);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(82, 22);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(34, 384);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(82, 22);
            this.buttonApagar.TabIndex = 4;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnClube
            // 
            this.ColumnClube.HeaderText = "Clube";
            this.ColumnClube.Name = "ColumnClube";
            this.ColumnClube.ReadOnly = true;
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.HeaderText = "CPF";
            this.ColumnCpf.Name = "ColumnCpf";
            this.ColumnCpf.ReadOnly = true;
            // 
            // ColumnDataNascimento
            // 
            this.ColumnDataNascimento.HeaderText = "Data de nascimento";
            this.ColumnDataNascimento.Name = "ColumnDataNascimento";
            this.ColumnDataNascimento.ReadOnly = true;
            // 
            // TecnicoListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 414);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.dataGridViewListaTecnicos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TecnicoListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Técnicos cadastrados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaTecnicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewListaTecnicos;
        private Button buttonCadastrar;
        private Button buttonEditar;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCpf;
        private DataGridViewTextBoxColumn ColumnClubeAtual;
        private Button buttonMenu;
        private Button buttonApagar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnClube;
        private DataGridViewTextBoxColumn ColumnDataNascimento;
    }
}