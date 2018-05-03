using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;

namespace b161210116_projeOdev
{
    class DusmanUcak:IHareket
    {
        
        //AnaPencere a = new AnaPencere(800,600);
        public int _sayac = 0;

        public List<PictureBox> Listem = new List<PictureBox>();

        PictureBox pic;
        private int apsis;
        private int ordinat;
        private string _resimYolu = "ucak.png";
        
        public  void Hareketliler(AnaPencere a,int ordinat)
        {
            apsis = Rastgele.SayiUret(1,745);
            
            pic = new PictureBox();
            pic.ImageLocation = _resimYolu;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;        //picturebox  icin gerekli bilgiler ataniyor 
            pic.Size = new Size(40, 50);
            pic.Location = new Point(apsis, ordinat);
            Listem.Add(pic);
            a.Controls.Add(Listem[_sayac]);
            _sayac++;
        }
        
        public  void AsagiGit()
        {
            for (int i = 0; i < Listem.Count; i++)
            {
               Listem[i].Top += 15;
            }

        }
        
       
        public PictureBox akitDondur()
        {
            return pic;
        }
        public  int Y
        {
            get
            {
                return ordinat;
            }

            set
            {

                value = ordinat;

            }
        }

        public  int X
        {
            get
            {
                return apsis;
            }

            set
            {
                apsis = value;
            }
        }

        public int Sayac
        {
            get
            {
                return _sayac;
            }

            set
            {
                _sayac = value;
            }
        }
        

        public string ResimYolu
        {
            get
            {
                return _resimYolu;
            }

            set
            {
                _resimYolu = value;
            }
        }

       
    }
}
