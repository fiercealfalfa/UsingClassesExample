using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClassesExample
{
    class Wallet
    {
        decimal money;
        
        public Wallet()
        {
            this.money = 100;
        }
        public void addMoney(decimal amount)
        {
            this.money += amount;
        }
        public void withdrawMoney(decimal amount)
        {
            if(this.money - amount < 0)
            {
                Console.WriteLine("Insuffient Funds");
            }
            else
            {
                this.money -= amount;
            }
        }
        public decimal getBalance()
        {
            return this.money;
        }
            
    }
}
