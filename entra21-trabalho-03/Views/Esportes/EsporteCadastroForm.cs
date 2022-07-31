using entra21_trabalho_03.EsportesCompeticoes.Models;
using entra21_trabalho_03.EsportesCompeticoes.Services;
using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Views.Paises
{
    public partial class EsporteCadastroForm : Form
    {
        private int id = -1;
        public EsporteCadastroForm()
        {
            InitializeComponent();
        }

        public EsporteCadastroForm(Esporte esportes) : this()
        {
            id = esportes.Id;
            textBoxNome.Text = esportes.Nome;
            textBoxQuantidadesJogadoresTime.Text = esportes.QuantidadesJogadoresTime.ToString();
            textBoxQuantidadeAtletaClube.Text = esportes.QuantidadesAtletasClube.ToString();
            textBoxLocalPraticado.Text = esportes.LocalPraticado;

            for (var i = 0; i < comboBoxClube.Items.Count; i++)
            {
                var clubePercorrido = comboBoxClube.Items[i] as Clube;
                if (clubePercorrido.Id == esportes.Clube.Id)
                {
                    comboBoxClube.SelectedItem = clubePercorrido;
                    break;
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var quantidadeJogadoresTime = textBoxQuantidadesJogadoresTime.Text.Trim();
            var quantidadeAtletasClube = textBoxQuantidadeAtletaClube.Text.Trim();
            var localPraticado = textBoxLocalPraticado.Text.Trim();
            var clube = comboBoxClube.SelectedItem as Clube;

            if (nome.Length < 3 || nome.Length > 50)
            {
                MessageBox.Show("Digita um nome descente ai fio");
                textBoxNome.ResetText();
                textBoxNome.Focus();
                return;
            }

            if (quantidadeJogadoresTime.Length < 3 || quantidadeJogadoresTime.Length > 50)
            {
                MessageBox.Show("Digita um continente maior ai");
                textBoxQuantidadesJogadoresTime.ResetText();
                textBoxQuantidadesJogadoresTime.Focus();
                return;
            }
            if (quantidadeAtletasClube.Length < 10 || quantidadeAtletasClube.Length > 150)
            {
                MessageBox.Show("Digita um numero de atleta valido ai!!");
                textBoxQuantidadeAtletaClube.ResetText();
                textBoxQuantidadeAtletaClube.Focus();
            }
            if(localPraticado.Length < 3 || localPraticado.Length > 50)
            {
                MessageBox.Show("Digite um local praticado valido fi");
                textBoxLocalPraticado.ResetText();
                textBoxLocalPraticado.Focus();
            }
            var esportes = new Esporte();
            esportes.Nome = nome;
            esportes.QuantidadesJogadoresTime = Convert.ToInt32(quantidadeJogadoresTime);
            esportes.QuantidadesAtletasClube = Convert.ToInt32(quantidadeAtletasClube);
            esportes.LocalPraticado = localPraticado;

            var esporteService = new EsporteService();
            if (id == -1)
            {
                esporteService.Cadastrar(esportes);
                MessageBox.Show("Cadastrados com sucessos!!");
                Close();
                return;
            }

            esportes.Id = id;
            esporteService.Editar(esportes);
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
