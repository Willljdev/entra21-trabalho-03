using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entra21_trabalho_03.Models
{
    internal class Tecnico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CidadeNatal { get; set; }
        public Clube Clube { get; set; }
    }
}
