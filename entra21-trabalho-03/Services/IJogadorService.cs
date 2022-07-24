using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IJogadorService
    {
        void Cadastrar(Jogador jogador);
        void Editar(Jogador jogador);
        void Apagar(int id);
        Jogador ObterPorId(int id);
        List<Jogador> ObterTodos();
    }
}
