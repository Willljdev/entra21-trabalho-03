using entra21_trabalho_03.PaisesCompeticoes.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IPaisService
    {
        List<Paises> ObterTodos();
        Paises ObterPorId(int id);
        void Cadastrar(Paises clube);
        void Editar(Paises clube);
        void Apagar(int id);
    }
}
