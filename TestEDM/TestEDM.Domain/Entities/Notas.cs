using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEDM.Domain.Entities.Base;

namespace TestEDM.Domain.Entities
{
    public class Notas : EntityBase
    {
        public int NotasDeDez { get; private set; }
        public int NotasDeVinte { get; private set; }
        public int NotasDeCinquenta { get; private set; }
        public int NotasDeCem { get; private set; }
    }
}
