using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.PaisesCompeticoes.Models;
using entra21_trabalho_03.Services;
using System.Data;

namespace entra21_trabalho_03.PaisesCompeticoes.Services
{
    internal class PaisService : IPaisService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM paises WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Cadastrar(Pais pais)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO paises (nome, continente) VALUES (@NOME, @CONTINENTE)";
            comando.Parameters.AddWithValue("@NOME", pais.Nome);
            comando.Parameters.AddWithValue("@CONTINENTE", pais.Continente);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Editar(Pais pais)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE paises SET nome, continente WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", pais.Nome);
            comando.Parameters.AddWithValue("@CONTINENTE", pais.Continente);
            comando.Parameters.AddWithValue("@ID", pais.Id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public Pais ObeterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, continente FROM paises WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];
            var pais = new Pais();

            pais.Id = Convert.ToInt32(registro["id"]);
            pais.Nome = registro["nome"].ToString();
            pais.Continente = registro["continente"].ToString();

            conexao.Close();
            return pais;

        }

        public List<Pais> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, continente From paises";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var paises = new List<Pais>();

            for (var i = 0; i < comando.Parameters.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];
                var pais = new Pais();
                pais.Id = Convert.ToInt32(linha["id"].ToString());
                pais.Nome = linha["nome"].ToString();
                pais.Continente = linha["continente"].ToString();

                paises.Add(pais);

            }
            conexao.Close();

            return paises;
        }
    }
}
