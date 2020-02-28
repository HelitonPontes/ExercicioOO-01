using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();

            Console.WriteLine("XXXXXXX Programa 01 XXXXXXXXX");
            Console.WriteLine("-----------------------------");

            char finalizar = 'S';

            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            Console.WriteLine("Deseja finalizar digite N se desejar continuar digite S");
            finalizar = char.Parse(Console.ReadLine());

            while (finalizar == 'S')
            {
                Console.WriteLine("Deseja finalizar digite N se desejar continuar digite S");
                finalizar = char.Parse(Console.ReadLine());


                Console.Write("Digite seu Nome: ");
                a.nome = Console.ReadLine();
                Console.Write("Digite sua Cidade: ");
                a.cidade = Console.ReadLine();
                Console.Write("Digite sua idade: ");
                a.idade = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");

                Console.Write("Digite seu Nome: ");
                b.nome = Console.ReadLine();
                Console.Write("Digite sua Cidade: ");
                b.cidade = Console.ReadLine();
                Console.Write("Digite sua idade: ");
                b.idade = int.Parse(Console.ReadLine());


                Console.WriteLine("");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");

                Console.WriteLine("XXXXXXX Resultado XXXXXXXXX");

                if (a.idade > b.idade)
                {

                    Console.WriteLine(a.nome + " que mora na Cidade: " + a.cidade + " . e mais velha com a idade: " + a.idade);
                }
                else
                {
                    Console.WriteLine(b.nome + " que mora na Cidade: " + b.cidade + " . e mais velha com a idade: " + b.idade);
                }

            }

                Console.ReadKey();

            
            

        }
    }
}
