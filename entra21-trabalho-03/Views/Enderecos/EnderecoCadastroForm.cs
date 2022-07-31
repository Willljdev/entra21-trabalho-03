using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;
using Newtonsoft.Json;

namespace entra21_trabalho_03.Views.Enderecos
{
    public partial class EnderecoCadastroForm : Form
    {
        private readonly EnderecoCadastroService EnderecoCadastroService;
        public EnderecoCadastroForm()
        {
            InitializeComponent();

            EnderecoCadastroService = new EnderecoCadastroService();

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var cidade = textBoxCidade.Text;
            var estado = textBoxEstado.Text;
            var bairro = textBoxBairro.Text;
            var rua = textBoxRua.Text;

            var dadosValidos = ValidarDados(cep, enderecoCompleto, cidade, bairro, estado, rua);


            if (dataGridView1.SelectedRows.Count == 0)

                CadastrarEndereco(cep, enderecoCompleto, cidade, estado, bairro, rua);

            else
                EditarEndereco(cep, enderecoCompleto, cidade, estado, bairro, rua);

            PreencherDataGridViewComEnderecos();

            LimparCampos();
        }

        private object ValidarDados(string cep, string endereco, string cidade, string bairro, string estado, string rua)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP inválido");

                maskedTextBoxCep.Focus();

                return false;
            }

            if (endereco.Trim().Length < 10)
            {
                MessageBox.Show("Endereço completo deve conter no mínimo 10 caracteres");

                textBoxEnderecoCompleto.Focus();

                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            textBoxEstado.Text = "";
            textBoxRua.Text = "";

            dataGridView1.ClearSelection();
        }

        private void PreencherDataGridViewComEnderecos()
        {
            var enderecos = EnderecoCadastroService.ObterTodos();

            dataGridView1.Rows.Clear();

            dataGridView1.ClearSelection();

            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                dataGridView1.Rows.Add(new object[]
                {
                    endereco.Codigo,
                    endereco.Cep,
                    endereco.Estado,
                    endereco.Cidade,
                    endereco.Bairro,
                    endereco.Rua,
                });
            }
        }


        private void CadastrarEndereco(string cep, string enderecoCompleto, string cidade, string estado, string bairro, string rua)
        {
            var endereco = new Endereco();
            endereco.Codigo = EnderecoCadastroService.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cidade = cidade;
            endereco.Estado = estado;
            endereco.Bairro = bairro;
            endereco.Rua = rua;

            EnderecoCadastroService.Adicionar(endereco);
        }

        private void EditarEndereco(string cep, string enderecoCompleto, string cidade, string estado, string bairro, string rua)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionado;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cep = cep;
            endereco.Cidade = cidade;
            endereco.Estado = estado;
            endereco.Bairro = bairro;
            endereco.Rua = rua;

            EnderecoCadastroService.Editar(endereco);
        }

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para editar");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var endereco = EnderecoCadastroService.ObterPorCodigo(codigo);

            maskedTextBoxCep.Text = endereco.Cep;
            textBoxEnderecoCompleto.Text = endereco.EnderecoCompleto;
            textBoxBairro.Text = endereco.Bairro;
            textBoxCidade.Text = endereco.Cidade;
            textBoxEstado.Text = endereco.Estado;
            textBoxRua.Text = endereco.Rua;
        }

        private void EnderecosForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComEnderecos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para remover");

                return;
            }

            var resposta = MessageBox.Show(
                "realmente Deseja apagar o endereço?", "Aviso",
                MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Apagado com sucesso");

                return;
            }
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "").Trim();

            if (cep.Length != 8)
            {
                return;
            }

            var httpClient = new HttpClient();

            var resultado = httpClient.GetAsync(
                $@"https://viacep.com.br/ws/{cep}/json/").Result;

            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoRequisitado>(resposta);

                textBoxEnderecoCompleto.Text =
                    $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private void EnderecoCadastroFormPreencher(object sender, EventArgs e)
        {
            PreencherDataGridViewComEnderecos();
        }
    }
}
