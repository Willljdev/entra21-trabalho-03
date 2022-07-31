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
        }

        private void PreencherDataGridView()
        {
            var competicoes = _competicao.ObterTodos();
            dataGridView1.Rows.Clear();

            for(int i = 0; i < competicoes.Count; i++)
            {
                var competicao = competicoes[i];
                dataGridView1.Rows.Add(new object[]
                {
                    competicao.Id,
                    competicao.Nome,
                    competicao.Data_inicio.ToString("dd/MM/yyyy"),
                    competicao.Data_termino.ToString("dd/MM/yyyy"),
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
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma competição pra apagar");
                return;
            }

            if(dataGridView1.Rows.Count == 0)
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
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma competição pra Editar");
                return;
            }

            if(dataGridView1.Rows.Count == 0)
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
    }
}
