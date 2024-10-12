using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableMarket.Models;
using VegetableMarket.Views;

namespace VegetableMarket.Controllers
{
    public class SomethingActionController
    {
        Display myDsp=new Display();
        Something mySmtg = new Something();

        public SomethingActionController()
        {
            myDsp.Input();
            mySmtg.PriceV = myDsp.PriceV;
            mySmtg.PriceF = myDsp.PriceF;
            mySmtg.KgV = myDsp.KgV;
            mySmtg.KgF=myDsp.KgF;
            myDsp.CalculatePriceV = mySmtg.CalculatePriceV();
            myDsp.CalculatePriceF = mySmtg.CalculatePriceF();
            myDsp.CalculateTotalPriceInEuro=mySmtg.CalculateTotalPriceInEuro();
            myDsp.Output();
        }
    }
}
