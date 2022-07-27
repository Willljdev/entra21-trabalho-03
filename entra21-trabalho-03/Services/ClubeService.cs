using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.Models;
using System.Data;
using System.Data.SqlClient;

namespace entra21_trabalho_03.Services
{
    internal class ClubeService : IClubeService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM clubes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Clube clube)
        {
            var conexao = new Conexao().Conectar();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO clubes (clube) VALUES (@CLUBE)";
            comando.Parameters.AddWithValue("@CLUBE", clube.Nome);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Clube clube)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE clubes SET clube = @CLUBE WHERE id= @ID";
            comando.Parameters.AddWithValue("@CLUBE", clube.Nome);
            comando.Parameters.AddWithValue("@ID", clube.Id);

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public Clube ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, cidade_sede FROM clubes WHERE id= @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var clube = new Clube();
            clube.Id = Convert.ToInt32(primeiroRegistro["id"]);
            clube.Nome = primeiroRegistro["nome"].ToString();
            clube.CidadeSede = primeiroRegistro["cidade_sede"].ToString();

            comando.Connection.Close();

            return clube;
        }

        public List<Clube> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, cidade_sede FROM clubes";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var clubes = new List<Clube>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];
                var clube = new Clube();
                clube.Id = Convert.ToInt32(linha["id"].ToString());
                clube.Nome = linha["nome"].ToString();
                clube.CidadeSede = linha["cidade_sede"].ToString();

                clubes.Add(clube);
            }
            comando.Connection.Close();
            return clubes;
        }
    }
}
