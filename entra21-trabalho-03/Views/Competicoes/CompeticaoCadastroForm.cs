using entra21_trabalho_03.EsportesCompeticoes.Models;
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
            dateTimePickerDateInicio.Value = Convert.ToDateTime(competicao.DataInicio.ToString("dd/MM/yyyy"));
            dateTimePickerDateInicio.Value = Convert.ToDateTime(competicao.DataInicio.ToString("HH:mm:ss"));
            
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
            var dataInicio = Convert.ToDateTime(dateTimePickerHoraInicio.Text);
            var dataTermino = Convert.ToDateTime(dateTimePickerDateInicio.Text);

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
