using HomeworkImplicit.Models;
using System;

namespace HomeworkImplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            double Exchange(Currecy currecy, double azn)
            {
                double result = 0;
                if (currecy == Models.Currecy.Eur)
                {
                    result = azn * 0.49;
                }
                if (currecy == Models.Currecy.Usd)
                {
                    result = azn * 0.59;
                }
                if (currecy == Models.Currecy.Try)
                {
                    result = azn * 8.7;
                }

                return result;
            }
            Console.WriteLine(Exchange(Currecy.Try,45));
        }
    }
}
