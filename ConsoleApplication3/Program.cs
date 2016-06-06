using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player("Andrew", 154);
            Console.WriteLine(player.getName());
            player.setName();
            string word = "YOLO";
            string foo = "what what";
            string secondName = player.getName();
            Console.WriteLine("The {0} {2} Players {1} name is now {0}", player.getName(), word, foo);
            Console.WriteLine(player.wallet.getBalance());
            player.wallet.withdrawMoney(50);
            Console.WriteLine(player.wallet.getBalance());
            player.wallet.withdrawMoney(40);
            Console.WriteLine(player.wallet.getBalance());
            Store store = new Store();
            string purchase = store.buyItem(player.wallet);
            Console.WriteLine(purchase);
            Console.WriteLine(player.wallet.getBalance());
            player.toys = store.buyLotsOfItems(player.toys);
            foreach(string toy in player.toys)
            {
                Console.WriteLine(toy);
            }
            player.toys = store.buyLotsOfItems(player.toys);
            foreach (string toy in player.toys)
            {
                Console.WriteLine(toy);
            }
            Console.ReadKey();
        }
    }
}
