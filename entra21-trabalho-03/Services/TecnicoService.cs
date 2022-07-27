using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            comando.CommandText = "INSERT INTO tecnicos (nome) VALUES (@NOME)";
            comando.Parameters.AddWithValue("@NOME", tecnico.Id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Tecnico tecnico)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE tecnicos SET nome = @NOME WHERE id= @ID";
            comando.Parameters.AddWithValue("@NOME", tecnico.Nome);
            comando.Parameters.AddWithValue("@CIDADE_NATAL", tecnico.CidadeNatal);
            comando.Parameters.AddWithValue("@ID", tecnico.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Tecnico ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, cidada_natal FROM tecnicos WHERE id= @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var tecnico = new Tecnico();
            tecnico.Id = Convert.ToInt32(primeiroRegistro["id"]);
            tecnico.Nome = primeiroRegistro["nome"].ToString();
            tecnico.Cpf = primeiroRegistro["cpf"].ToString();
            tecnico.DataNascimento = Convert.ToDateTime(primeiroRegistro["data_nascimento"]);
            tecnico.CidadeNatal = primeiroRegistro["cidade_natal"].ToString();
            
            tecnico.Clube = new Clube();
            tecnico.Clube.Id = Convert.ToInt32(primeiroRegistro["id_clube"]);

            conexao.Close();
            return tecnico;
        }

        public List<Tecnico> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
