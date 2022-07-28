namespace entra21_trabalho_03.Views.Competicoes
{
    partial class CompeticoesCadastroForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.labelDataTermino = new System.Windows.Forms.Label();
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataTermino = new System.Windows.Forms.DateTimePicker();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da competição";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 42);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(200, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Location = new System.Drawing.Point(12, 79);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(66, 15);
            this.labelDataInicio.TabIndex = 2;
            this.labelDataInicio.Text = "Data inicio ";
            // 
            // labelDataTermino
            // 
            this.labelDataTermino.AutoSize = true;
            this.labelDataTermino.Location = new System.Drawing.Point(12, 135);
            this.labelDataTermino.Name = "labelDataTermino";
            this.labelDataTermino.Size = new System.Drawing.Size(76, 15);
            this.labelDataTermino.TabIndex = 3;
            this.labelDataTermino.Text = "Data término";
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(12, 97);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDataInicio.TabIndex = 4;
            // 
            // dateTimePickerDataTermino
            // 
            this.dateTimePickerDataTermino.Location = new System.Drawing.Point(12, 153);
            this.dateTimePickerDataTermino.Name = "dateTimePickerDataTermino";
            this.dateTimePickerDataTermino.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDataTermino.TabIndex = 5;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(165, 195);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 6;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(0, 0);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 0;
            // 
            // CompeticoesCadastroForm
            // 
            this.ClientSize = new System.Drawing.Size(375, 277);
            this.Name = "CompeticoesCadastroForm";
            this.Load += new System.EventHandler(this.CompeticoesCadastroForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private Label labelDataInicio;
        private Label labelDataTermino;
        private DateTimePicker dateTimePickerDataInicio;
        private DateTimePicker dateTimePickerDataTermino;
        private Button buttonCadastrar;
        private Button buttonMenu;
        private Button buttonCancelar;
    }
}