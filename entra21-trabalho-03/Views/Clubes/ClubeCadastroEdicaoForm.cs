using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entra21_trabalho_03.Views.Clubes
{
    public partial class ClubeCadastroEdicaoForm : Form
    {
        private readonly int _idEditar;
        public ClubeCadastroEdicaoForm()
        {
            InitializeComponent();

            _idEditar = -1;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNomeClube.Text.Trim();
            var cidadeSede = textBoxCidadeSede.Text.Trim();
            var dataFundacao = Convert.ToDateTime(dateTimePickerAnoFundacao.Text);

            // if (ValidarDados() == false)
            //    return;
            var clube = new Clube();
            clube.Nome = nome;
            clube.CidadeSede = cidadeSede;
            clube.AnoFundacao = dataFundacao;

            var clubeService = new ClubeService();

            if(_idEditar ==-1)
            {
                clubeService.Cadastrar(clube);
                MessageBox.Show("Clube cadastrado com sucesso!");
                Close();
            }
            else
            {
                clube.Id = _idEditar;
                clubeService.Editar(clube);
                MessageBox.Show("Clube editado com sucesso!");
                Close();
            }


        }
    }
}
