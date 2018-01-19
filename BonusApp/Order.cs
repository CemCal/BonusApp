using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{


    public class Order
    {
        public DG_BonusProvider Bonus { get; set; }

        private List<Product> products = new List<Product>();

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public double GetValueOfProducts()
        {
            //double result = 0;

            //foreach(Product p in products)
            //{
            //    result = result + p.Value;
            //}
            //return result;

            return products.Sum(p => p.Value);
        }

        public double GetBonus()
        {

            return Bonus(GetValueOfProducts());

        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
    }
}
