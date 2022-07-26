using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Posicoes
{
    public partial class PosicaoListagemForm : Form
    {
        private PosicaoService posicaoService;
        public PosicaoListagemForm()
        {
            InitializeComponent();

            posicaoService = new PosicaoService();

            AtualizarDataGrideView();
        }

        private void AtualizarDataGrideView()
        {
            var posicoes = posicaoService.ObterTodos();
            dataGridView1.Rows.Clear();

            for (var i = 0; i < posicoes.Count; i++)
            {
                var posicao = posicoes[i];

                dataGridView1.Rows.Add(new object[]
                {
                    posicao.Id,
                    posicao.Nome
                });
            }
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            var posicaoCadastroEdicaoForm = new PosicaoCadastroEdicaoForm();
            posicaoCadastroEdicaoForm.ShowDialog();
            AtualizarDataGrideView();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            var linha = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linha.Cells[0].Value);

            var posicao = posicaoService.ObterPorId(id);

            var posicaoForm = new PosicaoCadastroEdicaoForm(posicao);
            posicaoForm.ShowDialog();

            AtualizarDataGrideView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            AtualizarDataGrideView();

            var apagar = MessageBox.Show("Deseja realmente apagar?", "ATENÇÃO !!!", MessageBoxButtons.YesNo);
            
            if (apagar == DialogResult.Yes)
            {
                posicaoService.Apagar(id);
                MessageBox.Show("Posição apagada com sucesso");
                AtualizarDataGrideView();
            }
            else if (apagar != DialogResult.Yes)
                return;
        }

        private bool ValidarDados()
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma posição cadastrada");
                return false;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma posição para apagar");
                return false;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma posição para alterar");
                return false;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma posição");
                return false;
            }
            return true;
        }
    }
}
