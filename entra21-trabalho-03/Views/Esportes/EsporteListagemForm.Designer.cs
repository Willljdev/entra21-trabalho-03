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
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeEsporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadesJogadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadesAtletasClube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalPraticado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelListagemEsportes = new System.Windows.Forms.Label();
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
            this.ColumnLocalPraticado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 355);
            this.dataGridView1.TabIndex = 0;
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
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(320, 13);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 31);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.Location = new System.Drawing.Point(401, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(67, 31);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrar.Location = new System.Drawing.Point(474, 12);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(80, 31);
            this.buttonCadastrar.TabIndex = 3;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMenu.Location = new System.Drawing.Point(251, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(63, 31);
            this.buttonMenu.TabIndex = 4;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelListagemEsportes
            // 
            this.labelListagemEsportes.AutoSize = true;
            this.labelListagemEsportes.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelListagemEsportes.Location = new System.Drawing.Point(12, 19);
            this.labelListagemEsportes.Name = "labelListagemEsportes";
            this.labelListagemEsportes.Size = new System.Drawing.Size(233, 17);
            this.labelListagemEsportes.TabIndex = 5;
            this.labelListagemEsportes.Text = "Listagem de esportes cadastrados";
            // 
            // EsporteListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(570, 418);
            this.Controls.Add(this.labelListagemEsportes);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EsporteListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonCadastrar;
        private Button buttonMenu;
        private Label labelListagemEsportes;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNomeEsporte;
        private DataGridViewTextBoxColumn ColumnQuantidadesJogadores;
        private DataGridViewTextBoxColumn ColumnQuantidadesAtletasClube;
        private DataGridViewTextBoxColumn ColumnLocalPraticado;
    }
}