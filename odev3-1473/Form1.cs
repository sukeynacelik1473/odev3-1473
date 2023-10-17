using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim;
            bool cevap1,cevap2;
            secim = listBox1.SelectedItem.ToString();
            cevap1 = radioButton1.Checked;
            cevap2 = radioButton2.Checked;
            if (cevap1 == true && (secim == "mp4" || secim == "mov"))
            {
                MessageBox.Show("cevabınız doğru");

            }
            if (cevap2 == false && (secim == "mpe" || secim == "mov"))
            {
                MessageBox.Show("cevabınız yanliş");
            }
            if (cevap2==true&& (secim=="jpg"||secim=="png"))
            {
                MessageBox.Show("cevapınız doğru");
            }
            if(cevap1==false&& (secim=="jpg"||secim =="png"))
            {
                MessageBox.Show("cevapınız yanilş");
            }
        }
    }
}
