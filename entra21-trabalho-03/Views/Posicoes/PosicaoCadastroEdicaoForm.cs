using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Posicoes
{
    public partial class PosicaoCadastroEdicaoForm : Form
    {
        private int idEdicao = -1;
        public PosicaoCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        public PosicaoCadastroEdicaoForm(Posicao posicao) : this()
        {
            idEdicao = posicao.Id;
            textBoxPosicao.Text = posicao.Nome;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxPosicao.Text.Trim();

            if (nome.Length < 5 || nome.Length > 50)
            {
                MessageBox.Show("Digite uma posição que exista");
                textBoxPosicao.ResetText();
                textBoxPosicao.Focus();
                return;
            }

            var posicao = new Posicao();
            posicao.Nome = nome;

            var posicaoService = new PosicaoService();

            if (idEdicao == -1)
            {
                posicaoService.Cadastrar(posicao);
                MessageBox.Show("Posição cadastrada com sucesso");
                Close();
                return;
            }

            posicao.Id = idEdicao;
            posicaoService.Editar(posicao);
            MessageBox.Show("Posição alterada com sucesso");
            Close();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {

        }

        private void BotoesTransparente()
        {
            buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSalvar.FlatAppearance.BorderSize = 0;
            buttonSalvar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSalvar.BackColor = Color.Transparent;

            buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCancelar.BackColor = Color.Transparent;
        }
    }
}