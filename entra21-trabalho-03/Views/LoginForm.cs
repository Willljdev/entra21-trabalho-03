namespace entra21_trabalho_03.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxLogin.Text.Equals("Grupo003") && textBoxSenha.Text.Equals("Calabresa"))
                {
                    var listarMenu = new MenuPrincipalForm();
                    listarMenu.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Login ou Senha são inválidos!!",
                        "Avisado você foi!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    textBoxLogin.Focus();
                    textBoxSenha.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Aviso DENOVO!",
                    ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void linkLabelSuporte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var enderecoSuporte = "https://www.linkedin.com/in/lucas-perez-86721a242/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = enderecoSuporte;
            System.Diagnostics.Process.Start(psi);
        }

        private void textBoxSenha_Enter(object sender, EventArgs e)
        {
            textBoxSenha.Text = "";
            textBoxSenha.Focus();
        }
    }
}
