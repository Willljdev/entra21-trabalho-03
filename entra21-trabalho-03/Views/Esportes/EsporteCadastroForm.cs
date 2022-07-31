using entra21_trabalho_03.EsportesCompeticoes.Models;
using entra21_trabalho_03.EsportesCompeticoes.Services;
using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Paises
{
    public partial class EsporteCadastroForm : Form
    {
        private readonly int _idEditar;
        private readonly ClubeService _clubeService;
        public EsporteCadastroForm()
        {
            InitializeComponent();
            _clubeService = new ClubeService();
            PreencherComboBoxClube();
            _idEditar = -1;
        }

        public EsporteCadastroForm(Esporte esportes) : this()
        {
            _idEditar = esportes.Id;
            textBoxNome.Text = esportes.Nome;
            numericUpDownJogadores.Text = esportes.QuantidadesJogadoresTime.ToString();
            numericUpDownClube.Text = esportes.QuantidadesAtletasClube.ToString();
            textBoxLocalPraticado.Text = esportes.LocalPraticado;

            for (var i = 0; i < comboBoxClube.Items.Count; i++)
            {
                var clubePercorrido = comboBoxClube.Items[i] as Clube;
                if (clubePercorrido.Id == esportes.Clube.Id)
                {
                    comboBoxClube.SelectedItem = clubePercorrido;
                    break;
                }
            }
        }

        private void PreencherComboBoxClube()
        {
            var clubes = _clubeService.ObterTodos();

            for (var i = 0; i < clubes.Count; i++)
            {
                var clube = clubes[i];
                comboBoxClube.Items.Add(clube);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var clube = comboBoxClube.SelectedItem as Clube;

            if (ValidarDados() == false)
                return;

            var esportes = new Esporte();
            esportes.Nome = textBoxNome.Text.Trim();
            esportes.QuantidadesJogadoresTime = Convert.ToInt32(numericUpDownJogadores.Value);
            esportes.QuantidadesAtletasClube = Convert.ToInt32(numericUpDownClube.Value);
            esportes.LocalPraticado = textBoxLocalPraticado.Text.Trim();

            var esporteService = new EsporteService();
            if (_idEditar == -1)
            {
                esporteService.Cadastrar(esportes);
                MessageBox.Show("Cadastrados com sucessos!!");
                Close();
                return;
            }

            esportes.Id = _idEditar;
            esporteService.Editar(esportes);
            MessageBox.Show("Alterados!!");
            Close();
        }

        private bool ValidarDados()
        {
            if (textBoxNome.Text.Length < 3 || textBoxLocalPraticado.Text.Length > 50)
            {
                MessageBox.Show("Digita um nome descente ai fio");
                textBoxNome.ResetText();
                textBoxNome.Focus();
                return false;
            }

            if (numericUpDownJogadores.Value < 3 || numericUpDownJogadores.Value > 50)
            {
                MessageBox.Show("Digita um continente maior ai");
                numericUpDownJogadores.ResetText();
                numericUpDownJogadores.Focus();
                return false;
            }
            if (numericUpDownClube.Value < 10 || numericUpDownClube.Value > 200)
            {
                MessageBox.Show("Digita um numero de atleta valido ai!!");
                numericUpDownClube.ResetText();
                numericUpDownClube.Focus();
            }
            if (textBoxLocalPraticado.Text.Length < 3 || textBoxLocalPraticado.Text.Length > 50)
            {
                MessageBox.Show("Digite um local praticado valido fi");
                textBoxLocalPraticado.ResetText();
                textBoxLocalPraticado.Focus();
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
