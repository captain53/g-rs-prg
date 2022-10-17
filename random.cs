using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgelesayıurett
{
    public partial class Form1 : Form
    {
        // sınıfın değişkenleri (field alanlar)
        Random rastgele = new Random();
        // sınıfın property (özellikleri) YOK
        // sınıfın metotları
        public Form1()
        { // yapıcı metot 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  iki değer arasında rastgele tam sayı üret
           
            try
            {
                int mindeger = Convert.ToInt32(textBox1.Text);
                int maksdeger = int.Parse(textBox2.Text);
                int sayi = rastgele.Next(mindeger, maksdeger + 1);
                label3.Text = sayi.ToString();
            }
            catch(Exception istisna)
            {
                // hatayı yakala kullanıcıyı bilgilendir
                MessageBox.Show(istisna.Message, istisna.Source);
            }
            finally
            {
                // hata olsa da olmasa da çalışmasını istediğimiz kod
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // rastgele ondalık sayı üret
            //  iki değer arasında rastgele ondalık sayı üret

            try
            {
                double mindeger = Convert.ToDouble(textBox1.Text);
                double maksdeger = double.Parse(textBox2.Text);
                double sayi = (maksdeger-mindeger)*rastgele.NextDouble()+mindeger;
                label3.Text = sayi.ToString();
            }
            catch (Exception istisna)
            {
                // hatayı yakala kullanıcıyı bilgilendir
                MessageBox.Show(istisna.Message, istisna.Source);
            }
            finally
            {
                // hata olsa da olmasa da çalışmasını istediğimiz kod
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
