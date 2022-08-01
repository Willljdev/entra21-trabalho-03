using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.EsportesCompeticoes.Models
{
    public class Esporte
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int QuantidadesJogadoresTime { get; set; }

        public int QuantidadesAtletasClube { get; set; }

        public string LocalPraticado { get; set; }

        public Tecnico Tecnico { get; set; }
    }
}
