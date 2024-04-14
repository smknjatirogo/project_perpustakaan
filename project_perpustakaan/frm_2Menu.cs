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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_perpustakaan
{
    public partial class frm_2Menu : Form
    {
        public frm_2Menu(string text, string text1)
        {
            InitializeComponent();
            username.Text = text;
            level.Text = text1;
        }
        tbl_user1TableAdapter koneksiProfil = new tbl_user1TableAdapter();


        private void frm_2Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dataGridView1.DataSource = koneksiProfil.GetDataProfil(username.Text);
            id.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();




            /*var Login_User = koneksiProfil.GetDataProfil(username.Text).FirstOrDefault();
            if (Login_User != null)
            {
              
            }*/

            /*foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    id.Text= row.Cells[0].Value.ToString();
                }
            }*/


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            jam.Text = DateTime.Now.ToString("dd-MMMM-yyyy h:mm:ss tt");
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_1Login login = new frm_1Login();
            login.Show();
            this.Close();
        }

        private void pROFILToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koneksiProfil.Update(textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,Convert.ToInt32(textBox1.Text),textBox5.Text);
            MessageBox.Show("Update Profil " + " " + textBox3.Text, "Berhasil");
        }
    }
}
