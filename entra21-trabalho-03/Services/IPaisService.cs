using entra21_trabalho_03.PaisesCompeticoes.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IPaisService
    {
         void Apagar(int id);

         void Cadastrar(Pais pais);

         void Editar(Pais pais);

         Pais ObeterPorId(int id);

         List<Pais> ObterTodos(int id);
    }
}