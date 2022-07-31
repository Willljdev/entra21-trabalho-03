using entra21_trabalho_03.Views.Clubes;
using entra21_trabalho_03.Views.Competicoes;
using entra21_trabalho_03.Views.Enderecos;
using entra21_trabalho_03.Views.Jogadores;
using entra21_trabalho_03.Views.Paises;
using entra21_trabalho_03.Views.Posicoes;
using entra21_trabalho_03.Views.Técnicos;

namespace entra21_trabalho_03.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
            BotoesTransparentes();
        }

        private void buttonJogadores_Click(object sender, EventArgs e)
        {
            var jogadores = new JogadorListagemForm();
            jogadores.ShowDialog();
        }

        private void buttonPaises_Click(object sender, EventArgs e)
        {
            var paises = new EsporteListagemForm();
            paises.ShowDialog();
        }

        private void buttonClubes_Click(object sender, EventArgs e)
        {
            var clubes = new ClubeListagemForm();
            clubes.ShowDialog();
        }

        private void buttonPosicoes_Click(object sender, EventArgs e)
        {
            var posicoes = new PosicaoListagemForm();
            posicoes.ShowDialog();
        }

        private void buttonCompeticoes_Click(object sender, EventArgs e)
        {
            var competicoes = new CompeticoesListagemForm();
            competicoes.ShowDialog();
        }

        private void buttonTecnicos_Click(object sender, EventArgs e)
        {
            var tecnicos = new TecnicoListagemForm();
            tecnicos.ShowDialog();
        }
        private void buttonEnderecos_Click(object sender, EventArgs e)
        {
            var enderecosForm = new EnderecoCadastroForm();
            enderecosForm.ShowDialog();
        }
        private void BotoesTransparentes()
        {
            buttonPosicoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonPosicoes.FlatAppearance.BorderSize = 0;
            buttonPosicoes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonPosicoes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonPosicoes.BackColor = Color.Transparent;

            buttonClubes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonClubes.FlatAppearance.BorderSize = 0;
            buttonClubes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonClubes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonClubes.BackColor = Color.Transparent;

            buttonPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonPaises.FlatAppearance.BorderSize = 0;
            buttonPaises.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonPaises.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonPaises.BackColor = Color.Transparent;

            buttonJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonJogadores.FlatAppearance.BorderSize = 0;
            buttonJogadores.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonJogadores.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonJogadores.BackColor = Color.Transparent;

            buttonCompeticoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCompeticoes.FlatAppearance.BorderSize = 0;
            buttonCompeticoes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCompeticoes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCompeticoes.BackColor = Color.Transparent;

            buttonTecnicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonTecnicos.FlatAppearance.BorderSize = 0;
            buttonTecnicos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonTecnicos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonTecnicos.BackColor = Color.Transparent;

            buttonEnderecos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonEnderecos.FlatAppearance.BorderSize = 0;
            buttonEnderecos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonEnderecos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonEnderecos.BackColor = Color.Transparent;
        }
    }
}
