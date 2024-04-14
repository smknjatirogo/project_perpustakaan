using project_perpustakaan.Koneksi_tabelTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_perpustakaan
{
    public partial class frm_1Login : Form
    {
        public frm_1Login()
        {
            InitializeComponent();
        }
        tbl_userTableAdapter koneksi = new tbl_userTableAdapter();

        private void login_Click(object sender, EventArgs e)
        {
            var Login_User = koneksi.GetDataLogin(textBox1.Text, textBox2.Text, comboBox1.Text).FirstOrDefault();
            if ((Login_User != null) &&(JAWABAN_HIDEN.Text==answered.Text))
            {
                MessageBox.Show("Selamat Datang "+" " + textBox1.Text, "Login Berhasil");
                frm_2Menu menu = new frm_2Menu(textBox1.Text,comboBox1.Text);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username dan Password Salah", "Login Gagal");
            }
        }

        private void frm_1Login_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int Rand1 = random.Next(0, 10);
            int Rand2 = random.Next(0, 10);

            P1.Text = Rand1.ToString();
            P2.Text = Rand2.ToString();
            int p3 = Rand1 + Rand2;
            JAWABAN_HIDEN.Text = p3.ToString();
        }
    }
}
