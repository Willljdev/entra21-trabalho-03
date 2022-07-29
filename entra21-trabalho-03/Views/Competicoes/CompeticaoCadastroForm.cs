using entra21_trabalho_03.PaisesCompeticoes.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Competicoes
{
    public partial class CompeticaoCadastroForm : Form
    {
        private readonly CompeticaoService _competicaoService;
        private readonly int _idEditar;
        public CompeticaoCadastroForm()
        {
            InitializeComponent();

            _competicaoService = new CompeticaoService();

            _idEditar = -1;
        }

        public CompeticaoCadastroForm(Competicao competicao) :this()
        {
            _idEditar = competicao.Id;
            textBoxNome.Text = competicao.Nome;
            dateTimePickerDataInicio.Value = competicao.Data_inicio;
            dateTimePickerDataTermino.Value = competicao.Data_termino;

            
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
