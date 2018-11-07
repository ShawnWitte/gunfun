using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunFun
{
    class P90 : Gun
    {
        public P90()
        {
            name = "P90";
            dps = 371;
            armorpen = 52.5;
            pen = 1;
            clip = 50;
            spread = 1;
            player = "Danya";
    }
    }
}
