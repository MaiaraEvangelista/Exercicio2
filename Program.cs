using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano atual: ");
            double data1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua data de nascimento: ");
            double data2 = double.Parse(Console.ReadLine());

            double resultado = data1 - data2;

            Console.WriteLine(resultado);

            Console.WriteLine("Converta sua idade em semanas, digite aqui sua idade: ");
            int conversao = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            Console.WriteLine(resultado*48);
            
        }
    }
}
