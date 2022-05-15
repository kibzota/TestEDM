using TestEDM.Domain.Entities;
using TestEDM.Domain.Interfaces;
using TestEDM.Interfaces;

namespace TestEDM.Domain.Services
{

    public class SacarNotasService : ISacarNotas
    {
        private readonly INotasRepository _notasRepository;

        public SacarNotasService(INotasRepository notasRepository)
        {
            _notasRepository = notasRepository;
        }

        public Notas Saque(int valor)
        {
            var notasNoCaixa = _notasRepository.NotasDisponiveis();
            return new Notas();
        }

        private Notas CalcularNotasDeSaque() {
            return new Notas();
        }
    }


}
