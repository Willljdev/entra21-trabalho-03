namespace entra21_trabalho_03.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public Posicao Posicao { get; set; }
        public Clube Clube { get; set; }
    }
}
