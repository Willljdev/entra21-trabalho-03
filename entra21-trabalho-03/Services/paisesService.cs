using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.PaisesCompeticoes.Models;
using System.Data;

namespace entra21_trabalho_03.PaisesCompeticoes.Services
{
    internal class PaisesService : IPaisService
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

        public void Cadastrar(Paises pais)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO paises (nome, continente) VALUES (@NOME, @CONTINENTE)";
            comando.Parameters.AddWithValue("@NOME", pais.Nome);
            comando.Parameters.AddWithValue("@CONTINENTE", pais.Continente);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Editar(Paises pais)
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

        public Paises ObeterPorId(int id)
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
            var pais = new Paises();

            pais.Id = Convert.ToInt32(registro["id"]);
            pais.Nome = registro["nome"].ToString();
            pais.Continente = registro["continente"].ToString();

            conexao.Close();
            return pais;

        }

        public List<Paises> ObterTodos(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, continente From paises";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var paises = new List<Paises>();

            for(var i = 0; i < comando.Parameters.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];
                var pais = new Paises();
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
