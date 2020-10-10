using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Fahrenheit;
            double Celsius  = 97;

            Console.Write("Coloque o valor de Fahrenheit");
            Fahrenheit = Double.Parse(Console.ReadLine());

            Celsius = (Fahrenheit - 32) / 1.8; 
            Console.WriteLine(" Fahrenheit para o Celsius = {0}" , Celsius);
            Console.Write("\n");

            Console.WriteLine("click a tecla ENTER para sair");
            Console.ReadKey();
            





            
        }
    }
}
