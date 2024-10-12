using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket.Models
{
    public class Something
    {
		private float priceV;

		public float PriceV
		{
			get { return priceV; }
			set { priceV = value; }
		}

        private float priceF;

        public float PriceF
        {
            get { return priceF; }
            set { priceF = value; }
        }

		private int kgV;

		public int KgV
		{
			get { return kgV; }
			set { kgV = value; }
		}

        private int kgF;

        public int KgF
        {
            get { return kgF; }
            set { kgF = value; }
        }

        public float CalculatePriceV()
        {
            return this.PriceV * this.KgV;
        }

        public float CalculatePriceF()
        {
            return this.PriceF * this.KgF;
        }

        public float CalculateTotalPriceInEuro()
        {
            return (this.CalculatePriceV() + this.CalculatePriceF()) /(float) 1.94;
        }

        public Something()
        {

        }
        public Something(float priceV,float priceF,int kgV,int kgF)
        {
            this.PriceV = priceV;
            this.PriceF = priceF;
            this.KgV = kgV;
            this.kgF = kgF;
        }
    }
}
