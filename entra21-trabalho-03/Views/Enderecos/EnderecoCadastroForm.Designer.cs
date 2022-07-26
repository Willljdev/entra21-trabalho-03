﻿namespace entra21_trabalho_03.Views.Enderecos
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
            this.ColumnSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxSigla = new System.Windows.Forms.TextBox();
            this.labelSiglaEstado = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.labelRua = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCep.Location = new System.Drawing.Point(21, 33);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBoxCep.TabIndex = 0;
            this.maskedTextBoxCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCep_MaskInputRejected);
            this.maskedTextBoxCep.Leave += new System.EventHandler(this.maskedTextBoxCep_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cep";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMenu.Location = new System.Drawing.Point(12, 293);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 33);
            this.buttonMenu.TabIndex = 11;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrar.Location = new System.Drawing.Point(93, 293);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(89, 33);
            this.buttonCadastrar.TabIndex = 12;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(21, 264);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(184, 26);
            this.textBoxEnderecoCompleto.TabIndex = 13;
            this.textBoxEnderecoCompleto.TextChanged += new System.EventHandler(this.textBoxEnderecoCompleto_TextChanged);
            // 
            // labelEnderecoCompleto
            // 
            this.labelEnderecoCompleto.AutoSize = true;
            this.labelEnderecoCompleto.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnderecoCompleto.Location = new System.Drawing.Point(21, 244);
            this.labelEnderecoCompleto.Name = "labelEnderecoCompleto";
            this.labelEnderecoCompleto.Size = new System.Drawing.Size(149, 18);
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
            this.ColumnSigla,
            this.ColumnCidade,
            this.ColumnBairro,
            this.ColumnRua});
            this.dataGridView1.Location = new System.Drawing.Point(211, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(658, 275);
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
            // ColumnSigla
            // 
            this.ColumnSigla.HeaderText = "Sigla";
            this.ColumnSigla.Name = "ColumnSigla";
            this.ColumnSigla.ReadOnly = true;
            // 
            // ColumnCidade
            // 
            this.ColumnCidade.HeaderText = "Cidade";
            this.ColumnCidade.Name = "ColumnCidade";
            this.ColumnCidade.ReadOnly = true;
            // 
            // ColumnBairro
            // 
            this.ColumnBairro.HeaderText = "Bairro";
            this.ColumnBairro.Name = "ColumnBairro";
            this.ColumnBairro.ReadOnly = true;
            // 
            // ColumnRua
            // 
            this.ColumnRua.HeaderText = "Rua";
            this.ColumnRua.Name = "ColumnRua";
            this.ColumnRua.ReadOnly = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(504, 293);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 33);
            this.buttonApagar.TabIndex = 16;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.Location = new System.Drawing.Point(585, 293);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 33);
            this.buttonEditar.TabIndex = 17;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCidade.Location = new System.Drawing.Point(21, 106);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(58, 18);
            this.labelCidade.TabIndex = 18;
            this.labelCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCidade.Location = new System.Drawing.Point(21, 127);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(184, 26);
            this.textBoxCidade.TabIndex = 19;
            // 
            // textBoxSigla
            // 
            this.textBoxSigla.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSigla.Location = new System.Drawing.Point(21, 80);
            this.textBoxSigla.Name = "textBoxSigla";
            this.textBoxSigla.Size = new System.Drawing.Size(44, 26);
            this.textBoxSigla.TabIndex = 20;
            this.textBoxSigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSiglaEstado
            // 
            this.labelSiglaEstado.AutoSize = true;
            this.labelSiglaEstado.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSiglaEstado.Location = new System.Drawing.Point(21, 59);
            this.labelSiglaEstado.Name = "labelSiglaEstado";
            this.labelSiglaEstado.Size = new System.Drawing.Size(119, 18);
            this.labelSiglaEstado.TabIndex = 21;
            this.labelSiglaEstado.Text = "Sigla do estado";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxBairro.Location = new System.Drawing.Point(21, 174);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(184, 26);
            this.textBoxBairro.TabIndex = 22;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBairro.Location = new System.Drawing.Point(21, 156);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(53, 18);
            this.labelBairro.TabIndex = 23;
            this.labelBairro.Text = "Bairro";
            // 
            // textBoxRua
            // 
            this.textBoxRua.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxRua.Location = new System.Drawing.Point(21, 218);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(184, 26);
            this.textBoxRua.TabIndex = 24;
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRua.Location = new System.Drawing.Point(21, 200);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(36, 18);
            this.labelRua.TabIndex = 25;
            this.labelRua.Text = "Rua";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLimpar.Location = new System.Drawing.Point(188, 293);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 33);
            this.buttonLimpar.TabIndex = 26;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click_1);
            // 
            // EnderecoCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(881, 330);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.labelRua);
            this.Controls.Add(this.textBoxRua);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.labelSiglaEstado);
            this.Controls.Add(this.textBoxSigla);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.labelCidade);
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
        private DataGridViewTextBoxColumn ColumnSigla;
        private DataGridViewTextBoxColumn ColumnCidade;
        private DataGridViewTextBoxColumn ColumnBairro;
        private DataGridViewTextBoxColumn ColumnRua;
        private Label labelCidade;
        private TextBox textBoxCidade;
        private TextBox textBoxSigla;
        private Label labelSiglaEstado;
        private TextBox textBoxBairro;
        private Label labelBairro;
        private TextBox textBoxRua;
        private Label labelRua;
        private Button buttonLimpar;
    }
}