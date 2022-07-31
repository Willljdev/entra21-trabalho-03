using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Jogadores
{
    public partial class JogadorListagemForm : Form
    {
        private readonly JogadorService _jogadorService;
        public JogadorListagemForm()
        {
            InitializeComponent();
            _jogadorService = new JogadorService();
            PreencherDataGrideView();
            BotoesTransparentes();
        }

        private void PreencherDataGrideView()
        {
            var jogadores = _jogadorService.ObterTodos();
            dataGridView1.Rows.Clear();

            for (var i = 0; i < jogadores.Count; i++)
            {
                var jogador = jogadores[i];
                dataGridView1.Rows.Add(new object[]
                {
                    jogador.Id,
                    jogador.Nome,
                    jogador.Posicao.Nome,
                    jogador.Clube.Nome,
                    jogador.Cpf,
                    jogador.DataNascimento.ToString("dd/MM/yyyy")
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            var linha = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            _jogadorService.Apagar(id);

            PreencherDataGrideView();

            MessageBox.Show("Jogador apagado com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            var linha = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            var jogador = _jogadorService.ObterPorId(id);
            var jogadorForm = new JogadorCadastroEdicaoForm(jogador);
            jogadorForm.ShowDialog();

            PreencherDataGrideView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var jogadorForm = new JogadorCadastroEdicaoForm();
            jogadorForm.ShowDialog();
            PreencherDataGrideView();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JogadorListagemForm_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarDados()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um jogador para apagar");
                return false;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre um jogador primeiro");
                return false;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um jogador para editar");
                return false;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Primeiro cadastre um jogador");
                return false;
            }
            return true;
        }

        private void BotoesTransparentes()
        {
            buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonEditar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonEditar.BackColor = Color.Transparent;

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
        }
    }
}