namespace entra21_trabalho_03.Views.Competicoes
{
    public partial class CompeticaoCadastroForm : Form
    {
        public CompeticaoCadastroForm()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var dataInicio = Convert.ToDateTime(dateTimePickerDataInicio.Text);
            var dataTermino = Convert.ToDateTime(dateTimePickerDataTermino.Text);

            if (nome.Length < 3 || nome.Length > 50)
            {
                MessageBox.Show("Digita um nome maior ai poh!!");
                textBoxNome.ResetText();
                textBoxNome.Focus();
                return;
            }
        }
    }
}
