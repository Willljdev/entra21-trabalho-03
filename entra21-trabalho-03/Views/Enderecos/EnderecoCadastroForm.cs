﻿using entra21_trabalho_03.Models;
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
            BotoesTransparentes();

            EnderecosSelecionados();
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
            var bairro = textBoxBairro.Text;
            var estado = textBoxSigla.Text;
            var rua = textBoxRua.Text;

            var dadosValidos = ValidarDados(cep, enderecoCompleto, cidade, bairro, estado, rua);


            if (dataGridView1.SelectedRows.Count == 0)

                CadastrarEndereco(cep, enderecoCompleto, cidade, bairro, estado, rua);

            else
                EditarEndereco(cep, enderecoCompleto, cidade, bairro, estado, rua);

            EnderecosSelecionados();

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
            maskedTextBoxCep.ResetText();
            textBoxEnderecoCompleto.ResetText();
            textBoxCidade.ResetText();
            textBoxBairro.ResetText();
            textBoxSigla.ResetText();
            textBoxRua.ResetText();

            dataGridView1.ClearSelection();
        }

        private void EnderecosSelecionados()
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
                    endereco.Cidade,
                    endereco.Bairro,
                    endereco.Estado,
                    endereco.Rua,
                });
            }
        }


        private void CadastrarEndereco(string cep, string enderecoCompleto, string cidade, string bairro, string estado, string rua)
        {
            var endereco = new Endereco();
            endereco.Codigo = EnderecoCadastroService.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cidade = cidade;
            endereco.Bairro = bairro;
            endereco.Estado = estado;
            endereco.Rua = rua;

            EnderecoCadastroService.Adicionar(endereco);
        }

        private void EditarEndereco(string cep, string enderecoCompleto, string cidade, string bairro, string estado, string rua)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionado;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cidade = cidade;
            endereco.Bairro = bairro;
            endereco.Estado = estado;
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
            textBoxCidade.Text = endereco.Cidade;
            textBoxBairro.Text = endereco.Bairro;
            textBoxSigla.Text = endereco.Estado;
            textBoxRua.Text = endereco.Rua;

        }

        private void EnderecosForm_Load(object sender, EventArgs e)
        {
            EnderecosSelecionados();
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
                "Realmente deseja apagar o endereço?", "Aviso",
                MessageBoxButtons.OKCancel);



            if (resposta == DialogResult.Cancel)
                return;

            Endereco endereco = NewMethod();

            EnderecosSelecionados();
            EnderecoCadastroService.Apagar(endereco);

            PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            var enderecos = EnderecoCadastroService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                dataGridView1.Rows.Add(new object[]
                {
                        endereco.Codigo,
                    endereco.Cep,
                    endereco.EnderecoCompleto,
                    endereco.Cidade,
                    endereco.Bairro,
                    endereco.Estado,
                    endereco.Rua,
                });
            }
        }
        private Endereco NewMethod()
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var endereco = EnderecoCadastroService.ObterPorCodigo(codigo);
            return endereco;
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
                textBoxBairro.Text =
                    $"{dadosEndereco.Bairro}";
                textBoxSigla.Text =
                    $"{dadosEndereco.Uf}";
                textBoxCidade.Text =
                    $"{dadosEndereco.Localidade}";
                textBoxRua.Text =
                    $"{dadosEndereco.Logradouro}";

            }
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private void EnderecoCadastroFormPreencher(object sender, EventArgs e)
        {
            EnderecosSelecionados();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var cidade = textBoxCidade.Text;
            var estado = textBoxSigla.Text;
            var rua = textBoxRua.Text;
            var bairro = textBoxBairro.Text;



            if (dataGridView1.SelectedRows.Count == 0)
                CadastrarEndereco(cep, enderecoCompleto, cidade, estado, rua, bairro);
            else
                EditarEndereco(cep, enderecoCompleto, cidade, estado, rua, bairro);

            EnderecosSelecionados();

            LimparCampos();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool ValidarDados(string cep, object endereco)
        {
            try
            {
                if (endereco == "")
                {
                    MessageBox.Show("Selecione um endereço");

                    textBoxEnderecoCompleto.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);

                textBoxEnderecoCompleto.Focus();
                return false;
            }
            return true;
        }

        private void textBoxEnderecoCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonLimpar_Click_1(object sender, EventArgs e)
        {
            maskedTextBoxCep.ResetText();
            textBoxEnderecoCompleto.ResetText();
            textBoxCidade.ResetText();
            textBoxBairro.ResetText();
            textBoxSigla.ResetText();
            textBoxRua.ResetText();
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

            buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLimpar.FlatAppearance.BorderSize = 0;
            buttonLimpar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLimpar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLimpar.BackColor = Color.Transparent;
        }
    }
}
