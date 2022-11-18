using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Condução
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int Nif { get; set; }
        public int Idade { get; set; }
        public static List<Aluno> Alunos = new List<Aluno> ();

        public static void NovoRegisto()
        {
            Aluno novo = new Aluno();
            Console.Write("Digite o seu nome: "  ); novo.Nome = Console.ReadLine();
            Console.Write("Digite a sua morada: "); novo.Morada = Console.ReadLine();
            Console.Write("Digite o seu nif: "); novo.Nif = int.Parse(Console.ReadLine());
            Console.Write("Digite a sua idade: "); novo.Idade = int.Parse(Console.ReadLine());
            Alunos.Add(novo);
            Program.MenuInicial();
        }
        public static void Consulta()
        {
            Console.WriteLine($"Lista aluno/s registado/s: ");
            foreach (Aluno novo in Alunos)
            {
                Console.WriteLine(novo.ToString());
            }
            Program.MenuInicial();
        }
        public static void Apagar()
        {
        
            Console.Write("Indique o nif do aluno a apagar: "); 
            int nifApagar = int.Parse(Console.ReadLine());
            foreach (Aluno novo in Alunos)
            {
                if ( nifApagar == novo.Nif)
                {
                    Alunos.Remove(novo);
                }
            }
            Program.MenuInicial();
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Morada: {Morada}, Nif: {Nif}, Idade: {Idade}" ;
        }
       
    }
}
