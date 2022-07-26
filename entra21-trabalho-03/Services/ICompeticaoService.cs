using entra21_trabalho_03.PaisesCompeticoes.Models;

namespace entra21_trabalho_03.Services
{
    internal interface ICompeticaoService
    {
        public void Apagar(int id);

        public void Cadastrar(Pais jogador);

        public void Editar(Pais jogador);

        public Pais ObterPorId(int id);

        public List<Pais> ObterTodos();


    }
}
