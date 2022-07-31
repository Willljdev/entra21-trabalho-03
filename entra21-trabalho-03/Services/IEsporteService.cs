using entra21_trabalho_03.EsportesCompeticoes.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IEsporteService
    {
         void Apagar(int id);

         void Cadastrar(Esporte pais);

         void Editar(Esporte pais);

         Esporte ObeterPorId(int id);

         List<Esporte> ObterTodos();
    }
}