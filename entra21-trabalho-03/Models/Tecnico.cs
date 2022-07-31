namespace entra21_trabalho_03.Models
{
    public class Tecnico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CidadeNatal { get; set; }
        public Clube Clube { get; set; }
    }
}
