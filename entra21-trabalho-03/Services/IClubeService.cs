using entra21_trabalho_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entra21_trabalho_03.Services
{
    internal interface IClubeService
    {
        List<Clube> ObterTodos();
        Clube ObterPorId(int id);
        void Cadastrar(Clube clube);
        void Editar (Clube clube);
        void Apagar(int id);
    }
}
