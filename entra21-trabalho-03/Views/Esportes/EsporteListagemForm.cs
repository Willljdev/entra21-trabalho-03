using entra21_trabalho_03.EsportesCompeticoes.Services;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Paises
{
    public partial class EsporteListagemForm : Form
    {
        private readonly EsporteService _esporteService;
        private readonly ClubeService _clubeService;
        public EsporteListagemForm()
        {
            InitializeComponent();
            _esporteService = new EsporteService();
            _clubeService = new ClubeService();
            PreencherDataGridView();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherDataGridView()
        {
            var esporte = _esporteService.ObterTodos();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < esporte.Count; i++)
            {
                var esportes = esporte[i];
                dataGridView1.Rows.Add(new object[]
                {
                    esportes.Id,
                    esportes.Nome,
                    esportes.QuantidadesJogadoresTime,
                    esportes.QuantidadesAtletasClube,
                    esportes.LocalPraticado
                });
            }
        }


        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            var linha = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            _esporteService.Apagar(id);

            PreencherDataGridView();

            MessageBox.Show("Pais apagado!!");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            var linha = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            var esportes = _esporteService.ObeterPorId(id);
            var esporteForm = new EsporteCadastroForm(esportes);
            esporteForm.ShowDialog();

            PreencherDataGridView();
        }

        private bool ValidarDados()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pais para ser editado!!");
                return false;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastra um pais primeiro poh!!");
                return false;
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um pais pra apagar ai!!");
                return false;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Primeiro cadastra um pais né!!");
                return false;
            }
            return true;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var esportesForm = new EsporteCadastroForm();
            esportesForm.ShowDialog();
            PreencherDataGridView();
        }
    }
}
