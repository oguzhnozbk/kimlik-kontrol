using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.TcKimlikServiceReference;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Dogrula_Click(object sender, EventArgs e)
        {
            long tcno = Convert.ToInt64(textBox_tc.Text);
            string ad = textBox_ad.Text;
            string soyad = textBox_Soyad.Text;
            int dogumyili = Convert.ToInt32(textBox_dogumYılı.Text);
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            MessageBox.Show(client.TCKimlikNoDogrula(tcno, ad, soyad, dogumyili).ToString());
        }

        private void textBox_ad_TextChanged(object sender, EventArgs e)
        {
            textBox_ad.Text = textBox_ad.Text.ToUpper();
            textBox_ad.SelectionStart = textBox_ad.Text.Length;
        }

        private void textBox_Soyad_TextChanged(object sender, EventArgs e)
        {
            textBox_Soyad.Text = textBox_Soyad.Text.ToUpper();
            textBox_Soyad.SelectionStart = textBox_Soyad.Text.Length;
        }
    }
}
