using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BilgeAdamAkademiOdevSerisi
{

    /*
     1) Kullanıcı çekiliş yap butonuna tıkladığında sol baştan başlayarak, 1 ile 49 arasında(49 dahil ) sayı üretecek.
     2) her bi kutuda toplamda 10 adet sayı gösterildikten sonra, 10. üretilen sayı ekrana sabitlecek ve dizi içerisinde tutulacak.
     3) 2. kutudan itibaren 10. sırada gelen sayı daha önce üretildiyse, yeni bir sayı üretilecek ve benzersiz olana kadar bu işlem devam edecek.
     4) 6 kutuda benzersiz sayı üretildikten sonra küçükten büyüğe doğru sıralama yapılacak ve ekrana yazdırılacak.
     5) kullanıcı çekiliş yap dediğinde ekran eski haline gelip tekrar çekiliş yapabilecek ( kullanıcı işlem devam ederkende yeniden başlatabilir.)
         */
    public partial class SayisalLotoCekilis : MetroForm
    {
        Random rnd = new Random();

        int toplam = 0;
        int textboxNumber = 0;
        Control[] controls;
        public SayisalLotoCekilis()
        {
            InitializeComponent();
        }

        //int sayi = 0;
        //int dongu = 0;
        List<int> liste = new List<int>();
        int sayi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Control txt = controls[textboxNumber];
            if(textboxNumber < 6)
            {
                if (toplam < 11)
                {
                    sayi = rnd.Next(1, 49);
                    txt.Text = sayi.ToString();
                    toplam += 1;
                    
                    
                }
                else if (toplam == 11)
                {
                    if (!liste.Contains(sayi))
                    {
                        liste.Add(sayi);
                    }
                }
                else
                {
                    textboxNumber += 1;
                    toplam = 0;
                    if (textboxNumber == 6)
                    {
                        timer1.Stop();

                    }
                }
            } 
        }

        private void SayisalLotoCekilis_Load(object sender, EventArgs e)
        {
            controls = new Control[]
            {
                txt1, txt2, txt3, txt4, txt5, txt6
            };
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
  
            timer1.Start();

            
        }
    }
}
