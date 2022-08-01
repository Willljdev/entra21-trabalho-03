using entra21_trabalho_03.EsportesCompeticoes.Models;
using entra21_trabalho_03.EsportesCompeticoes.Services;
using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Paises
{
    public partial class EsporteCadastroForm : Form
    {
        private readonly int _idEditar;
        private readonly TecnicoService _tecnicoService;
        public EsporteCadastroForm()
        {
            InitializeComponent();
            _tecnicoService = new TecnicoService();
            PreencherComboBox();
            BotoesTransparentes();
            _idEditar = -1;
        }

        public EsporteCadastroForm(Esporte esportes) : this()
        {
            _idEditar = esportes.Id;
            textBoxNome.Text = esportes.Nome;
            numericUpDownJogadores.Text = esportes.QuantidadesJogadoresTime.ToString();
            numericUpDownClube.Text = esportes.QuantidadesAtletasClube.ToString();
            textBoxLocalPraticado.Text = esportes.LocalPraticado;

            for (var i = 0; i < comboBoxTecnico.Items.Count; i++)
            {
                var clubePercorrido = comboBoxTecnico.Items[i] as Clube;
                if (clubePercorrido.Id == esportes.Tecnico.Id)
                {
                    comboBoxTecnico.SelectedItem = clubePercorrido;
                    break;
                }
            }
        }

        private void PreencherComboBox()
        {
            var tecnicos = _tecnicoService.ObterTodos();

            for (var i = 0; i < tecnicos.Count; i++)
            {
                var tecnico = tecnicos[i];
                comboBoxTecnico.Items.Add(tecnico);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var tecnico = comboBoxTecnico.SelectedItem as Tecnico;

            if (ValidarDados() == false)
                return;

            var esportes = new Esporte();
            esportes.Nome = textBoxNome.Text.Trim();
            esportes.QuantidadesJogadoresTime = Convert.ToInt32(numericUpDownJogadores.Value);
            esportes.QuantidadesAtletasClube = Convert.ToInt32(numericUpDownClube.Value);
            esportes.LocalPraticado = textBoxLocalPraticado.Text.Trim();
            esportes.Tecnico = tecnico;

            var esporteService = new EsporteService();

            if (_idEditar == -1)
            {
                esporteService.Cadastrar(esportes);
                MessageBox.Show("Cadastrados com sucessos!!");
                Close();
                return;
            }

            esportes.Id = _idEditar;
            esporteService.Editar(esportes);
            MessageBox.Show("Alterados!!");
            Close();
        }

        private bool ValidarDados()
        {
            if (textBoxNome.Text.Length < 3 || textBoxLocalPraticado.Text.Length > 50)
            {
                MessageBox.Show("Digita um nome descente ai fio");
                textBoxNome.ResetText();
                textBoxNome.Focus();
                return false;
            }

            if (numericUpDownJogadores.Value < 3)
            {
                MessageBox.Show("Digita uma quantidade de jogadores maior ai");
                numericUpDownJogadores.ResetText();
                numericUpDownJogadores.Focus();
                return false;
            }
            if (numericUpDownClube.Value < 10)
            {
                MessageBox.Show("Digita um numero de atleta valido ai!!");
                numericUpDownClube.ResetText();
                numericUpDownClube.Focus();
            }
            if (textBoxLocalPraticado.Text.Length < 3 || textBoxLocalPraticado.Text.Length > 50)
            {
                MessageBox.Show("Digite um local praticado valido fi");
                textBoxLocalPraticado.ResetText();
                textBoxLocalPraticado.Focus();
                return false;
            }
            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {

        }

        private void BotoesTransparentes()
        {
            buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSalvar.FlatAppearance.BorderSize = 0;
            buttonSalvar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSalvar.BackColor = Color.Transparent;

            buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCancelar.BackColor = Color.Transparent;
        }
    }
}
