using System.Data;
using System.Data.SqlClient;
using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal class TecnicoService : ITecnicoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM tecnicos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Tecnico tecnico)
        {
            var conexao = new Conexao().Conectar();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText =
                @"INSERT INTO tecnicos (nome, id_clube, cpf, data_nascimento, cidade_natal)
                VALUES (@NOME, @ID_CLUBE, @CPF, @DATA_NASCIMENTO, @CIDADE_NATAL)";

            comando.Parameters.AddWithValue("@NOME", tecnico.Nome);
            comando.Parameters.AddWithValue("@ID_CLUBE", tecnico.Clube.Id);
            comando.Parameters.AddWithValue("@CPF", tecnico.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", tecnico.DataNascimento);
            comando.Parameters.AddWithValue("@CIDADE_NATAL", tecnico.CidadeNatal);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Tecnico tecnico)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"UPDATE tecnicos SET nome = @NOME,
                                                        id_clube = @ID_CLUBE,
                                                        cpf = @CPF,
                                                        data_nascimento = @DATA_NASCIMENTO,
                                                        cidade_natal = @CIDADE_NATAL WHERE id= @ID";

            comando.Parameters.AddWithValue("@ID", tecnico.Id);
            comando.Parameters.AddWithValue("@NOME", tecnico.Nome);
            comando.Parameters.AddWithValue("@ID_CLUBE", tecnico.Clube.Id);
            comando.Parameters.AddWithValue("@CPF", tecnico.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", tecnico.DataNascimento);
            comando.Parameters.AddWithValue("@CIDADE_NATAL", tecnico.CidadeNatal);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Tecnico ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, id_clube, cpf, data_nascimento, cidada_natal FROM tecnicos WHERE id= @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var tecnico = new Tecnico();
            tecnico.Id = Convert.ToInt32(primeiroRegistro["id"]);
            tecnico.Nome = primeiroRegistro["nome"].ToString();
            tecnico.Cpf = Convert.ToInt32(primeiroRegistro["cpf"]);
            tecnico.DataNascimento = Convert.ToDateTime(primeiroRegistro["data_nascimento"]);
            tecnico.CidadeNatal = primeiroRegistro["cidade_natal"].ToString();

            tecnico.Clube = new Clube();
            tecnico.Clube.Id = Convert.ToInt32(primeiroRegistro["id_clube"]);

            conexao.Close();
            return tecnico;
        }

        public List<Tecnico> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT
t.id AS 'id',
t.nome AS 'nome',
t.cpf AS 'cpf',
t.data.nascimento AS 'data_nascimento',
t.cidade_natal AS 'cidade_natal',
c.id AS 'id_clube',
c.nome AS 'nome_clube',
c.cidade_sede AS 'cidade_sede_clube',
c.ano_fundacao AS 'ano_fundacao_clube'
FROM tecnicos AS t
INNER JOIN clubes AS c ON(t.id_clube = c.id)";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var tecnicos = new List<Tecnico>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];
                var tecnico = new Tecnico();
                tecnico.Id = Convert.ToInt32(registro["id"]);
                tecnico.Nome = registro["nome"].ToString();
                tecnico.Cpf = registro["cpf"].ToString();
                tecnico.DataNascimento = Convert.ToDateTime(registro["data_nascimento"]);
                tecnico.CidadeNatal = registro["cidade_natal"].ToString();

                tecnico.Clube = new Clube();
                tecnico.Clube.Id = Convert.ToInt32(registro["clube_id"]);
                tecnico.Clube.Nome = registro["clube_nome"].ToString();
                tecnico.Clube.CidadeSede = registro["clube_cidade_sede"].ToString();
                tecnico.Clube.AnoFundacao = Convert.ToDateTime(registro["ano_fundacao_clube"]);

                tecnicos.Add(tecnico);
            }
            return tecnicos;
        }
    }
}
