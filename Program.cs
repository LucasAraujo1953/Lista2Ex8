using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;

            Console.WriteLine("De tres valores, e a partir deles veremos se forma Triângulo Retangulo");
            Console.Write("Digite o primeiro valor: ");
            A=int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            C = int.Parse(Console.ReadLine());

            if ((Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)) || (Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2)) || (Math.Pow(C, 2) == Math.Pow(B, 2) + Math.Pow(A, 2)))
                Console.WriteLine("É um triangulo retangulo");
            else Console.WriteLine("Não é triangulo retangulo");
        }
    }
}
