using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b161210116_projeOdev
{
    interface IHareket
    {

          int Y
        {
            get;

            set;
        }

          int X
        {
            get;

            set;
        }
        int Sayac { get; set; }
       
        string ResimYolu { get; set; }
        
       void Hareketliler(AnaPencere a,int i);
      
    }
}
