namespace entra21_trabalho_03.Views.Enderecos
{
    public partial class EnderecoCadastro : Form
    {
        public EnderecoCadastro()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxEstado.Text = String.Empty;
            textBoxBairro.Text = String.Empty;
            textBoxCidade.Text = String.Empty;
            textBoxRua.Text = String.Empty;
            maskedTextBoxCep.Text = String.Empty;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(maskedTextBoxCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.ConsultaCEP(maskedTextBoxCep.Text.Trim());

                        textBoxBairro.Text = endereco.bairro;
                        textBoxCidade.Text = endereco.cidade;
                        textBoxRua.Text = endereco.end;
                        textBoxEstado.Text = endereco.uf;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um Cep válido!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
