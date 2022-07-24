using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IPosicaoService
    {
        void Cadastrar(Posicao posicao);
        void Apagar(int id);
        void Editar(Posicao posicao);
        Posicao ObterPorId(int id);
        List<Posicao> ObterTodos();
    }
}
