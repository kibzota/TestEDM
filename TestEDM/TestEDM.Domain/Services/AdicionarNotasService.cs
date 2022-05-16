using TestEDM.Domain.Entities;
using TestEDM.Domain.Interfaces;
using TestEDM.Shared.Enum;

namespace TestEDM.Domain.Services
{
    public class AdicionarNotasService : IAdicionarNotas
    {
        private readonly INotasRepository _notasRepo;
        public AdicionarNotasService(INotasRepository notasRepo)
        {
            _notasRepo = notasRepo;
        }

        public void Adicionar(int quantidade, TipoNota tipoNota)
        {
            var deposito = new Notas();
            switch (tipoNota)
            {
                case TipoNota.dez:
                    deposito.NotasDeDez = quantidade;
                    break;
                case TipoNota.vinte:
                    deposito.NotasDeVinte = quantidade;
                    break;
                case TipoNota.cinquenta:
                    deposito.NotasDeCinquenta = quantidade;
                    break;
                case TipoNota.cem:
                    deposito.NotasDeCem = quantidade;
                    break;
            }
            SalvarDeposito(deposito);

        }

        private void SalvarDeposito(Notas depoisto)
        {
            var novoSaldo = RecalcularSaldo(depoisto);
            _notasRepo.SalvarNotas(novoSaldo);
        }

        private Notas RecalcularSaldo(Notas deposito)
        {
            var saldoAtual = _notasRepo.NotasDisponiveis();
            if (saldoAtual == null) saldoAtual = new Notas();

            var novoSaldo = new Notas
            {
                NotasDeCem = deposito.NotasDeCem + saldoAtual.NotasDeCem,
                NotasDeCinquenta = deposito.NotasDeCinquenta + saldoAtual.NotasDeCinquenta,
                NotasDeVinte = deposito.NotasDeVinte + saldoAtual.NotasDeVinte,
                NotasDeDez = deposito.NotasDeDez + saldoAtual.NotasDeDez
            };
            return novoSaldo;
        }
    }
}
