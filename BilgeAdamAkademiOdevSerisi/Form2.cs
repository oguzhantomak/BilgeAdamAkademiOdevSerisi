using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
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
            cmbBirinciYemek.Items.Add("pilav");
            cmbBirinciYemek.Items.Add("kebap");

            cmbIkinciYemek.Items.Add("pilav");
            cmbIkinciYemek.Items.Add("kebap");
        }

        private void txtPorsiyon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPorsiyon1_TextChanged(object sender, EventArgs e)
        {
            int porsiyon = 0;
            porsiyon = Convert.ToInt32(txtPorsiyon1.Text);
            if (porsiyon > 10)
            {
                MetroMessageBox.Show(this, "En fazla 10 porsiyon sipariş verebilirsiniz!");
            }
        }

        private void txtPorsiyon2_TextChanged(object sender, EventArgs e)
        {
            int porsiyon = Convert.ToInt32(txtPorsiyon2.Text);
            if (porsiyon > 10)
            {
                MetroMessageBox.Show(this, "En fazla 10 porsiyon sipariş verebilirsiniz!");
            }
        }

        private void cmbIkinciYemek_SelectedValueChanged(object sender, EventArgs e)
        {
            string deger = "";
            if (cmbIkinciYemek.SelectedItem == cmbBirinciYemek.SelectedItem)
            {
                MetroMessageBox.Show(this, "Lütfen ilk yemekten farklı bir yemek seçin !");
                cmbIkinciYemek.SelectedItem = default;
                pb2.Dispose();
            }
            if (deger == null)
            {
                deger = default;
            }

            if (cmbIkinciYemek.SelectedItem != cmbBirinciYemek.SelectedItem && cmbIkinciYemek.SelectedItem != null)
            {
                deger = cmbIkinciYemek.SelectedItem.ToString();
                switch (deger)
                {
                    case "pilav":
                        pb2.Image = imglst.Images[1];
                        break;
                    case "kebap":
                        pb2.Image = imglst.Images[0];
                        break;
                    default:
                        break;
                }
            }

        }

        private void cmbBirinciYemek_SelectedValueChanged(object sender, EventArgs e)
        {
            string deger = "";
            if (cmbBirinciYemek.SelectedItem == cmbIkinciYemek.SelectedItem)
            {
                MetroMessageBox.Show(this, "Lütfen ikinci yemekten farklı bir yemek seçin !");
                cmbBirinciYemek.SelectedItem = default;
                pb1.Dispose();
            }

            if (deger == null)
            {
                deger = default;
            }


            if (cmbBirinciYemek.SelectedItem != cmbIkinciYemek.SelectedItem && cmbBirinciYemek.SelectedItem != null)
            {
                deger = cmbBirinciYemek.SelectedItem.ToString();
                switch (deger)
                {
                    case "pilav":
                        pb1.Image = imglst.Images[1];
                        break;
                    case "kebap":
                        pb1.Image = imglst.Images[0];
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            int kebapBirimFiyat = 10;
            int pilavBirimFiyat = 5;
            int toplam = 0;
            if (
                (String.IsNullOrEmpty(txtPorsiyon1.Text) || String.IsNullOrEmpty(txtPorsiyon2.Text)
                )
                &&
                (cmbBirinciYemek.SelectedItem == null || cmbIkinciYemek.SelectedItem == null
                )
                )
            {
                MetroMessageBox.Show(this, "Lütfen porsiyon veya yemek bilgilerini kontrol ediniz. Boş yemek veya porsiyon olamaz !");
            }
            else if
                ((!String.IsNullOrEmpty(txtPorsiyon1.Text) && !String.IsNullOrEmpty(txtPorsiyon2.Text)) && (cmbBirinciYemek.SelectedItem != null && cmbIkinciYemek.SelectedItem != null))
            {
                string cmb1Kebap = "kebap";
                string cmb2Kebap = "kebap";

                string cmb1Pilav = "pilav";
                string cmb2Pilav = "pilav";
                if (cmbBirinciYemek.SelectedItem.ToString() == cmb1Kebap && cmbIkinciYemek.SelectedItem.ToString()==cmb2Pilav)
                {
                    toplam = (Convert.ToInt32(txtPorsiyon1.Text) * 10) + (Convert.ToInt32(txtPorsiyon2.Text)*5);
                    lblFiyat.Text = toplam.ToString();
                }
                else if (cmbBirinciYemek.SelectedItem.ToString()== cmb1Pilav && cmbIkinciYemek.SelectedItem.ToString() == cmb2Kebap)
                {
                    toplam = (Convert.ToInt32(txtPorsiyon1.Text) * 5) + (Convert.ToInt32(txtPorsiyon2.Text) * 10);
                    lblFiyat.Text = toplam.ToString();
                }

                //toplam = Convert.ToInt32(txtPorsiyon1.Text)
                //lblFiyat.Text = "";
            }

        }

        private void btnSiparisIptal_Click(object sender, EventArgs e) //iptal butonuna tıklayınca cmbIkinciYemek_SelectedValueChanged metodu çalışıyor. o önlenicek.
        {
            cmbBirinciYemek.SelectedItem = default;
            cmbIkinciYemek.SelectedItem = default;
            txtPorsiyon1.Text = "0";
            txtPorsiyon2.Text = "0";
            //pb1.Dispose();
            //pb2.Dispose();
            pb1.Image = null;
            pb1.Update();
            pb2.Image = null; // iptal edildikten sonra 1. yemek pilav 2. yemek kebap seçilince 1. yemek görüntüsü geliyor, 2. yemeğin görüntüsü gelmiyor, düzeltilecek.
            pb2.Update();
        }

        private void btnSiparisOzet_Click(object sender, EventArgs e)
        {
            if (
                (!String.IsNullOrEmpty(txtPorsiyon1.Text) && !String.IsNullOrEmpty(txtPorsiyon2.Text)
                )
                &&
                (cmbBirinciYemek.SelectedItem != null && cmbIkinciYemek.SelectedItem != null
                )
                )
            {
                MetroMessageBox.Show(this, $"Ana Yemek:{cmbBirinciYemek.SelectedItem} - Porsiyon: {txtPorsiyon1.Text}\nAra Yemek: {cmbIkinciYemek.SelectedItem} - Porsiyon: {txtPorsiyon2.Text}");
            }
            else
            {
                MetroMessageBox.Show(this, "Lütfen porsiyon veya yemek bilgilerini kontrol ediniz. Boş yemek veya porsiyon olamaz !");
            }

        }
    }
}
