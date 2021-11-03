using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            Single.TryParse(Console.
            ReadLine()
            .ToString(), out Single _numeroDigitado);

            if(_numeroDigitado > 0){
                Console.WriteLine("Positivo");
            }
            else if(_numeroDigitado < 0){
                Console.WriteLine("Negativo");
            }
            else{
                Console.WriteLine("Zero");
            }   
        }
    }
}
