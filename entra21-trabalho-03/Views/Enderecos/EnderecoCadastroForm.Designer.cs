namespace entra21_trabalho_03.Views.Enderecos
{
    partial class EnderecoCadastroForm
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
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.textBoxEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.labelEnderecoCompleto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMorador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.comboBoxMorador = new System.Windows.Forms.ComboBox();
            this.labelMorador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(21, 41);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxCep.TabIndex = 0;
            this.maskedTextBoxCep.Leave += new System.EventHandler(this.maskedTextBoxCep_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cep";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(21, 186);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 11;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(135, 186);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 12;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(21, 104);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(189, 23);
            this.textBoxEnderecoCompleto.TabIndex = 13;
            // 
            // labelEnderecoCompleto
            // 
            this.labelEnderecoCompleto.AutoSize = true;
            this.labelEnderecoCompleto.Location = new System.Drawing.Point(21, 86);
            this.labelEnderecoCompleto.Name = "labelEnderecoCompleto";
            this.labelEnderecoCompleto.Size = new System.Drawing.Size(110, 15);
            this.labelEnderecoCompleto.TabIndex = 14;
            this.labelEnderecoCompleto.Text = "Endereço completo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCódigo,
            this.ColumnCep,
            this.ColumnEnderecoCompleto,
            this.ColumnMorador});
            this.dataGridView1.Location = new System.Drawing.Point(235, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 275);
            this.dataGridView1.TabIndex = 15;
            // 
            // ColumnCódigo
            // 
            this.ColumnCódigo.HeaderText = "Código";
            this.ColumnCódigo.Name = "ColumnCódigo";
            this.ColumnCódigo.ReadOnly = true;
            // 
            // ColumnCep
            // 
            this.ColumnCep.HeaderText = "Cep";
            this.ColumnCep.Name = "ColumnCep";
            this.ColumnCep.ReadOnly = true;
            // 
            // ColumnEnderecoCompleto
            // 
            this.ColumnEnderecoCompleto.HeaderText = "Endereço completo";
            this.ColumnEnderecoCompleto.Name = "ColumnEnderecoCompleto";
            this.ColumnEnderecoCompleto.ReadOnly = true;
            // 
            // ColumnMorador
            // 
            this.ColumnMorador.HeaderText = "Morador";
            this.ColumnMorador.Name = "ColumnMorador";
            this.ColumnMorador.ReadOnly = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(517, 293);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 16;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(598, 293);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 17;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // comboBoxMorador
            // 
            this.comboBoxMorador.DisplayMember = "Nome";
            this.comboBoxMorador.FormattingEnabled = true;
            this.comboBoxMorador.Location = new System.Drawing.Point(21, 157);
            this.comboBoxMorador.Name = "comboBoxMorador";
            this.comboBoxMorador.Size = new System.Drawing.Size(189, 23);
            this.comboBoxMorador.TabIndex = 18;
            this.comboBoxMorador.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelMorador
            // 
            this.labelMorador.AutoSize = true;
            this.labelMorador.Location = new System.Drawing.Point(21, 139);
            this.labelMorador.Name = "labelMorador";
            this.labelMorador.Size = new System.Drawing.Size(53, 15);
            this.labelMorador.TabIndex = 19;
            this.labelMorador.Text = "Morador";
            // 
            // EnderecoCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 328);
            this.Controls.Add(this.labelMorador);
            this.Controls.Add(this.comboBoxMorador);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelEnderecoCompleto);
            this.Controls.Add(this.textBoxEnderecoCompleto);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Name = "EnderecoCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de endereços";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox maskedTextBoxCep;
        private Label label5;
        private Button buttonMenu;
        private Button buttonCadastrar;
        private TextBox textBoxEnderecoCompleto;
        private Label labelEnderecoCompleto;
        private DataGridView dataGridView1;
        private Button buttonApagar;
        private Button buttonEditar;
        private DataGridViewTextBoxColumn ColumnCódigo;
        private DataGridViewTextBoxColumn ColumnCep;
        private DataGridViewTextBoxColumn ColumnEnderecoCompleto;
        private DataGridViewTextBoxColumn ColumnMorador;
        private ComboBox comboBoxMorador;
        private Label labelMorador;
    }
}