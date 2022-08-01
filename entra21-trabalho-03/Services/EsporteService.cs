using System.Data;
using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.EsportesCompeticoes.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.EsportesCompeticoes.Services
{
    internal class EsporteService : IEsporteService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM esportes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Cadastrar(Esporte esportes)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO esportes (nome, quantidade_jogadores_time, quantidade_atletas_clube,
local_praticado, id_tecnico) VALUES (@NOME, @QUANTIDADE_JOGADORES_TIME, @QUANTIDADE_ATLETAS_CLUBE, @LOCAL_PRATICADO, @ID_TECNICO)";

            comando.Parameters.AddWithValue("@NOME", esportes.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_JOGADORES_TIME", esportes.QuantidadesJogadoresTime);
            comando.Parameters.AddWithValue("@QUANTIDADE_ATLETAS_CLUBE", esportes.QuantidadesAtletasClube);
            comando.Parameters.AddWithValue("@LOCAL_PRATICADO", esportes.LocalPraticado);
            comando.Parameters.AddWithValue("@ID_TECNICO", esportes.Tecnico.Id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Editar(Esporte esportes)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText =
                @"UPDATE esportes SET nome = @NOME, quantidade_jogadores_time = @QUANTIDADE_JOGADORES_TIME,
                quantidade_atletas_clube = @QUANTIDADE_ATLETAS_CLUBE, local_praticado = @LOCAL_PRATICADO,
                id_tecnico = @ID_TECNICO WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", esportes.Id);
            comando.Parameters.AddWithValue("@NOME", esportes.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_JOGADORES_TIME", esportes.QuantidadesJogadoresTime);
            comando.Parameters.AddWithValue("@QUANTIDADE_ATLETAS_CLUBE", esportes.QuantidadesAtletasClube);
            comando.Parameters.AddWithValue("@LOCAL_PRATICADO", esportes.LocalPraticado);
            comando.Parameters.AddWithValue("@ID_TECNICO", esportes.Tecnico.Id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public Esporte ObeterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText =
            @"SELECT id, nome, quantidade_jogadores_time, quantidades_atletas_clube,
            local_praticado, id_tecnico FROM esportes WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];
            var esportes = new Esporte();

            esportes.Id = Convert.ToInt32(registro["id"]);
            esportes.Nome = registro["nome"].ToString();
            esportes.QuantidadesJogadoresTime = Convert.ToInt32(registro["quantidade_jogadores_time"]);
            esportes.QuantidadesAtletasClube = Convert.ToInt32(registro["quantidade_atletas_clube"]);
            esportes.LocalPraticado = registro["local_praticado"].ToString();
            esportes.Tecnico.Id = Convert.ToInt32(registro["id_tecnico"]);

            conexao.Close();
            return esportes;
        }

        public List<Esporte> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
e.id AS 'id',
e.nome AS 'nome',
e.quantidade_jogadores_time AS 'quantidade_jogadores_time',
e.quantidade_atletas_clube AS 'quantidade_atletas_clube',
e.local_praticado AS 'local_praticado',
t.id AS 'tecnico_id',
t.nome AS 'nome_tecnico',
t.cpf AS 'tecnico_cpf',
t.data_nascimento AS 'data_nascimento',
t.cidade_natal AS 'cidade_natal'
FROM esportes AS e
INNER JOIN tecnicos AS t ON(e.id_tecnico = t.id);";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var paises = new List<Esporte>();

            for (var i = 0; i < comando.Parameters.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];
                var esporte = new Esporte();
                esporte.Id = Convert.ToInt32(linha["id"].ToString());
                esporte.Nome = linha["nome"].ToString();
                esporte.QuantidadesJogadoresTime = Convert.ToInt32(linha["quantidade_jogadores_time"]);
                esporte.QuantidadesAtletasClube = Convert.ToInt32(linha["quantidade_atletas_clube"]);
                esporte.LocalPraticado = linha["local_praticado"].ToString();
                esporte.Tecnico.Id = Convert.ToInt32(linha["id_tecnico"]);
                esporte.Tecnico.Nome = linha["nome_tecnico"].ToString();
                esporte.Tecnico.Cpf = linha["cpf"].ToString();
                esporte.Tecnico.DataNascimento = Convert.ToDateTime(linha["data_nascimento"]);
                esporte.Tecnico.CidadeNatal = linha["cidade_natal"].ToString();

                paises.Add(esporte);
            }
            return paises;
        }
    }
}