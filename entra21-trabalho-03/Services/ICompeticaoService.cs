using entra21_trabalho_03.PaisesCompeticoes.Models;

namespace entra21_trabalho_03.Services
{
    internal interface ICompeticaoService
    {
         void Apagar(int id);

         void Cadastrar(Competicao competicao);

         void Editar(Competicao competicao);

         Competicao ObterPorId(int id);

         List<Competicao> ObterTodos();


    }
}
