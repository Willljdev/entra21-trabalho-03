namespace entra21_trabalho_03.EsportesCompeticoes.Models
{
    public class Competicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_inicio { get; set; }
        public DateTime Data_termino { get; set; }
        public Esporte Esportes { get; set; }
    }
}
