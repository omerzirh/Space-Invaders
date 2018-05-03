using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b161210116_projeOdev
{
    class Mermi : IHareket
    {
        public int _sayac = 0;

        public List<PictureBox> Listem = new List<PictureBox>();    //yeni olusturacagimiz her bir picturebox ı tutmak icin listeler olusturuldu
        PictureBox pic;
        private int apsis;
        private int ordinat;
        private string _resimYolu = "mermi.png";
  
        
        
        public void Hareketliler(AnaPencere a,int apsis)
        {
            ordinat = 460;
            pic = new PictureBox();
            pic.ImageLocation = _resimYolu;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(30, 25);
            pic.Location = new Point(apsis, ordinat);
            Listem.Add(pic);
            a.Controls.Add(Listem[_sayac]);
            _sayac++;
        }
        public  void YukariGit()
        {
            for (int i = 0; i < Listem.Count; i++)
            {
                Listem[i].Top -= 15;
            }

        }
     
        
        public PictureBox AkitDondur()
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
                ordinat = value;

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
