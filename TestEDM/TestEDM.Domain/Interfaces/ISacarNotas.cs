using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEDM.Domain.Entities;

namespace TestEDM.Interfaces
{
    public interface ISacarNotas
    {
        public Notas Saque(int valor);
    }
}
