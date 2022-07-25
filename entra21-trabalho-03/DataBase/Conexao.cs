using System.Data.SqlClient;

namespace entra21_trabalho_03.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            var conexao = new SqlConnection();
            var nomeBanco = "BancoDados";
            var caminhoCompleto = Directory.GetCurrentDirectory().Substring(0, AppContext.BaseDirectory.LastIndexOf("\\bin"));
            conexao.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminhoCompleto}\DataBase\{nomeBanco}.mdf;Integrated Security=True";
            conexao.Open();
            return conexao;
        }
    }
}
