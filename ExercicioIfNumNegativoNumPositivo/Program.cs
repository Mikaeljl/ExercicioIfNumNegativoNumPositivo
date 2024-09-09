using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioIfNumNegativoNumPositivo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int num= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero:");
          
           

            if (num < 0)
            {
                Console.WriteLine("numero negativo");
            }

            else
            {
                Console.WriteLine("numero positivo");
            }
           
        }
    }
}
