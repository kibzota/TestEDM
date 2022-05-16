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
        public int NotasDeDez { get;  set; }
        public int NotasDeVinte { get;  set; }
        public int NotasDeCinquenta { get;  set; }
        public int NotasDeCem { get;  set; }
    }
}
