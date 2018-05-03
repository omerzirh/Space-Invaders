using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace b161210116_projeOdev
{
    class Ucaksavar:IHareket
    {
        private int index = 0;
        public PictureBox pic;
        private int apsis;
        private int ordinat;
        private string _resimYolu = "ucaksavar.png";
        
        
     
        public void Hareketliler(AnaPencere a,int ordinat)
        {
            apsis = 5;
           
            pic = new PictureBox();
            pic.ImageLocation = _resimYolu;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(40, 50);
            pic.Location = new Point(apsis, ordinat);
            a.Controls.Add(pic);
            //AsagiGit();;
        }
        public void SolaGit()
        {

            if (pic.Left > 5)
            pic.Left -= 15;        
            if (pic.Left == 5)
                pic.Left = 5;
        }

        public void SagaGit()
        {
           
            if (pic.Left < 730)
                pic.Left += 15;
            if (pic.Left == 730)
                pic.Left = 730;
        }
        public int apsisDondur()
        {
            apsis = pic.Left;
            index++;            //Mermi'nin X degeriyle ucaksavar ayni olmasi gerektigi icin apsis donduren bir metod tasarlandi
            return apsis;
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
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
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
