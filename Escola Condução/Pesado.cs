using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Condução
{
    public class Pesado : Veiculo
    {
        public int Id { get; set; }
        public bool Reboque { get; set; }

        internal static void NovoRegistoPesado()
        {
            Pesado novo = new Pesado();
            Console.WriteLine("Categoria C que permite a utilização de reboque. Prentende usar reboque ? True ou False ");
            novo.Reboque = Convert.ToBoolean(Console.ReadLine());
            if (novo.Reboque == true)
            {
                Console.WriteLine("Categoria CE");
                Program.MenuInicial();
            }
            else
            {
                Console.WriteLine("Categoria C");
                Program.MenuInicial();
            }
        }
    }
}
