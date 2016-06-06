using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClassesExample
{
    class Store
    {
        public string buyItem(Wallet wallet)
        {
            decimal itemPrice = 20;
            decimal balanceLeft = wallet.getBalance() - itemPrice;
            if (balanceLeft > 0)
            {
                wallet.withdrawMoney(itemPrice); 
                return "This is a cool item, it is a skateboard";
            }
            else
            {
                return "Get some money fool";
            }

        }
        public List<string> buyLotsOfItems(List<string> purchasedItems)
        {
            int numberOfItems = 10;
            for (int i = 0; i < numberOfItems; i++)
            {
               
                purchasedItems.Add("This is the item"+ i);
            }
            return purchasedItems;
        }
    }
}
