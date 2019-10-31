using System;
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
    public partial class Form2 : MetroForm
    {
        /*
         1) Form açıldığında ComboBox'lar içerisinde Kebap ve Pilav yemekleri eklenecek.
         2) Kullanıcı her bir CB farklı bir yemek seçecek, aynı yemek seçilemez. (1 ana yemek, 1 ara yemek) 
         3) Porsiyon bilgisi olarak, sadece sayısal değerler girilebilecek. sayı harici kullanıma kapatılacak.
         4) CB içerisinden seçilen yemeğe göre PB'larda o yemeğe ait resimler gösterilecek.
         5) Yemek ve Porsiyon bilgisi boş geçilemez, Kullanıcı bol geçerse,uyarı verdiriniz.
         6) Sipariş Iptal butonuna tıklanırsa, tüm alanlar temizlenip yeni bir sipariş için hazır hale getirilecek.
         7) Sipariş Özeti butonuna tıklanırsa, Kullanıcın seçtiği yemekler ve porsiyon bilgileri ekranda gösterilecek.
         8) Sipariş Al butonuna tıklanırsa, Kullanıcıya ödemisi gereken tutar ekranda yazdırılacak.
         9) Pilav birim fiyatı 5 TL, Kebap 10TL

         */
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
