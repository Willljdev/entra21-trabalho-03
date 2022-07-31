using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Competicoes
{
    public partial class CompeticoesListagemForm : Form
    {
        private readonly CompeticaoService _competicao;
        public CompeticoesListagemForm()
        {
            InitializeComponent();
            _competicao = new CompeticaoService();
            PreencherDataGridView();
            BotoesTransparentes();
        }

        private void PreencherDataGridView()
        {
            var competicoes = _competicao.ObterTodos();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < competicoes.Count; i++)
            {
                var competicao = competicoes[i];
                dataGridView1.Rows.Add(new object[]
                {
                    competicao.Id,
                    competicao.Nome,
                    competicao.DataInicio.ToString("dd/MM/yyyy"),
                    competicao.DataTermino.ToString("dd/MM/yyyy"),
                });


            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var competicaoForm = new CompeticaoCadastroForm();
            competicaoForm.ShowDialog();
            PreencherDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma competição pra apagar");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Primeiro cadastre uma competição!!");
                return;
            }

            var linha = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            _competicao.Apagar(id);

            PreencherDataGridView();
            MessageBox.Show("Competição apagada!!");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma competição pra Editar");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma competição primeiro!!");
                return;
            }

            var linha = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            var competicao = _competicao.ObterPorId(id);
            var competicaoForm = new CompeticaoCadastroForm(competicao);
            competicaoForm.ShowDialog();

            PreencherDataGridView();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotoesTransparentes()
        {
            buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonApagar.FlatAppearance.BorderSize = 0;
            buttonApagar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonApagar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonApagar.BackColor = Color.Transparent;

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

            buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCadastrar.FlatAppearance.BorderSize = 0;
            buttonCadastrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCadastrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCadastrar.BackColor = Color.Transparent;
        }
    }
}
