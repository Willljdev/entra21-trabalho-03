using entra21_trabalho_03.Models;
using Newtonsoft.Json;

namespace entra21_trabalho_03.Services
{
    internal class EnderecoCadastroService : IEnderecoCadastroService
    {
        private List<Endereco> enderecos;

        public EnderecoCadastroService()
        {
            enderecos = new List<Endereco>();

            LerArquivo();
        }

        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }

        public void Apagar(Endereco enderecoParaApagar)
        {
            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Codigo == enderecoParaApagar.Codigo)
                {
                    enderecos.Remove(endereco);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public Endereco ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Codigo == codigo)
                    return endereco;
            }

            return null;
        }

        public List<Endereco> ObterTodos()
        {
            return enderecos;
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                ultimoCodigo = endereco.Codigo;
            }
            return ultimoCodigo;
        }

        public void SalvarArquivo()
        {
            var enderecoCadastroEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("enderecoCadastro.json", enderecoCadastroEmJson);
        }
        public void LerArquivo()
        {
            if (File.Exists("enderecoCadastro.json") == false)
                return;

            var enderecoCadastroEmJson = File.ReadAllText("enderecoCadastro.json");
            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecoCadastroEmJson);
        }

        internal Endereco ObterPorLogradouro(string? enderecoLogradouro)
        {
            var localVirgula = enderecoLogradouro.IndexOf(",");
            var logradouro = enderecoLogradouro.Substring(0, localVirgula).Trim();

            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];
                if (endereco.EnderecoCompleto == logradouro) 
                    return endereco;
            }
            return null;
        }
    }
}
