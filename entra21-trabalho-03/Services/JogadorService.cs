using System.Data;
using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal class JogadorService : IJogadorService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM jogadores WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Cadastrar(Jogador jogador)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText =
            @"INSERT INTO jogadores (id_posicao, id_clube, nome, cpf, data_nascimento)
            VALUES (@ID_POSICAO, @ID_CLUBE, @NOME, @CPF, @DATA_NASCIMENTO);";

            comando.Parameters.AddWithValue("@ID_POSICAO", jogador.Posicao.Id);
            comando.Parameters.AddWithValue("@ID_CLUBE", jogador.Clube.Id);
            comando.Parameters.AddWithValue("@NOME", jogador.Nome);
            comando.Parameters.AddWithValue("@CPF", jogador.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", jogador.DataNascimento);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Editar(Jogador jogador)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText =
                @"UPDATE jogadores SET id_posicao = @ID_POSICAO,
                id_clube = @ID_CLUBE, nome = @NOME, cpf = @CPF,
                data_nascimento = @DATA_NASCIMENTO WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID_POSICAO", jogador.Posicao.Id);
            comando.Parameters.AddWithValue("@ID_CLUBE", jogador.Clube.Id);
            comando.Parameters.AddWithValue("@NOME", jogador.Nome);
            comando.Parameters.AddWithValue("@CPF", jogador.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", jogador.DataNascimento);
            comando.Parameters.AddWithValue("@ID", jogador.Id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public Jogador ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText =
                @"SELECT id, id_posicao, id_clube, nome, cpf, data_nascimento 
                FROM jogadores WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var tabelaMemoria = new DataTable();
            tabelaMemoria.Load(comando.ExecuteReader());

            if (tabelaMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaMemoria.Rows[0];
            var jogador = new Jogador();
            jogador.Id = Convert.ToInt32(registro["id"]);

            jogador.Posicao = new Posicao();
            jogador.Posicao.Id = Convert.ToInt32(registro["id_posicao"]);

            jogador.Clube = new Clube();
            jogador.Clube.Id = Convert.ToInt32(registro["id_clube"]);

            jogador.Nome = registro["nome"].ToString();

            conexao.Close();
            return jogador;

        }

        public List<Jogador> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
j.id AS 'id',
j.nome AS 'nome',
j.cpf AS 'cpf',
j.data_nascimento AS 'data_nascimento',
p.id AS 'posicao_id',
p.nome AS 'posicao_nome',
c.id AS 'clube_id',
c.nome AS 'clube_nome',
c.cidade_sede AS 'cidade_sede'
FROM jogadores AS j
INNER JOIN posicoes AS p ON(j.id_posicao = p.id)
INNER JOIN clubes AS c ON(j.id_clube = c.id)";

            var tabelaMemoria = new DataTable();
            tabelaMemoria.Load(comando.ExecuteReader());

            var jogadores = new List<Jogador>();
            for (var i = 0; i < tabelaMemoria.Rows.Count; i++)
            {
                var registro = tabelaMemoria.Rows[i];
                var jogador = new Jogador();

                jogador.Id = Convert.ToInt32(registro["id"]);
                jogador.Nome = registro["nome"].ToString();
                jogador.Cpf = Convert.ToInt32(registro["cpf"]);
                jogador.DataNascimento = Convert.ToDateTime(registro["data_nascimento"]);

                jogador.Posicao = new Posicao();
                jogador.Posicao.Id = Convert.ToInt32(registro["posicao_id"]);
                jogador.Posicao.Nome = registro["posicao_nome"].ToString();

                jogador.Clube = new Clube();
                jogador.Clube.Id = Convert.ToInt32(registro["clube_id"]);
                jogador.Clube.Nome = registro["clube_nome"].ToString();
                jogador.Clube.CidadeSede = registro["cidade_sede"].ToString();

                jogadores.Add(jogador);
            }
            return jogadores;
        }
    }
}
