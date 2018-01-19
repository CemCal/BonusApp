using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{


    public delegate double DG_BonusProvider(double amount);


    public static class Bonuses
    {

        public static double TenPercent(double amount)
        {
            return amount / 100 * 10;
        }

        public static double FlatTwolfAmountMoreThanFive(double amount)
        {
            return amount > 5 ? 2.0 : 0.0;
        }
    }
}
