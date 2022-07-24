using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entra21_trabalho_03.DataBase;
using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal class PosicaoService : IPosicaoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            
            comando.CommandText = "DELETE FROM posicoes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Cadastrar(Posicao posicao)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO posicoes (nome) VALUES (@NOME)";
            comando.Parameters.AddWithValue("@NOME", posicao.Nome);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Editar(Posicao posicao)
        {
            throw new NotImplementedException();
        }

        public Posicao ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Posicao> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
