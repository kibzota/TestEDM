using TestEDM.Domain.Entities;
using TestEDM.Domain.Interfaces;
using TestEDM.Interfaces;
using TestEDM.Shared.Enum;
using System;
using TestEDM.Shared.Exceptions;

namespace TestEDM.Domain.Services
{

    public class SacarNotasService : ISacarNotas
    {
        private readonly INotasRepository _notasRepository;

        public SacarNotasService(INotasRepository notasRepository)
        {
            _notasRepository = notasRepository;
        }


        public Notas Saque(int valorRequerido)
        {

            var notasNoCaixa = _notasRepository.NotasDisponiveis();
            var notasExtraidas = new Notas();
            var saldoSuficiente = notasNoCaixa != null && CalculaValorTotalCaixa(notasNoCaixa) >= valorRequerido && valorRequerido>0;

            if (saldoSuficiente)
            {
                var notas100 = CalculaQuantidadeNotas(valorRequerido, TipoNota.cem);
                notasExtraidas.NotasDeCem = notasNoCaixa.NotasDeCem >= notas100 ? notas100 : notasNoCaixa.NotasDeCem;
                valorRequerido -= (notasExtraidas.NotasDeCem * 100);

                var notas50 = CalculaQuantidadeNotas(valorRequerido, TipoNota.cinquenta);
                notasExtraidas.NotasDeCinquenta = notasNoCaixa.NotasDeCinquenta >= notas50 ? notas50 : notasNoCaixa.NotasDeCinquenta;
                valorRequerido -= (notasExtraidas.NotasDeCinquenta * (int)TipoNota.cinquenta);


                var notas20 = CalculaQuantidadeNotas(valorRequerido, TipoNota.vinte);
                notasExtraidas.NotasDeVinte = notasNoCaixa.NotasDeVinte >= notas20 ? notas20 : notasNoCaixa.NotasDeVinte;
                valorRequerido -= (notasExtraidas.NotasDeVinte * (int)TipoNota.vinte);


                var notas10 = CalculaQuantidadeNotas(valorRequerido, TipoNota.dez);
                notasExtraidas.NotasDeDez = notasNoCaixa.NotasDeDez >= notas20 ? notas10 : notasNoCaixa.NotasDeDez;
                valorRequerido -= (notasExtraidas.NotasDeDez * (int)TipoNota.dez);

            }

            if (notasNoCaixa != null && valorRequerido == 0)
            {
                RegistraNovoSaldo(notasNoCaixa, notasExtraidas);
            }
            else
            {
                throw new SaldoCaixaException();
            }



            return notasExtraidas;
        }


        private void RegistraNovoSaldo(Notas notasNoCaixa, Notas notasExtraidas)
        {
            var novoSaldo = new Notas()
            {
                NotasDeCem = notasNoCaixa.NotasDeCem - notasExtraidas.NotasDeCem,
                NotasDeCinquenta = notasNoCaixa.NotasDeCinquenta - notasExtraidas.NotasDeCinquenta,
                NotasDeVinte = notasNoCaixa.NotasDeVinte - notasExtraidas.NotasDeVinte,
                NotasDeDez = notasNoCaixa.NotasDeDez - notasExtraidas.NotasDeDez
            };
            _notasRepository.SalvarNotas(novoSaldo);
        }

        private int CalculaQuantidadeNotas(int valor, TipoNota tipoNota)
        {
            return valor / (int)tipoNota;
        }
        private int CalculaValorTotalCaixa(Notas notascaixa)
        {
            return (notascaixa.NotasDeCem * (int)TipoNota.cem) + (notascaixa.NotasDeCinquenta * (int)TipoNota.cinquenta)
                    + (notascaixa.NotasDeVinte * (int)TipoNota.vinte) + (notascaixa.NotasDeDez * (int)TipoNota.dez);
        }
    }


}
