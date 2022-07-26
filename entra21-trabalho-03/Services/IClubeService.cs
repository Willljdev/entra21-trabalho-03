using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IClubeService
    {
        List<Clube> ObterTodos();
        Clube ObterPorId(int id);
        void Cadastrar(Clube clube);
        void Editar (Clube clube);
        void Apagar(int id);
    }
}
