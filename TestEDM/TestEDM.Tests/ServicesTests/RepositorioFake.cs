using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEDM.Domain.Entities;
using TestEDM.Domain.Interfaces;

namespace TestEDM.Tests.ServicesTests
{
    class RepositorioFake : INotasRepository
    {
        public Notas? NotasDisponiveis()
        {
            return new Notas()
            {
                NotasDeCem = 2,
                NotasDeCinquenta = 0,
                NotasDeVinte = 0,
                NotasDeDez = 30,
            };
        }

        public void SalvarNotas(Notas notas)
        {
            
        }
    }
}
