using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEDM.Domain.Interfaces;
using TestEDM.Interfaces;
using TestEDM.Shared.Enum;
using TestEDM.Shared.Exceptions;

namespace TestEDM
{
    public class Menu : IMenu
    {
        private readonly ISacarNotas _sacarNotas;
        private readonly IAdicionarNotas _adicionarNotas;
        public Menu(ISacarNotas sacarNotas, IAdicionarNotas adicionarNotas)
        {
            _sacarNotas = sacarNotas;
            _adicionarNotas = adicionarNotas;
        }

        public void MenuCaixa()
        {

            int opcao = 0;
            while (opcao != 3)
            {
                OpcoesMenu();
                int.TryParse(Console.ReadLine(), out opcao);
                switch (opcao)
                {
                    case 1:
                        SaqueMenu();

                        break;
                    case 2:
                        DepositoMenu();
                        break;
                    default:
                        Console.WriteLine("Opção invalida, tente novamente!");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }

        }
        private void OpcoesMenu()
        {
            Console.WriteLine("Caixa Eletronico\n\n");
            Console.WriteLine("1 - Saque \n");
            Console.WriteLine("2 - Adicionar Notas \n");
            Console.WriteLine("3 - Sair \n");
        }
        private void SaqueMenu()
        {
            Console.Clear();
            var valor = 0;
            Console.WriteLine("Digite o valor para saque: ");
            int.TryParse(Console.ReadLine(), out valor);
            try
            {
                var notasExtraidas = _sacarNotas.Saque(valor);
                Console.WriteLine("Retirando:");
                Console.WriteLine($"{notasExtraidas.NotasDeCem} notas de R$100");
                Console.WriteLine($"{notasExtraidas.NotasDeCinquenta} notas de R$50");
                Console.WriteLine($"{notasExtraidas.NotasDeVinte} notas de R$20");
                Console.WriteLine($"{notasExtraidas.NotasDeDez} notas de R$10");
            }
            catch (SaldoCaixaException)
            {

                Console.WriteLine("Notas insuficiente para realizar o saque"); ;
            }
            Console.WriteLine("Aperte enter para continuar...");

        }

        private void DepositoMenu()
        {
            int opcao;
            Console.Clear();
            Console.WriteLine("Selecione a nota que deseja depositar:");
            Console.WriteLine("1 - R$100 \n");
            Console.WriteLine("2 - R$50 \n");
            Console.WriteLine("3 - R$20 \n");
            Console.WriteLine("4 - R$10 \n");
            Console.WriteLine("5 - Sair \n");
            int.TryParse(Console.ReadLine(), out opcao);
            if(opcao != 5) AdicionarNotas(opcao);
            Console.WriteLine("Aperte enter para continuar...");
        }

        private void AdicionarNotas(int opcao)
        {
            Console.Clear();
            int quantidade;
            Console.WriteLine("Insira a quantidade de notas:");
            int.TryParse(Console.ReadLine(), out quantidade);


            switch (opcao)
            {
                case 1:
                    _adicionarNotas.Adicionar(quantidade, TipoNota.cem);
                    break;
                case 2:
                    _adicionarNotas.Adicionar(quantidade, TipoNota.cinquenta);
                    break;
                case 3:
                    _adicionarNotas.Adicionar(quantidade, TipoNota.vinte);
                    break;
                case 4:
                    _adicionarNotas.Adicionar(quantidade, TipoNota.dez);
                    break;
                default:
                    break;


            }

        }
    }
}
