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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma posição para alterar");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma posição");
                return;
            }

            var linha = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linha.Cells[0].Value);

            var posicao = posicaoService.ObterPorId(id);

            var posicaoForm = new PosicaoCadastroEdicaoForm(posicao);
            posicaoForm.ShowDialog();

            AtualizarDataGrideView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            posicaoService.Apagar(id);

            AtualizarDataGrideView();
            MessageBox.Show("Posição apagada com sucesso");
        }
    }
}
