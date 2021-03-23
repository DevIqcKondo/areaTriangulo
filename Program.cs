using System;

namespace areaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b=0;
            double h=0;
            double result=0;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Calculando a área do triângulo");
            Console.WriteLine("------------------------------");
            Console.Write("Digite o valor da base: ");
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            b=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("Digite o valor da altura: ");
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            h=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            result=(b*h)/2;
           
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.WriteLine("Área= "+result);
            Console.ResetColor();
            Console.Beep();
            
        }
    }
}
