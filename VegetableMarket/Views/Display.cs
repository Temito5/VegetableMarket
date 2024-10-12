using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket.Views
{
    public class Display
    {
        public float PriceV { get; set; }
        public float PriceF { get; set; }
        public int KgV { get; set; }
        public int KgF { get; set; }
        public float CalculatePriceV { get; set; }
        public float CalculatePriceF { get; set; }
        public float CalculateTotalPriceInEuro { get; set; }

        public void Input()
        {
            Console.Write("Цена за килограм зеленчуци:");
            float priceVegetables = float.Parse(Console.ReadLine());
            this.PriceV = priceVegetables;

            Console.Write("Цена за килограм плодове:");
            float priceFruity=float.Parse(Console.ReadLine());
            this.PriceF = priceFruity;

            Console.Write("Общи килограми на зеленчуци:");
            int kgVegetables = int.Parse(Console.ReadLine());
            this.KgV=kgVegetables;

            Console.Write("Общи килограми на плодовете:");
            int kgFruity=int.Parse(Console.ReadLine());
            this.KgF=kgFruity;
        }

        public void Output()
        {
            Console.WriteLine($"Приходите от реколтата в евро са {this.CalculateTotalPriceInEuro} ");
        }
    }
}
