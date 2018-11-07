using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunFun
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose AK47, P90 or SSG");
                string choice = Convert.ToString(Console.ReadLine());

                if (choice == "ak47")
                {
                    AK();
                }
                if (choice == "p90")
                {
                    P90();
                }

                if (choice == "ssg")
                {
                    SSG();
                }

            }



           
        }

        static void P90()
        {
            P90 p90 = new P90();
            p90.Display();
        }

        static void AK()
        {
            AK ak = new AK();
            ak.Display();
        }

        static void SSG()
        {
            SSG ssg = new SSG();
            ssg.Display();
        }


    }
}
