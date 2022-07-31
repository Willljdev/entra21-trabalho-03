using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.EsportesCompeticoes.Models;
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

            comando.CommandText = 
                @"INSERT INTO competicoes (nome, data_inicio, data_termino, id_pais)
                VALUES (@NOME, @DATA_INICIO, @DATA_TERMINO, @ID_PAIS);";

            comando.Parameters.AddWithValue("@NOME", competicao.Nome);
            comando.Parameters.AddWithValue("@DATA_INICIO", competicao.DataInicio);
            comando.Parameters.AddWithValue("@DATA_TERMINO", competicao.DataTermino);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Editar(Competicao competicao)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = 
                @"UPDATE competicoes SET nome = @NOME,
                                         data_inicio = @DATA_INICIO,
                                         data_termino = @DATA_TERMINO,
                                         id_pais = @ID_PAIS WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", competicao.Id);
            comando.Parameters.AddWithValue("@NOME", competicao.Nome);
            comando.Parameters.AddWithValue("@DATA_INICIO", competicao.DataInicio);
            comando.Parameters.AddWithValue("@DATA_TERMINO", competicao.DataTermino);
            comando.Parameters.AddWithValue("@ID_PAIS", competicao.Pais.Id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public Competicao ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = 
                "SELECT id, nome, data_inicio, data_termino, id_pais FROM competicoes WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var tabelaemmemoria = new DataTable();
            tabelaemmemoria.Load(comando.ExecuteReader());

            if (tabelaemmemoria.Rows.Count == 0)
                return null;

            var registro = tabelaemmemoria.Rows[0];
            var competicoes = new Competicao();
            competicoes.Id = Convert.ToInt32(registro["id"]);
            competicoes.Nome = registro["nome"].ToString();
            competicoes.DataInicio = Convert.ToDateTime(registro["data_inicio"]);
            competicoes.DataTermino = Convert.ToDateTime(registro["data_termino"]);

            
            comando.Connection.Close();

            return competicoes;
            
        }

        public List<Competicao> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            
            comando.CommandText = @"SELECT 
c.id AS 'id',
c.nome AS 'nome',
c.data_inicio AS 'data_inicio',
c.data_termino AS 'data_termino',
p.id AS 'id_pais',
p.nome AS 'pais_nome',
p.continente AS 'continente_pais'
FROM clubes AS c
INNER JOIN paises AS p ON(c.id_pais = p.id);";

            var tabelaMemoria = new DataTable();
            tabelaMemoria.Load(comando.ExecuteReader());

            var competicoes = new List<Competicao>();
            for (var i = 0; i < tabelaMemoria.Rows.Count; i++)
            {
                var registro = tabelaMemoria.Rows[i];
                var competicao = new Competicao();

                competicao.Id = Convert.ToInt32(registro["id"]);
                competicao.Nome = registro["nome"].ToString();
                competicao.DataInicio = Convert.ToDateTime(registro["data_inicio"]);
                competicao.DataTermino = Convert.ToDateTime(registro["data_termino"]);

                competicao.Pais.Id = Convert.ToInt32(registro["id_pais"]);
                competicao.Pais.Nome = registro["pais_nome"].ToString();
                competicao.Pais.Continente = registro["continente_pais"].ToString();

                competicoes.Add(competicao);
            }
            return competicoes;
        }
    }
}
