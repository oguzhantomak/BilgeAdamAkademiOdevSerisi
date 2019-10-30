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
    public partial class SayisalLotoCekilis : MetroForm
    {
        Random rnd = new Random();
        public SayisalLotoCekilis()
        {
            InitializeComponent();
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            tmrBaslat.Start();
        }

        private void TmrBaslat_Tick(object sender, EventArgs e)
        {
            int[] liste = new int[6];

            for (int i = 0; i < 5; i++)
            {
               txt1.Text= rnd.Next(1, 49).ToString();
                //liste[i];
                i++;
            }
        }
    }
}
