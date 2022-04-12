using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel

            int numero, horas;
            double valorHora, salario;

            //Entrada 
            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Processamento

            salario = valorHora * horas;

            //Saida

            Console.WriteLine($"NUMERO = {numero}");
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}