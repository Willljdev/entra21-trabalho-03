using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.PaisesCompeticoes.Models;
using System.Data;

namespace entra21_trabalho_03.Services
{
    internal class CompeticaoService : ICompeticaoService;
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM competicoes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Cadastrar(Competicao competicoes)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO competicoes (nome, data_inicio, data_termino) " +
                "VALUES (@NOME, @DATA_INICIO, @DATA_TERMINO);";

            comando.Parameters.AddWithValue("@NOME", competicoes.Nome);
            comando.Parameters.AddWithValue("@DATA_INICIO", competicoes.Data_inicio);
            comando.Parameters.AddWithValue("@DATA_TERMINO", competicoes.Data_termino);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Editar(Competicao competicoes)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE competicoes SET nome = @NOME, data_inicio = @DATA_INICIO, data_termino = @DATA_TERMINO";

            comando.Parameters.AddWithValue("@NOME", competicoes.Nome);
            comando.Parameters.AddWithValue("@DATA_INICIO", competicoes.Data_inicio);
            comando.Parameters.AddWithValue("@DATA_TERMINO", competicoes.Data_termino);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        //public Competicao ObterPorId(int id)
        //{
        //    var conexao = new Conexao().Conectar();
        //    var comando = conexao.CreateCommand();

        //    comando.CommandText = "SELECT nome, data_inicio, data_termino FROM competicoes WHERE id = @ID";
        //    comando.Parameters.AddWithValue("@ID", id);

        //    var tabelaEmMemoria = new DataTable();
        //    tabelaEmMemoria.Load(comando.ExecuteReader());

        //    if (tabelaEmMemoria.Rows.Count == 0)
        //        return null;

        //    var registro = tabelaEmMemoria.Rows[0];
        //    var competicoes = new Competicao();
        //    competicoes.Id = Convert.ToInt32(registro["id"]);

        //    competicoes.Pais = new Pais();
        //}

        //public List<Competicao> ObterTodos()
        //{
        //    var lista = new List<Competicao>();
        //}
    }
}
