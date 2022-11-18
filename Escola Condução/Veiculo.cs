using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Condução
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public int NumRoda { get; set; }
        public string Matricula { get; set; }

        internal static void NovoRegistoCarta()
        {
            Console.WriteLine("Indique a categoria : \n1- Mota \n2- Carro \n3- Pesado");
            int escolhaCategoria = int.Parse(Console.ReadLine());
            if (escolhaCategoria == 1)
            {
                Mota.NovoRegistoMota();
            }
            else if (escolhaCategoria == 2)
            {
                Carro.NovoRegistoCarro();
            }
            else
            {
                Pesado.NovoRegistoPesado();
            }
        }
    }
}
