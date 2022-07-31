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
            BotoesTransparente();
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

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotoesTransparente()
        {
            buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonApagar.FlatAppearance.BorderSize = 0;
            buttonApagar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonApagar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonApagar.BackColor = Color.Transparent;

            buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCadastrar.FlatAppearance.BorderSize = 0;
            buttonCadastrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCadastrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCadastrar.BackColor = Color.Transparent;

            buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMenu.BackColor = Color.Transparent;

            buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonEditar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonEditar.BackColor = Color.Transparent;
        }
    }
}
