using entra21_trabalho_03.PaisesCompeticoes.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IPaisService
    {
        public void Apagar(int id);

        public void Cadastrar(Pais pais);

        public void Editar(Pais pais);

        public Pais ObeterPorId(int id);

        public List<Pais> ObterTodos(int id);
    }
}