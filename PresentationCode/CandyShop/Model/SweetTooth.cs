using CandyShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop.Model
{
    public class SweetTooth
    {
        public void BuyTastiestCandy(ICandyShop shop)
        {
            var candy = shop.GetTopSellingCandy();
            shop.BuyCandy(candy);
        }
    }
}
