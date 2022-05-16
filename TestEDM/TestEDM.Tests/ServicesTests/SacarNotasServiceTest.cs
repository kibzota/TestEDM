using TestEDM.Domain.Entities;
using TestEDM.Domain.Services;
using TestEDM.Shared.Exceptions;
using Xunit;

namespace TestEDM.Tests.ServicesTests
{
    
    public class SacarNotasServiceTest
    {
        [Fact]
        public void SacarNotasDeveRetornarValorCorreto()
        {
            var valorRequirido = 400;

            var repo = new RepositorioFake();
            var service = new SacarNotasService(repo);

            var notasRetiradas = service.Saque(valorRequirido);

            Assert.Equal(2,notasRetiradas.NotasDeCem);
            Assert.Equal(0, notasRetiradas.NotasDeCinquenta);
            Assert.Equal(0, notasRetiradas.NotasDeVinte);
            Assert.Equal(20, notasRetiradas.NotasDeDez);

        }
        [Fact]
        public void SacarNotasDeveRetornarException()
        {
            var valorRequirido = 40000;

            var repo = new RepositorioFake();
            var service = new SacarNotasService(repo);

            var ex = Assert.Throws<SaldoCaixaException>(() => service.Saque(valorRequirido));

            Assert.IsType<SaldoCaixaException>(ex);

        }
    }
}
