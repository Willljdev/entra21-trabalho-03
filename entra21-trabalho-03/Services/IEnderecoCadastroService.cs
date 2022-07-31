using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IEnderecoCadastroService
    {

        void Adicionar(Endereco endereco);

        void Editar(Endereco enderecoParaAlterar);

        void Apagar(Endereco enderecoParaApagar);

        List<Endereco> ObterTodos();

        Endereco ObterPorCodigo(int codigo);

        int ObterUltimoCodigo();

        void SalvarArquivo();

        void LerArquivo();
    }
}
