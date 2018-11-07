using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunFun
{
    public class Gun
    {
        protected string name;
        protected int dps;
        protected double armorpen;
        protected int pen;
        protected int clip;
        protected double spread;
        protected string player;

        public void Display()
        {
            Console.WriteLine("This is the " + name);
            Console.WriteLine("This game has a damage per second of " + dps);
            Console.WriteLine("It has an armorpen of " + armorpen);
            Console.WriteLine("It penetrates " + pen + " object(s)");
            Console.WriteLine("There are " + clip + " bullets in 1 magazine");
            Console.WriteLine("It also has a spread of " + spread + " per bullet");
            Console.WriteLine("The best " + name + " player is: " + player);
            Console.WriteLine();
        }


    }
}
