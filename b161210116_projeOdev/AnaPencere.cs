/****************************************************************************
**                                 SAKARYA UNIVERSITY
**                          BILGISAYAR MUHENDISLIGI BOLUMU
**                            NESNEYE DAYALI PROGRAMLAMA
**
**                          OGRENCI ISMI.....:Ömer 
**                          OGRENCI SOYISMI..:ZIRH  
**                          OGRENCI NUMARASI.:B161210116    
**                          DERS GRUBU…………………:1.OGRETIM/A GRUBU
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b161210116_projeOdev
{
    class AnaPencere : Form
    {

        Timer zamanlayici;
        Timer asagiZaman;
        Timer yukariZaman;
        DusmanUcak dusman = new DusmanUcak();
        Mermi mermi = new Mermi();
        Ucaksavar ucak = new Ucaksavar();
        System.Media.SoundPlayer fire = new System.Media.SoundPlayer("fire.wav");
        System.Media.SoundPlayer carpisma = new System.Media.SoundPlayer("carpisma.wav");
       
        public AnaPencere(int genislik, int yukseklik)
        {
            Width = genislik;
            Height = yukseklik;
            //dusman = new List<PictureBox>();
            KeyDown += AnaPencere_KeyDown;
            zamanlayici = new Timer();
            asagiZaman = new Timer();
            yukariZaman = new Timer();
            zamanlayici.Interval = 2000;        //zamanlayicilarin interval degerleri verildi
            asagiZaman.Interval = 150;
            yukariZaman.Interval = 100;
            zamanlayici.Tick += Zamanlayici_Tick;
            asagiZaman.Tick += AsagiZaman_Tick;
            yukariZaman.Tick += YukariZaman_Tick;
            DoubleBuffered = true;
        }

        private void YukariZaman_Tick(object sender, EventArgs e)
        {
           mermi.YukariGit();
        }

        private void AsagiZaman_Tick(object sender, EventArgs e)
        { 
                dusman.AsagiGit();
            carpma();
                
        }
        private void Zamanlayici_Tick(object sender, EventArgs e)
        {
            dusman.Hareketliler(this,0);
             }

        public void carpma()
        {
            for (int f = 0; f < dusman.Listem.Count; f++)
            {
                if (dusman.Listem[f].Top > 460)
                {
                    Application.Restart();

                }
            }       
                Rectangle g = new Rectangle();
                Rectangle h = new Rectangle();              
            for (int j = 0; j < mermi.Listem.Count; j++)
            {
               
                PictureBox mrm = mermi.Listem[j];                
                                                           //olusturulan her bir mermi ve dusman kasilastirmak icin dortgene donusturuluyor
                g.X = mrm.Left;
                g.Y = mrm.Top;                     
                g.Width = mrm.Width;                    //mermilerin olusturulduldugu liste indexi kadar dongu dobduruluyor
                g.Height = mrm.Height;
                if (g.Y<0)
                {
                    mermi.Listem[j].Dispose();
                    mermi.Listem.RemoveAt(j);        //eger mermi 0 dan kucuk ise siliniyor ve sayac 1 azaltilarak listenin yapisi bozulmuyor
                    mermi.Sayac--;
                }
                
                for (int f = 0; f < dusman.Listem.Count; f++)           
                {                                           
                    PictureBox dusm = dusman.Listem[f];     //ayni sekilde dusman lsitesi kadar donuyor daha sonra dusman ve mermi intersectsWith ile akrsilastiriliyor ve sinirlari cakisiyorsa ikisde siliniyor
                    h.X = dusm.Left;    
                    h.Y = dusm.Top;
                    h.Width = dusm.Width;
                    h.Height = dusm.Height;
                   
                    if (h.IntersectsWith(g))
                    {
                        dusman.Listem[f].Dispose();
                        dusman.Listem.RemoveAt(f);
                        dusman._sayac--;
                        mermi.Listem[j].Dispose();
                        mermi.Listem.RemoveAt(j);
                        mermi.Sayac--;
                        carpisma.Play();
                    }


                }
               
            }
        }
        private void AnaPencere_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                mermi.Hareketliler(this,(ucak.apsisDondur()-8));  //yukdondur fonksiyonu mermi icin ucaksavarin apsis degerini donduruyor
                
                fire.Play();
            }
            if(e.KeyCode==Keys.Enter)
            {
                ucak.Hareketliler(this,510);
                zamanlayici.Start();
                asagiZaman.Start();
                yukariZaman.Start();
            }
            if (e.KeyCode == Keys.Right)
            {
                ucak.SagaGit();
                Invalidate();
            }
            else if (e.KeyCode == Keys.Left)
            {
                ucak.SolaGit();
                Invalidate();

            }
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaPencere));
            this.SuspendLayout();
            // 
            // AnaPencere
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaPencere";
            this.Text = "Enemy at the Gate";
            this.ResumeLayout(false);

        }       
    }
}
