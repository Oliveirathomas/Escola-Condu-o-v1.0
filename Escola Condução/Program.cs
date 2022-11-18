using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Condução
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escola Condução Rumos");
            MenuInicial();
        }

        public static void MenuInicial()
        {
            Console.WriteLine("");
            Console.WriteLine("Indique a opção pretendida: \n1- Registo Aluno \n2- Carta Condução " +
                              "\n3- Consulta \n4- Apagar \n5- Sair");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Aluno.NovoRegisto();break;
                case 2: Veiculo.NovoRegistoCarta();break;
                case 3: Aluno.Consulta();break;
                case 4: Aluno.Apagar();break;
                case 5: Console.WriteLine("Até à próxima.");break;
                default:
                    Console.WriteLine("Opção inválida.Selecione outra vez");
                    break;
            }
        }

    }
    
}
