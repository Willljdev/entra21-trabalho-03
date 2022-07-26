using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface ITecnicoService
    {
        List<Tecnico> ObterTodos();
        Tecnico ObterPorId(int id);
        void Cadastrar(Tecnico tecnico);
        void Editar(Tecnico tecnico);
        void Apagar(int id);

    }
}
