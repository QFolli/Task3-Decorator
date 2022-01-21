using System;
using Decorator.Coffe;
using Decorator.Condiments;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            // HouseBlend с молоком
            Beverage houseblend = new HouseBlend();
            houseblend = new Milk(houseblend);
            Console.WriteLine($"Итого: {houseblend.GetDescription()} - {houseblend.Cost()}");

            // Эспрессо + порцией взбитых сливок
            Beverage espresso = new Espresso();
            espresso = new Whip(espresso);
            Console.WriteLine($"Итого: {espresso.GetDescription()} - {espresso.Cost()}");
        }
    }
}
