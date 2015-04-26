using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop.Interfaces
{
    public interface ICandyShop
    {
        ICandy GetTopSellingCandy();
        void BuyCandy(ICandy lollipop);
    }
}
