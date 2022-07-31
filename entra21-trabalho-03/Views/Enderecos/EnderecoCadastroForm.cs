using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;
using Newtonsoft.Json;

namespace entra21_trabalho_03.Views.Enderecos
{
    public partial class EnderecoCadastroForm : Form
    {
        private JogadorService jogadorService;

        private readonly EnderecoCadastroService EnderecoCadastroService;
        
        public EnderecoCadastroForm()
        {
            InitializeComponent();

            EnderecoCadastroService = new EnderecoCadastroService();
            jogadorService = new JogadorService();

            PreencherComboBoxNome();

            PreencherDataGridViewComEnderecos();
        }

        private void PreencherComboBoxNome()
        {
            var jogadores = jogadorService.ObterTodos();
            for(int i = 0; i < jogadores.Count; i++)
            {
                var jogador = jogadores[i];
                comboBoxMorador.Items.Add(jogador);
            }

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

            var dadosValidos = ValidarDados(cep, enderecoCompleto);


            if (dataGridView1.SelectedRows.Count == 0)

                CadastrarEndereco(cep, enderecoCompleto);

            else
                EditarEndereco(cep, enderecoCompleto);

            PreencherDataGridViewComEnderecos();

            LimparCampos();
        }

        private object ValidarDados(string cep, string endereco)
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
            maskedTextBoxCep.ResetText();
            textBoxEnderecoCompleto.ResetText();

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
                    endereco.EnderecoCompleto,
                    endereco.Morador
                }) ;
            }
        }


        private void CadastrarEndereco(string cep, string enderecoCompleto)
        {
            var endereco = new Endereco();
            endereco.Codigo = EnderecoCadastroService.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;

            EnderecoCadastroService.Adicionar(endereco);
        }

        private void EditarEndereco(string cep, string enderecoCompleto)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionado;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cep = cep;

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

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var endereco = EnderecoCadastroService.ObterPorCodigo(codigo);
            EnderecoCadastroService.Apagar(endereco);

            PreencherDataGridViewComEnderecos();
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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;



            if (dataGridView1.SelectedRows.Count == 0)
                CadastrarEndereco(cep, enderecoCompleto) ;
            else
                EditarEndereco(cep,enderecoCompleto);

            PreencherDataGridViewComEnderecos();

            LimparCampos();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
