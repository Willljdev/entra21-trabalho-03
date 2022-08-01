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
            BotoesTransparentes();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

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
                    tecnico.DataNascimento.ToString("dd/MM/yyyy"),
                    tecnico.CidadeNatal
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
            if (ValidarDados() == false)
                return;

            var linha = dataGridViewListaTecnicos.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            var tecnico = _tecnicoService.ObterPorId(id);
            var tecnicoForm = new TecnicoCadastroEdicaoForm(tecnico);
            tecnicoForm.ShowDialog();

            PreencherDataGridView();
        }

        private bool ValidarDados()
        {
            if (dataGridViewListaTecnicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um técnico para editar!");
                return false;
            }

            if (dataGridViewListaTecnicos.Rows.Count == 0)
            {
                MessageBox.Show("Não há nem um técnico cadastrado!");
                return false;
            }

            if (dataGridViewListaTecnicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um técnico para apagar!");
                return false;
            }

            if (dataGridViewListaTecnicos.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre um técnico primeiro!");
                return false;
            }
            return true;
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