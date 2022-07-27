using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IJogadorService
    {
        void Cadastrar(Pais jogador);
        void Editar(Pais jogador);
        void Apagar(int id);
        Pais ObterPorId(int id);
        List<Pais> ObterTodos();
    }
}
