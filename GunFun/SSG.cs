using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunFun
{
    public class SSG : Gun
    { 
        
        public SSG(){
        name = "SSG";
        dps = 70;
        armorpen = 85;
        pen = 3;
        clip = 10;
        spread = 0.2;
        player = "King Savage";
    }
}
}
