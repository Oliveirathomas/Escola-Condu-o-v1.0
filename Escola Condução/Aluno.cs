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
            Console.WriteLine("1- Consulta singular \n2- Consulta total: ");
            int selecao = int.Parse(Console.ReadLine());
            if (selecao == 1)
            {
                Aluno.MostrarSingular();
            }
            else if (selecao == 2)
            {
                Aluno.MostrarTodos();
            }
            else
            {
                Console.WriteLine("Numero incorrecto.Tente outra vez");
                Aluno.Consulta();
            }
           
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
                    Aluno.MostrarTodos();
                }
                else
                {
                    Console.WriteLine("Numero incorrecto.Tente outra vez");
                    Aluno.Apagar();
                }
                
            }
            Program.MenuInicial();
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Morada: {Morada}, Nif: {Nif}, Idade: {Idade}" ;
        }
       virtual public void Mostrar()
        {
            Console.WriteLine(ToString());
        }
        public static void MostrarSingular()
        {
            Console.WriteLine("Digite Nif"); int nifMostrar = int.Parse(Console.ReadLine()) ;
            
            foreach (Aluno novo in Alunos)
            {
                if (nifMostrar == novo.Nif)
                {
                    Console.WriteLine($"Aluno: {novo}");
                }
            }
            Program.MenuInicial();
        }
        public static void MostrarTodos()
        {
            Console.WriteLine($"Lista aluno/s registado/s: ");
            foreach (Aluno novo in Alunos)
            {
                Console.WriteLine(novo.ToString());
            }
            Program.MenuInicial();
        }
    }
}
