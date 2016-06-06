using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClassesExample
{
    class Player
    {
        string name;
        int IQ;
        public Wallet wallet;
        public List<string> toys; 

        public Player(string name, int IQ)
        {
            this.name = name;
            this.IQ = IQ;
            this.wallet = new Wallet();
            this.toys = new List<string>();

        }
        public void setName()
        {
            Console.WriteLine("Please Enter your new name");
            this.name = Console.ReadLine();
        }
        public string getName()
        {
            return this.name;
        }
    }
}
