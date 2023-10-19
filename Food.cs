using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_C_
{
    public class Meatprovider: IFoodprovider
    {
        public string Providefood()
        {
            return "Meat";
        }
    }

    public class Fruitprovider : IFoodprovider
    {
        public string Providefood()
        {
            return "Fruits";
        }
    }
}
