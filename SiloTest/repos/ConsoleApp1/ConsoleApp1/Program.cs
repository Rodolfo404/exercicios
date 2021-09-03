using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            String nome = Console.ReadLine();
            Console.Write($"Olá, {nome}. qual sua idade?"); //$ = interpolação de string
            int idade = 0;
            while (idade == 0)
            { 
            
            try
            {
                idade = Convert.ToInt32(Console.ReadLine());

            }
            catch(FormatException)
            {
                Console.WriteLine("Dado invalido: Digite novamente");
                
            }
            //String idade = Console.ReadLine();
            }
            Console.WriteLine($"Olá {nome} sua idade é: {idade}");
            Console.ReadLine();
        }
    }
}
