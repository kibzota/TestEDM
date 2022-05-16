using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEDM.Domain.Interfaces;
using TestEDM.Interfaces;
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
                Console.WriteLine($"{ notasExtraidas.NotasDeCinquenta} notas de R$150");
                Console.WriteLine($"{ notasExtraidas.NotasDeVinte} notas de R$20");
                Console.WriteLine($"{ notasExtraidas.NotasDeDez} notas de R$10");
            }
            catch (SaldoCaixaException)
            {

                Console.WriteLine("Notas insuficiente para realizar o saque"); ;
            }
            Console.WriteLine("Aperte enter para continuar...");

        }

        private void AdicionarNotas()
        {
        }
    }
}
