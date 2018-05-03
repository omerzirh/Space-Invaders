using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b161210116_projeOdev
{
    class Rastgele
    { 
            public static int SayiUret(int min, int max)
            {
                if (rastgele == null)
                    rastgele = new Random();

                return rastgele.Next(min, max);
            }

            private static Random rastgele;
    }
}
