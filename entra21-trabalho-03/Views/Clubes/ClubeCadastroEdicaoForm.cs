using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Clubes
{
    public partial class ClubeCadastroEdicaoForm : Form
    {
        private readonly int _idEditar;
        public ClubeCadastroEdicaoForm()
        {
            InitializeComponent();
            _idEditar = -1;
        }
        public ClubeCadastroEdicaoForm(Clube clube) : this()
        {
            _idEditar = clube.Id;
            textBoxNomeClube.Text = clube.Nome;
            textBoxCidadeSede.Text = clube.CidadeSede;
            dateTimePickerAnoFundacao.Value = Convert.ToDateTime(clube.AnoFundacao.ToString("dd/MM/yyyy"));
            dateTimePickerHoraFundacao.Value = Convert.ToDateTime(clube.AnoFundacao.ToString("HH:mm:ss"));
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNomeClube.Text.Trim();
            var cidadeSede = textBoxCidadeSede.Text.Trim();
            var dataFundacao = Convert.ToDateTime(dateTimePickerAnoFundacao.Value.Date.ToString("dd/MM/yyyy") + " " +
                dateTimePickerHoraFundacao.Value.TimeOfDay);

            if (ValidarDados() == false)
                return;

            var clube = new Clube();
            clube.Nome = nome;
            clube.CidadeSede = cidadeSede;
            clube.AnoFundacao = dataFundacao;

            var clubeService = new ClubeService();

            if (_idEditar == -1)
            {
                clubeService.Cadastrar(clube);
                MessageBox.Show("Clube cadastrado com sucesso!");
                Close();
            }
            else
            {
                clube.Id = _idEditar;
                clubeService.Editar(clube);
                MessageBox.Show("Clube editado com sucesso!");
                Close();
            }
        }
        private bool ValidarDados()
        {
            if (textBoxNomeClube.Text.Length < 3 || textBoxNomeClube.Text.Length > 30)
            {
                MessageBox.Show("O nome do clube deve de 3 à 30 caracteres!");
                textBoxNomeClube.ResetText();
                textBoxNomeClube.Focus();
                return false;
            }

            if (textBoxCidadeSede.Text.Length < 3 || textBoxCidadeSede.Text.Length > 25)
            {
                MessageBox.Show("O nome da cidade deve de 3 à 25 caracteres!");
                textBoxNomeClube.ResetText();
                textBoxNomeClube.Focus();
                return false;
            }
            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
