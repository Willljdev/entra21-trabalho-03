using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Técnicos
{
    public partial class TecnicoListagemForm : Form
    {
        private readonly TecnicoService _tecnicoService;
        public TecnicoListagemForm()
        {
            InitializeComponent();
            _tecnicoService = new TecnicoService();
            PreencherDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaTecnicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um técnico para apagar!");
                return;
            }

            if (dataGridViewListaTecnicos.Rows.Count == 0)
            {
                MessageBox.Show("Não nem um técnico cadastrado");
                return;
            }

            var linha = dataGridViewListaTecnicos.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            _tecnicoService.Apagar(id);

            PreencherDataGridView();

            MessageBox.Show("Técnico apagado do sistema!");
        }

        private void PreencherDataGridView()
        {
            var tecnicos = _tecnicoService.ObterTodos();
            dataGridViewListaTecnicos.Rows.Clear();

            for (var i = 0; i < tecnicos.Count; i++)
            {
                var tecnico = tecnicos[i];
                dataGridViewListaTecnicos.Rows.Add(new object[]
                {
                    tecnico.Id,
                    tecnico.Nome,
                    tecnico.Cpf,
                    tecnico.CidadeNatal,
                    tecnico.DataNascimento.ToString("dd/MM/yyyy")
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tecnicoForm = new TecnicoCadastroEdicaoForm();
            tecnicoForm.ShowDialog();
            PreencherDataGridView();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaTecnicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um técnico para editar!");
                return;
            }

            if (dataGridViewListaTecnicos.Rows.Count == 0)
            {
                MessageBox.Show("Não há nem um técnico cadastrado!");
                return;
            }

            var linha = dataGridViewListaTecnicos.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            var tecnico = _tecnicoService.ObterPorId(id);
            var tecnicoForm = new TecnicoCadastroEdicaoForm(tecnico);
            tecnicoForm.ShowDialog();

            PreencherDataGridView();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
