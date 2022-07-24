using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

// LINHAS COMENTADAS: REVISAR
namespace entra21_trabalho_03.Views.Jogadores
{
    public partial class JogadorCadastroEdicaoForm : Form
    {
        private readonly int _idEditar;
        public JogadorCadastroEdicaoForm()
        {
            InitializeComponent();
            //PreencherComboBoxClube();
            PreencherComboBoxPosicao();
            _idEditar = -1;
        }

        private void PreencherComboBoxClube()
        {
            throw new NotImplementedException();
        }

        private void PreencherComboBoxPosicao()
        {
            var posicaoService = new PosicaoService();
            var posicoes = posicaoService.ObterTodos();

            for (var i = 0; i < posicoes.Count; i++)
            {
                var posicao = posicoes[i];
                comboBoxPosicao.Items.Add(posicao);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var clube = comboBoxClubes.SelectedItem as Clube;
            var posicao = comboBoxPosicao.SelectedItem as Posicao;
            // TO DO: CPF
            //var cpf = Convert.ToInt32(textBoxCpf.Text.Trim().Replace(".", "-"));
            var dataNascimento = Convert.ToDateTime(dateTimePickerDataNascimento.Text);

            var jogador = new Jogador();
            jogador.Nome = nome;
            jogador.Clube = clube;
            jogador.Posicao = posicao;
            //jogador.Cpf = cpf;
            jogador.DataNascimento = dataNascimento;

            var jogadorService = new JogadorService();

            if (_idEditar == -1)
            {
                jogadorService.Cadastrar(jogador);
                MessageBox.Show("Jogador cadastrado com sucesso");
                Close();
            }
            else
            {
                jogador.Id = _idEditar;
                jogadorService.Editar(jogador);
                MessageBox.Show("Cadastro do jogador alterado com sucesso");
                Close();
            }
        }

        private bool ValidarDados()
        {
            if (textBoxNome.Text.Length < 2 || textBoxNome.Text.Length > 50)
            {
                MessageBox.Show("O nome do jogador deve conter entre 2 e 50 caracteres");
                textBoxNome.Focus();
                return false;
            }
            if (comboBoxClubes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um clube para o jogador");
                comboBoxClubes.DroppedDown = true;
                return false;
            }

            if (comboBoxPosicao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma posição para o jogador");
                comboBoxPosicao.DroppedDown = true;
                return false;
            }
            return true;

        }
    }
}
