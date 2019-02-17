using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=0,dk=0,saniye=0,sayac2=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            dk = Convert.ToInt32(label3.Text);
            if (Convert.ToInt32(sayac - dk) == -(dk/sayac))
            {
                label4.Text = "Zaman doluyor";
            }
           else if (sayac == dk)
            {   timer1.Stop();
                sayac = 7;
                label4.Text = "Zaman DOLDU KAPANIYOR";


                
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "C:\\Windows\\system32\\shutdown.exe";
                psi.Arguments = "-f -s -t 0";
                Process.Start(psi);

    





            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            saniye = Convert.ToInt32(textBox2.Text);
            if (saniye ==1)
            {
            label3.Text =  (( Convert.ToInt32(textBox1.Text)  * 60)).ToString();
            }
            else
            {
                label3.Text = ((Convert.ToInt32(textBox1.Text) * 60) + saniye).ToString();
            }   
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac = 0;
            dk = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = "0";
            timer1.Interval = 1000;
            sayac2++;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
