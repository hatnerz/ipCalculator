using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte okt1 = Convert.ToByte(ipAdressBox1.Text);
                byte okt2 = Convert.ToByte(ipAdressBox2.Text);
                byte okt3 = Convert.ToByte(ipAdressBox3.Text);
                byte okt4 = Convert.ToByte(ipAdressBox4.Text);

                byte[] IpAdress = { okt1, okt2, okt3, okt4 };

                //string IpAdressStr = String.Concat(Convert.ToString(okt1,2), Convert.ToString(okt2, 2),
                //    Convert.ToString(okt3, 2), Convert.ToString(okt4, 2));
                string maskStr = "";

                for (int i = 0; i < Convert.ToInt32(prefixBox.Text); i++)
                    maskStr += '1';
                for (int i = 0; i < 32 - Convert.ToInt32(prefixBox.Text); i++)
                    maskStr += '0';

                byte maskOkt1 = Convert.ToByte(maskStr.Substring(0, 8), 2);
                byte maskOkt2 = Convert.ToByte(maskStr.Substring(8, 8), 2);
                byte maskOkt3 = Convert.ToByte(maskStr.Substring(16, 8), 2);
                byte maskOkt4 = Convert.ToByte(maskStr.Substring(24, 8), 2);
                byte[] mask = { maskOkt1, maskOkt2, maskOkt3, maskOkt4 };

                maskBox.Text = mask[0].ToString() + '.' + mask[1].ToString() + '.' + mask[2].ToString() + '.' + mask[3].ToString();
                networkAdressBox.Text = Convert.ToString(okt1 & maskOkt1) + '.' + Convert.ToString(okt2 & maskOkt2) + '.'
                    + Convert.ToString(okt3 & maskOkt3) + '.' + Convert.ToString(okt4 & maskOkt4);

                string hostAdress = "";
                if ((okt1 & ~maskOkt1) != 0) hostAdress = Convert.ToString(okt1 & ~maskOkt1) + '.' + Convert.ToString(okt2 & ~maskOkt2) + '.'
                    + Convert.ToString(okt3 & ~maskOkt3) + '.' + Convert.ToString(okt4 & ~maskOkt4);
                else if ((okt2 & ~maskOkt2) != 0) hostAdress = Convert.ToString(okt2 & ~maskOkt2) + '.'
                    + Convert.ToString(okt3 & ~maskOkt3) + '.' + Convert.ToString(okt4 & ~maskOkt4);
                else if ((okt3 & ~maskOkt3) != 0) hostAdress = Convert.ToString(okt3 & ~maskOkt3) + '.' + Convert.ToString(okt4 & ~maskOkt4);
                else hostAdress = Convert.ToString(okt4 & ~maskOkt4);

                hostAdressBox.Text = hostAdress;
                long maxHostsNum = (long)(Math.Pow(2, 32 - Convert.ToInt32(prefixBox.Text, 10)) - 2);
                if (maxHostsNum < 0) maxHostsNum = 0;
                maxHostsBox.Text = maxHostsNum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
