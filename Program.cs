using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamamos nossa classe estática, sem precisar instanciar
            Console.WriteLine(Conversor.DolarParaReal(4f) );
            Console.WriteLine(Conversor.RealParaDolar(50f) );
            Console.WriteLine(Conversor.RealParaEuro(50f) );

            //Ex: classe Math
            Console.WriteLine( Math.Pow(2 , 4) );


        }
    }
}
