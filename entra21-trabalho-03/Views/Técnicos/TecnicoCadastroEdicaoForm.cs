using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Técnicos
{
    public partial class TecnicoCadastroEdicaoForm : Form
    {
        private readonly int _idEditar;
        public TecnicoCadastroEdicaoForm()
        {
            InitializeComponent();
            BotoesTransparentes();
            _idEditar = -1;
        }

        public TecnicoCadastroEdicaoForm(Tecnico tecnico) : this()
        {
            _idEditar = tecnico.Id;
            textBoxNomeTecnico.Text = tecnico.Nome;
            maskedTextBoxCpf.Text = tecnico.Cpf;
            dateTimePickerDataNascimento.Value = tecnico.DataNascimento;
            textBoxCidadeNatal.Text = tecnico.CidadeNatal;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNomeTecnico.Text.Trim();
            var cpf = maskedTextBoxCpf.Text.Trim();
            var cidadeNatal = textBoxCidadeNatal.Text.Trim();
            var dataNascimento = Convert.ToDateTime(dateTimePickerDataNascimento.Text);

            if (ValidarDados() == false)
                return;

            var tecnico = new Tecnico();
            tecnico.Nome = nome;
            tecnico.Cpf = cpf;
            tecnico.CidadeNatal = cidadeNatal;
            tecnico.DataNascimento = dataNascimento;

            var tecnicoService = new TecnicoService();

            if (_idEditar == -1)
            {
                tecnicoService.Cadastrar(tecnico);
                MessageBox.Show("Técnico cadastrado com sucesso!");
                Close();
            }
            else
            {
                tecnico.Id = _idEditar;
                tecnicoService.Editar(tecnico);
                MessageBox.Show("Técnico editado com sucesso!");
                Close();
            }


        }
        private bool ValidarDados()
        {
            if (textBoxNomeTecnico.Text.Length < 3 || textBoxNomeTecnico.Text.Length > 25)
            {
                MessageBox.Show("O nome do técnico deve conter de 3 à 25 caracteres!");
                textBoxNomeTecnico.ResetText();
                textBoxNomeTecnico.Focus();
                return false;
            }
            return true;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotoesTransparentes()
        {
            buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCancelar.BackColor = Color.Transparent;

            buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSalvar.FlatAppearance.BorderSize = 0;
            buttonSalvar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSalvar.BackColor = Color.Transparent;
        }
    }
}