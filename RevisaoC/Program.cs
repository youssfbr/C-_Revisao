using System;
using System.Globalization;

namespace RevisaoC
{
    class Program
    {
        static void Main(string[] args)        {

            int n1 = int.Parse(Console.ReadLine());
            char ch =  char.Parse(Console.ReadLine());
            double n2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
            string[] vect = Console.ReadLine().Split(" ");
            string nome = vect[0];
            char sexo = char.Parse(vect[1]);
            int idade = int.Parse(vect[2]);
            double altura = double.Parse(vect[3], CultureInfo.InvariantCulture);
                        
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));            
        }
    }
}
