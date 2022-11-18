using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Condução
{
    public class Mota : Veiculo
    {
        public int Id { get; set; }
        public int Potencia { get; set; }
        public bool SideCar { get; set; }

         public static void NovoRegistoMota()
        {
            Mota nova = new Mota();
            Console.WriteLine("Digite a potência máxima: \n1- 11Kw \n2- 35Kw \n3- Sem limite"); nova.Potencia = int.Parse(Console.ReadLine());
            switch (nova.Potencia)
            {
                case 1: Console.WriteLine("Categoria A1 com limitações até 11Kw");Program.MenuInicial();break;
                case 2: Console.WriteLine("Categoria A2 com limitações ate 35kw");Program.MenuInicial();break;
                case 3: Console.WriteLine("Categoria A. Tem opção de SideCar. Pretende SideCar True ou False ?");
                    nova.SideCar = Convert.ToBoolean(Console.ReadLine());
                    if (nova.SideCar == true)
                    {
                        Console.WriteLine("Categoria A com sidecar");
                    }
                    else
                    {
                        Console.WriteLine("Categoria A sem sidecar");
                    }
                        
                        Program.MenuInicial();break;
                default:
                    Console.WriteLine("Introdução inválida.Tente novamente.");NovoRegistoMota();
                    break;
            }

        }
    }
}
