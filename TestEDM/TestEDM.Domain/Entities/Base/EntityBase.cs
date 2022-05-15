using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEDM.Domain.Entities.Base
{
    public class EntityBase
    {

        public virtual int Id { get; set; }
        public virtual DateTime DataAlteracao { get; set; }
    }
}
