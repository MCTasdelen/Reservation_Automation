using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace halısaha_proje_kopya
{
    public partial class Girisyap : Form
    {
        public int id;
        public Girisyap()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.panelForm.Controls.Count > 0)
            {
                this.panelForm.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(f);
            this.panelForm.Tag = f;
            f.Show();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\omermmz\\Desktop\\EsasProje\\EsasProje\\Halısaha.mdb");

        private void Girisyap_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
            textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style ^ FontStyle.Italic);
            textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style ^ FontStyle.Bold);
            textBox2.PasswordChar = '*';
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            // giriş için veri tabanından kontrol yapılacak
            // Profil sayfası açılacak
           
            con.Open();
            OleDbCommand komut = new OleDbCommand("Select id,KullaniciAdi,Sifre from Kullanicilar where KullaniciAdi=@Kullanici_Adi and Sifre=@Sifre", con);
            
            komut.Parameters.AddWithValue("@Kullanıcı Adı", textBox1.Text);
            komut.Parameters.AddWithValue("@Şifre", textBox2.Text);
            OleDbDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                Profil yeni = new Profil(Convert.ToInt32(reader["id"]));
                yeni.id = Convert.ToInt32(reader["id"]);
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış giriş yaptınız tekrar deneyin");
            }
            con.Close();
        }

        private void ıconButton6_Click(object sender, EventArgs e)
        {
            panelForm.BringToFront();
            loadform(new Kayıtol());
        }

        private void ıconButton7_Click(object sender, EventArgs e)
        {
            panelForm.BringToFront();
            loadform(new Sifremiunuttum());
        }
    }
}
