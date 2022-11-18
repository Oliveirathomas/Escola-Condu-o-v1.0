using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Condução
{
    public class Carro : Veiculo 
    {
        public int Id { get; set; }

        internal static void NovoRegistoCarro()
        {
            Console.WriteLine("Categoria B permite condução veiculos 4 rodas etc..");
            Program.MenuInicial();
        }

    }
}
