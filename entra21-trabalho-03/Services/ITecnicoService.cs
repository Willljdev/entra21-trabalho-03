using entra21_trabalho_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entra21_trabalho_03.Services
{
    internal interface ITecnicoService
    {
        List<Tecnico> ObterTodos();
        Tecnico ObterPorId(int id);
        void Cadastrar(Tecnico tecnico);
        void Editar(Tecnico tecnico);
        void Apagar(int id);

    }
}
