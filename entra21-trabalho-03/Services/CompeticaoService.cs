using System.Data;
using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.EsportesCompeticoes.Models;

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
                                         id_esporte = @ID_ESPORTE WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", competicao.Id);
            comando.Parameters.AddWithValue("@NOME", competicao.Nome);
            comando.Parameters.AddWithValue("@DATA_INICIO", competicao.DataInicio);
            comando.Parameters.AddWithValue("@DATA_TERMINO", competicao.DataTermino);
            comando.Parameters.AddWithValue("@ID_PAIS", competicao.Esporte.Id);

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
c.data_inicio AS 'inicio',
c.data_termino AS 'termino',
e.id AS 'id_esporte',
e.nome AS 'nome_esporte',
e.quantidade_jogadores_time AS 'jogadores_time',
e.quantidade_atleta_time AS 'jogadores_clube',
e.local_praticado AS 'local_praticado',
cb.id AS 'id_clube',
cb.nome AS 'nome_clube',
cb.cidade_sede AS 'cidade_sede',
cb.ano_fundacao AS 'ano_fundacao',
t.id AS 'id_tecnico',
t.nome AS 'nome_tecnico',
t.cpf AS 'cpf_tecnico',
t.data_nascimento AS 'nascimento_tecnico',
t.cidade_natal AS 'cidade_natal_tecnico'
FROM competicoes AS c
INNER JOIN esportes AS e ON(c.id_esportes = e.id)
INNER JOIN clubes AS cb ON(e.id_clube = cb.id)
INNER JOIN tecnicos AS t ON(cb.id_tecnico = t.id);";

            var tabelaMemoria = new DataTable();
            tabelaMemoria.Load(comando.ExecuteReader());

            var competicoes = new List<Competicao>();
            for (var i = 0; i < tabelaMemoria.Rows.Count; i++)
            {
                var registro = tabelaMemoria.Rows[i];
                var competicao = new Competicao();

                competicao.Id = Convert.ToInt32(registro["id"]);
                competicao.Nome = registro["nome"].ToString();
                competicao.DataInicio = Convert.ToDateTime(registro["inicio"]);
                competicao.DataTermino = Convert.ToDateTime(registro["termino"]);

                competicao.Esporte.Id = Convert.ToInt32(registro["id_esporte"]);
                competicao.Esporte.Nome = registro["nome_esporte"].ToString();
                competicao.Esporte.QuantidadesJogadoresTime = Convert.ToInt32(registro["jogadores_time"]);
                competicao.Esporte.QuantidadesAtletasClube = Convert.ToInt32(registro["jogadores_clube"]);
                competicao.Esporte.LocalPraticado = registro["local_praticado"].ToString();

                competicao.Esporte.Clube.Id = Convert.ToInt32(registro["id_clube"]);
                competicao.Esporte.Clube.Nome = registro["nome_clube"].ToString();
                competicao.Esporte.Clube.CidadeSede = registro["cidade_sede"].ToString();
                competicao.Esporte.Clube.AnoFundacao = Convert.ToDateTime(registro["ano_fundacao"]);

                competicao.Esporte.Clube.Tecnico.Id = Convert.ToInt32(registro["id_tecnico"]);
                competicao.Esporte.Clube.Tecnico.Nome = registro["nome_tecnico"].ToString();
                competicao.Esporte.Clube.Tecnico.Cpf = registro["cpf_tecnico"].ToString();
                competicao.Esporte.Clube.Tecnico.DataNascimento = Convert.ToDateTime(registro["nascimento_tecnico"]);
                competicao.Esporte.Clube.Tecnico.CidadeNatal = registro["cidade_natal_tecnico"].ToString();

                competicoes.Add(competicao);
            }
            return competicoes;
        }
    }
}
