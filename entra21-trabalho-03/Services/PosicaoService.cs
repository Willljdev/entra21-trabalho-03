using System;
using System.Collections.Generic;
using System.Data;
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
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE posicoes SET nome = @NOME WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", posicao.Nome);
            comando.Parameters.AddWithValue("@ID", posicao.Id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public Posicao ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            
            comando.CommandText = "SELECT id, nome FROM posicoes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaMemoria = new DataTable();
            tabelaMemoria.Load(comando.ExecuteReader());

            if (tabelaMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaMemoria.Rows[0];
            var posicao = new Posicao();

            posicao.Id = Convert.ToInt32(registro["id"]);
            posicao.Nome = registro["nome"].ToString();

            conexao.Close();
            return posicao;
        }

        public List<Posicao> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome FROM posicoes";

            var tabelaMemoria = new DataTable();
            tabelaMemoria.Load(comando.ExecuteReader());

            var posicoes = new List<Posicao>();

            for (var i = 0; i < tabelaMemoria.Rows.Count; i++)
            {
                var linha = tabelaMemoria.Rows[i];
                
                var posicao = new Posicao();
                posicao.Id = Convert.ToInt32(linha["id"].ToString());
                posicao.Nome = linha["nome"].ToString();

                posicoes.Add(posicao);
            }
            conexao.Close();

            return posicoes;
        }
    }
}
