using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Clubes
{
    public partial class ClubeListagemForm : Form
    {
        private readonly ClubeService _clubeService;
        public ClubeListagemForm()
        {
            InitializeComponent();
            _clubeService = new ClubeService();
            PreencherDataGridView();
            BotoesTransparentes();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            var linha = dataGridViewListaClubes.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            _clubeService.Apagar(id);
            PreencherDataGridView();
            MessageBox.Show("Clube apagado do sistema!");
        }

        private void PreencherDataGridView()
        {
            var clubes = _clubeService.ObterTodos();
            dataGridViewListaClubes.Rows.Clear();

            for (var i = 0; i < clubes.Count; i++)
            {
                var clube = clubes[i];
                dataGridViewListaClubes.Rows.Add(new object[]
                {
                        clube.Id,
                        clube.Nome,
                        clube.CidadeSede,
                        clube.AnoFundacao.ToString("dd/MM/yyyy"),
                });
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            var linha = dataGridViewListaClubes.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            var clube = _clubeService.ObterPorId(id);
            var clubeForm = new ClubeCadastroEdicaoForm(clube);
            clubeForm.ShowDialog();

            PreencherDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var clubeForm = new ClubeCadastroEdicaoForm();
            clubeForm.ShowDialog();
            PreencherDataGridView();
        }

        private void buttonApagar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            var linha = dataGridViewListaClubes.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            _clubeService.Apagar(id);
            PreencherDataGridView();
            MessageBox.Show("Clube apagado do sistema!");
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarDados()
        {
            if (dataGridViewListaClubes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um clube para editar!");
                return false;
            }

            if (dataGridViewListaClubes.Rows.Count == 0)
            {
                MessageBox.Show("Não há nem um clube cadastrado!");
                return false;
            }

            if (dataGridViewListaClubes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um clube para apagar!");
                return false;
            }

            if (dataGridViewListaClubes.Rows.Count == 0)
            {
                MessageBox.Show("Não há nem um clube cadastrado sistema!");
                return false;
            }
            return true;
        }

        private void buttonApagar_Click_2(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            var linha = dataGridViewListaClubes.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            _clubeService.Apagar(id);
            PreencherDataGridView();
            MessageBox.Show("Clube apagado do sistema!");
        }

        private void BotoesTransparentes()
        {
            buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonApagar.FlatAppearance.BorderSize = 0;
            buttonApagar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonApagar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonApagar.BackColor = Color.Transparent;

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

            buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMenu.BackColor = Color.Transparent;
        }
    }
}
