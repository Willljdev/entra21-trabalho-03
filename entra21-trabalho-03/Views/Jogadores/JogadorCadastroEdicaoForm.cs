using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Jogadores
{
    public partial class JogadorCadastroEdicaoForm : Form
    {
        private readonly PosicaoService _posicaoService;
        //private readonly ClubeService _clubeService;
        private readonly int _idEditar;
        public JogadorCadastroEdicaoForm()
        {
            InitializeComponent();

            _posicaoService = new PosicaoService();
            //_clubeService = new ClubeService();

            //PreencherComboBoxClube();
            PreencherComboBoxPosicao();

            _idEditar = -1;
        }

        public JogadorCadastroEdicaoForm(Jogador jogador) : this()
        {
            _idEditar = jogador.Id;
            textBoxNome.Text = jogador.Nome;
            maskedTextBoxCpf.Text = jogador.Cpf;
            dateTimePickerDataNascimento.Value = jogador.DataNascimento;

            for (var i = 0; i < comboBoxClube.Items.Count; i++)
            {
                var clubePercorrido = comboBoxClube.Items[i] as Clube;

                if (clubePercorrido.Id == jogador.Clube.Id)
                {
                    comboBoxClube.SelectedItem = clubePercorrido;
                    break;
                }
            }

            for (var i = 0; i < comboBoxPosicao.Items.Count; i++)
            {
                var posicaoPercorrida = comboBoxPosicao.Items[i] as Posicao;

                if (posicaoPercorrida.Id == jogador.Posicao.Id)
                    comboBoxPosicao.SelectedItem = posicaoPercorrida;
            }
        }

        //private void PreencherComboBoxClube()
        //{
        //    var clubes = _clubeService.ObterTodos();

        //    for (var i = 0; i < clubes.Count; i++)
        //    {
        //        var clube = clubes[i];
        //        comboBoxClube.Items.Add(clube);
        //    }
        //}

        private void PreencherComboBoxPosicao()
        {
            var posicoes = _posicaoService.ObterTodos();

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
            var clube = comboBoxClube.SelectedItem as Clube;
            var posicao = comboBoxPosicao.SelectedItem as Posicao;
            var cpf = maskedTextBoxCpf.Text.Trim();
            var dataNascimento = Convert.ToDateTime(dateTimePickerDataNascimento.Text);

            if (ValidarDados() == false)
                return;

            var jogador = new Jogador();
            jogador.Nome = nome;
            jogador.Posicao = posicao;
            jogador.Clube = clube;
            jogador.Cpf = cpf;
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
                textBoxNome.ResetText();
                textBoxNome.Focus();
                return false;
            }
            if (comboBoxClube.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um clube para o jogador");
                comboBoxClube.DroppedDown = true;
                return false;
            }

            if (comboBoxPosicao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma posição para o jogador");
                comboBoxPosicao.DroppedDown = true;
                return false;
            }

            if (maskedTextBoxCpf.Text.Length != 11)
            {
                MessageBox.Show("Digite um CPF válido");
                maskedTextBoxCpf.ResetText();
                maskedTextBoxCpf.Focus();
            }
            return true;
        }
    }
}
