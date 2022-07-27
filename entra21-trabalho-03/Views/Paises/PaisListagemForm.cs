using entra21_trabalho_03.PaisesCompeticoes.Services;

namespace entra21_trabalho_03.Views.Paises
{
    public partial class PaisListagemForm : Form
    {
        private readonly PaisService _paisService;
        public PaisListagemForm()
        {
            InitializeComponent();
            _paisService = new PaisService();
            PreencherDataGridView();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PreencherDataGridView()
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
                    paises.Continente
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
        }
    }
}
