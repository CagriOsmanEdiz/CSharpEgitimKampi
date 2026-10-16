using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekrarKısmı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int burgerPrice= 20;
            int pizzaPrice= 30;
            int pastaPrice= 25;
            int burgerCount= 1;
            int pizzaCount= 1;
            int pastaCount= 3;
            int totalPrice= (burgerPrice * burgerCount) + (pizzaPrice * pizzaCount) + (pastaPrice * pastaCount);
            Console.WriteLine("***** Restoran Menüsü *****");
            Console.WriteLine("1. Pizza");  
            Console.WriteLine("2. Burger");
            Console.WriteLine("3. Pasta");
            Console.WriteLine(pizzaCount + " tane pizza yediniz");
            Console.WriteLine(burgerCount + " tane burger yediniz");
            Console.WriteLine(pastaCount + " tane pasta yediniz");
            Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");
        }
    }
}
