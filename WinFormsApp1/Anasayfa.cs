using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MalzemeTextBox_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void MalzemeTextBox_Click_1(object sender, EventArgs e)
        {
            MalzemeYönetimi MalzemeYönetimi = new MalzemeYönetimi();

            // Yeni formu göster
            MalzemeYönetimi.Show();
        }

        private void AyarlarTextBox_Click(object sender, EventArgs e)
        {
            Ayarlar_ve_Güvenlik Ayarlar_ve_Güvenlik = new Ayarlar_ve_Güvenlik();
            Ayarlar_ve_Güvenlik.Show();
        }
    }
}
