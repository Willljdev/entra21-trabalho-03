using entra21_trabalho_03.EsportesCompeticoes.Models;
using entra21_trabalho_03.EsportesCompeticoes.Services;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Competicoes
{
    public partial class CompeticaoCadastroForm : Form
    {
        private readonly EsporteService _esporteService;
        private readonly int _idEditar;
        public CompeticaoCadastroForm()
        {
            InitializeComponent();

            _esporteService = new EsporteService();

            PreencherComboBoxEsporte();
            BotoesTransparentes();

            _idEditar = -1;
        }

        public CompeticaoCadastroForm(Competicao competicao) : this()
        {
            _idEditar = competicao.Id;
            textBoxNome.Text = competicao.Nome;
            dateTimePickerDateInicio.Value = Convert.ToDateTime(competicao.DataInicio.ToString("dd/MM/yyyy"));
            dateTimePickerHoraInicio.Value = Convert.ToDateTime(competicao.DataInicio.ToString("HH:mm:ss"));
            dateTimePickerDateTermino.Value = Convert.ToDateTime(competicao.DataTermino.ToString("dd/MM/yyyy"));
            dateTimePickerHoraTermino.Value = Convert.ToDateTime(competicao.DataTermino.ToString("HH:mm:ss"));

            for (var i = 0; i < comboBoxEsportes.Items.Count; i++)
            {
                var esportePercorrido = comboBoxEsportes.Items[i] as Esporte;
                if (esportePercorrido.Id == competicao.Esporte.Id)
                {
                    comboBoxEsportes.SelectedItem = esportePercorrido;
                    break;
                }
            }
        }

        private void PreencherComboBoxEsporte()
        {
            var esportes = _esporteService.ObterTodos();

            for (var i = 0; i < esportes.Count; i++)
            {
                var esporte = esportes[i];
                comboBoxEsportes.Items.Add(esporte);
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var esportes = comboBoxEsportes.SelectedItem as Esporte;

            if (textBoxNome.Text.Length < 3 || textBoxNome.Text.Length > 50)
            {
                MessageBox.Show("Digita um nome maior ai poh!!");
                textBoxNome.ResetText();
                textBoxNome.Focus();
                return;
            }

            var competicao = new Competicao();
            competicao.Nome = textBoxNome.Text.Trim();
            competicao.DataInicio = Convert.ToDateTime(dateTimePickerDateInicio.Value.Date.ToString("dd/MM/yyyy") + " " +
                dateTimePickerHoraInicio.Value.Hour.ToString("HH:mm:ss"));
            competicao.DataTermino = Convert.ToDateTime(dateTimePickerDateTermino.Value.Date.ToString("dd/MM/yyyy") + " " +
                dateTimePickerHoraTermino.Value.Hour.ToString("HH:mm:ss"));
            competicao.Esporte = esportes;

            var competicaoService = new CompeticaoService();

            if(_idEditar == -1)
            {
                competicaoService.Cadastrar(competicao);
                MessageBox.Show("Cadastro da competição realizado");
                Close();
            }
            else
            {
                competicao.Id = _idEditar;
                competicaoService.Editar(competicao);
                MessageBox.Show("Competição cadastrada com sucesso");
                Close();
            }
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
