namespace entra21_trabalho_03.EsportesCompeticoes.Models
{
    public class Competicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public Esporte Esporte { get; set; }
    }
}
