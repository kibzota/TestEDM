using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEDM.Domain.Interfaces;
using TestEDM.Interfaces;

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
            var valor = 0;
            Console.WriteLine("Digite o valor para saque: ");
            int.TryParse(Console.ReadLine(), out valor);
            _sacarNotas.Saque(valor);
        }

        private void AdicionarNotas() 
        { 
        }
    }
}
