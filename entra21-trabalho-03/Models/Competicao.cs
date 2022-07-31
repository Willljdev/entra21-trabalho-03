using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.PaisesCompeticoes.Models
{
    public class Competicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
    }
}
