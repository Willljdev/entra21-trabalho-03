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

            comando.CommandText = @"INSERT INTO clubes (nome, cidade_sede, ano_fundacao)
                VALUES(@NOME, @CIDADE_SEDE, @ANO_FUNDACAO);";
            comando.Parameters.AddWithValue("@NOME", clube.Nome);
            comando.Parameters.AddWithValue("@CIDADE_SEDE", clube.CidadeSede);
            comando.Parameters.AddWithValue("@ANO_FUNDACAO", clube.AnoFundacao);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Clube clube)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText =
                @"UPDATE clubes SET nome = @NOME, cidade_sede = @CIDADE_SEDE, ano_fundacao = @ANO_FUNDACAO WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", clube.Nome);
            comando.Parameters.AddWithValue("@CIDADE_SEDE", clube.CidadeSede);
            comando.Parameters.AddWithValue("@ANO_FUNDACAO", clube.AnoFundacao);
            comando.Parameters.AddWithValue("@ID", clube.Id);

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public Clube ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT id, nome, cidade_sede, ano_fundacao FROM clubes WHERE id= @ID";
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
            clube.AnoFundacao = Convert.ToDateTime(primeiroRegistro["ano_fundacao"]);

            comando.Connection.Close();

            return clube;
        }

        public List<Clube> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, cidade_sede, ano_fundacao FROM clubes";

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
                clube.AnoFundacao = Convert.ToDateTime(linha["ano_fundacao"]);

                clubes.Add(clube);
            }
            comando.Connection.Close();
            return clubes;
        }
    }
}
