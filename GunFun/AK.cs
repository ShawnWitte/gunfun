using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunFun
{
    class AK : Gun
    {
        public AK()
        {
            name = "AK47";
            dps = 360;
            armorpen = 77.5;
            pen = 2;
            clip = 30;
            spread = 0.6;
            player = "Shawn";
        }
    }
}
