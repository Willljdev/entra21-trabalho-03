using entra21_trabalho_03.EsportesCompeticoes.Services;

namespace entra21_trabalho_03.Views.Paises
{
    public partial class EsporteListagemForm : Form
    {
        private readonly EsporteService _paisService;
        public EsporteListagemForm()
        {
            InitializeComponent();
            _paisService = new EsporteService();
            PreencherDataGridView();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherDataGridView()
        {
            var pais = _paisService.ObterTodos();
            dataGridView1.Rows.Clear();

            for(int i = 0; i < pais.Count; i++)
            {
                var paises = pais[i];
                dataGridView1.Rows.Add(new object[]
                {
                    paises.Id,
                    paises.Nome,
                    paises.QuantidadesJogadoresTime
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um pais pra apagar ai!!");
                return;
            }

            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Primeiro cadastra um pais né!!");
                return;
            }

            var linha = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            _paisService.Apagar(id);

            PreencherDataGridView();

            MessageBox.Show("Pais apagado!!");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pais para ser editado!!");
                return;
            }

            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastra um pais primeiro poh!!");
                return;
            }

            var linha = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            var paises = _paisService.ObeterPorId(id);
            var paisForm = new EsporteCadastroForm(paises);
            paisForm.ShowDialog();

            PreencherDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var paisesForm = new EsporteCadastroForm();
            paisesForm.ShowDialog();
            PreencherDataGridView();
        }
    }
}
