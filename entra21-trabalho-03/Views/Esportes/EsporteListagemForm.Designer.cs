namespace entra21_trabalho_03.Views.Paises
{
    partial class EsporteListagemForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeEsporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadesJogadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadesAtletasClube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalPraticado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEquipes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNomeEsporte,
            this.ColumnQuantidadesJogadores,
            this.ColumnQuantidadesAtletasClube,
            this.ColumnLocalPraticado,
            this.ColumnClube,
            this.ColumnEquipes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(836, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(12, 64);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(93, 64);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(255, 64);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 3;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(174, 64);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 4;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNomeEsporte
            // 
            this.ColumnNomeEsporte.HeaderText = "Nome do esporte";
            this.ColumnNomeEsporte.Name = "ColumnNomeEsporte";
            this.ColumnNomeEsporte.ReadOnly = true;
            // 
            // ColumnQuantidadesJogadores
            // 
            this.ColumnQuantidadesJogadores.HeaderText = "Quantidades jogadores por time";
            this.ColumnQuantidadesJogadores.Name = "ColumnQuantidadesJogadores";
            this.ColumnQuantidadesJogadores.ReadOnly = true;
            // 
            // ColumnQuantidadesAtletasClube
            // 
            this.ColumnQuantidadesAtletasClube.HeaderText = "Quantidade de atletas no clube";
            this.ColumnQuantidadesAtletasClube.Name = "ColumnQuantidadesAtletasClube";
            this.ColumnQuantidadesAtletasClube.ReadOnly = true;
            // 
            // ColumnLocalPraticado
            // 
            this.ColumnLocalPraticado.HeaderText = "Local praticado";
            this.ColumnLocalPraticado.Name = "ColumnLocalPraticado";
            this.ColumnLocalPraticado.ReadOnly = true;
            // 
            // ColumnClube
            // 
            this.ColumnClube.HeaderText = "Clube";
            this.ColumnClube.Name = "ColumnClube";
            this.ColumnClube.ReadOnly = true;
            // 
            // ColumnEquipes
            // 
            this.ColumnEquipes.HeaderText = "Equipes";
            this.ColumnEquipes.Name = "ColumnEquipes";
            this.ColumnEquipes.ReadOnly = true;
            // 
            // EsporteListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 489);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EsporteListagemForm";
            this.Text = "Listagem de paises";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonCadastrar;
        private Button buttonMenu;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNomeEsporte;
        private DataGridViewTextBoxColumn ColumnQuantidadesJogadores;
        private DataGridViewTextBoxColumn ColumnQuantidadesAtletasClube;
        private DataGridViewTextBoxColumn ColumnLocalPraticado;
        private DataGridViewTextBoxColumn ColumnClube;
        private DataGridViewTextBoxColumn ColumnEquipes;
    }
}