using entra21_trabalho_03.PaisesCompeticoes.Models;
using entra21_trabalho_03.PaisesCompeticoes.Services;

namespace entra21_trabalho_03.Views.Paises
{
    public partial class PaisCadastroForm : Form
    {
        private int id = -1;
        public PaisCadastroForm()
        {
            InitializeComponent();
        }

        public PaisCadastroForm(Pais paises) : this()
        {
            id = paises.Id;
            textBoxNome.Text = paises.Nome;
            textBoxContinente.Text = paises.Continente;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var continente = textBoxContinente.Text.Trim();

            if(nome.Length < 3 || nome.Length > 50)
            {
                MessageBox.Show("Digita um nome descente ai fio");
                textBoxNome.ResetText();
                textBoxNome.Focus();
                return;
            }

            if(continente.Length < 3 || continente.Length > 50)
            {
                MessageBox.Show("Digita um continente maior ai");
                textBoxContinente.ResetText();
                textBoxContinente.Focus();
                return;
            }

            var pais = new Pais();
            pais.Nome = nome;
            pais.Continente = continente;

            var paisService = new PaisService();
            if(id == -1)
            {
                paisService.Cadastrar(pais);
                MessageBox.Show("Cadastrados com sucessos!!");
                Close();
                return;
            }

            pais.Id = id;
            paisService.Editar(pais);
            MessageBox.Show("Alterados!!");
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
