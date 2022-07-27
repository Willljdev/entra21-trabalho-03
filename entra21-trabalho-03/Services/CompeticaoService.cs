using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.PaisesCompeticoes.Models;
using System.Data;

namespace entra21_trabalho_03.Services
{
    internal class CompeticaoService : ICompeticaoService
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

        public void Cadastrar(Competicao competicao)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO competicoes (nome, data_inicio, data_termino) " +
                "VALUES (@NOME, @DATA_INICIO, @DATA_TERMINO);";

            comando.Parameters.AddWithValue("@NOME", competicao.Nome);
            comando.Parameters.AddWithValue("@DATA_INICIO", competicao.Data_inicio);
            comando.Parameters.AddWithValue("@DATA_TERMINO", competicao.Data_termino);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Editar(Competicao competicao)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE competicoes SET nome = @NOME, data_inicio = @DATA_INICIO, data_termino = @DATA_TERMINO";

            comando.Parameters.AddWithValue("@NOME", competicao.Nome);
            comando.Parameters.AddWithValue("@DATA_INICIO", competicao.Data_inicio);
            comando.Parameters.AddWithValue("@DATA_TERMINO", competicao.Data_termino);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public Pais ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT nome, data_inicio, data_termino FROM competicoes WHERE id = @ID";
            comando.Parameters.AddWithValue("@id", id);

            var tabelaemmemoria = new DataTable();
            tabelaemmemoria.Load(comando.ExecuteReader());

            if (tabelaemmemoria.Rows.Count == 0)
                return null;

            var registro = tabelaemmemoria.Rows[0];
            var competicoes = new Competicao();
            competicoes.Id = Convert.ToInt32(registro["id"]);
            competicoes.Nome = registro["nome"].ToString();
            competicoes.Data_inicio = Convert.ToDateTime(registro["data_inicio"]);
            competicoes.Data_termino = Convert.ToDateTime(registro["data_termino"]);

            comando.Connection.Close();

            return competicoes;
            
        }

        public List<Competicao> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            //Arrumar
            comando.CommandText = @"SELECT
j.id AS 'id'
j.nome AS 'nome'
j.data_inicio AS 'data_inicio'
j.data_termino AS 'data_termino'";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var competicoes = new List<Competicao>();
            for (var i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];
                var competicao = new Competicao();

                competicao.Id = Convert.ToInt32(registro["id"]);
                competicao.Nome = registro["nome"].ToString();
                competicao.Data_inicio = Convert.ToDateTime(registro["data_inicio"]);
                competicao.Data_termino = Convert.ToDateTime(registro["data_termino"]);

                competicoes.Add(competicao);
            }
            return competicoes;
        }
    }
}
