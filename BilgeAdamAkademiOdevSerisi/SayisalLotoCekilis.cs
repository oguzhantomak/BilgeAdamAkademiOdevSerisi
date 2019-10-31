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
    public partial class SayisalLotoCekilis : MetroForm
    {
        Random rnd = new Random();
        public SayisalLotoCekilis()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            txt1.Text = rnd.Next(1,49).ToString();

            List<int> liste = new List<int>();

            for (int i = 0; i < 6;)
            {
                int rastgeleSayi = rnd.Next(1, 49);
                if (!liste.Contains(rastgeleSayi))
                {
                    //liste.Add(rastgeleSayi);
                    liste.Insert(i, rastgeleSayi);
                    i++;

                }
            }
            txt1.Text = liste[0].ToString();
            txt2.Text = liste[1].ToString();
            txt3.Text = liste[2].ToString();
            txt4.Text = liste[3].ToString();
            txt5.Text = liste[4].ToString();
            txt6.Text = liste[5].ToString();
            timer1.Stop();
        }

        private void SayisalLotoCekilis_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            
        }
    }
}
