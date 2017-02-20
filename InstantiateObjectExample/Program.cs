using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiateObjectExample
{
    class Program
    {
        static void Main()
        {
        }
        static void Run()
        {
            /* Console.WriteLine("Let's make our first cookie...cookie A");
                  Cookie aCookie = new Cookie();
                  Console.WriteLine("Call the crumble function/method");
                  aCookie.crumble();
                  Console.WriteLine("Add attributes to the A cookie");
                  aCookie.Raisin = false;
                  aCookie.Warm = true;
                  aCookie.Oatmeal = false;
                  aCookie.ChocolateChips = true;
                  aCookie.Description = "Extraordinary taste sensation - the ultimate cookie!";
                  aCookie.crumble();

                  Cookie bCookie = new Cookie(true, true, true, false, "A fantastic combination of subtle flavors....");
                  bCookie.crumble();

                  Console.ReadLine(); */

            Console.WriteLine("welcome to waffle-o-rama, the wacky waffle megastore");
            Console.WriteLine("What kind of flavor do you want? type your flavor:")'
                string waffleFlavor = Console.ReadLine();
            Waffle theWaffle;

            if (waffleFlavor == "")
            {
                theWaffle = new Waffle();
            }
            else
            {
                theWaffle = new Waffle(waffleFlavor);
            }
        }
    }
    class Waffle
    {
        string Flavor;
        string Topping;
        string Syrup;
        bool WhipCream;
        bool IceCream;
        bool Fresh;

        public Waffle()
        {

        }

        public Waffle(string flavor)
        {
            Flavor = flavor;
            Console.WriteLine("A " + Flavor + "waffle.");
        }
    }
    class Cookie
    {
        public bool Raisin;
        public bool Warm;
        public bool Oatmeal;
        public bool ChocolateChips;
        public string Description;

        public Cookie()
        {

        }

        public Cookie(bool raisin, bool warm, bool oatmeal, bool chocolatechips, string description)
        {
            Raisin = raisin;
            Warm = warm;
            Oatmeal = oatmeal;
            ChocolateChips = chocolatechips;
            Description = description;
        }
        public void crumble()
        {
            Console.WriteLine("Your " + Description + "cookie crumbled >.<");
            Console.WriteLine("A Swarzenegger-ish voice says \"That's the way the cookie crumbles.\"");
        }
    }
}
