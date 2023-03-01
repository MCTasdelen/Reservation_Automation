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
    public partial class Sifremiunuttum : Form
    {
        public Sifremiunuttum()
        {
            InitializeComponent();
        }
        public int id;
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

        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("Select id,KullaniciAdi,Mail from Kullanicilar where KullaniciAdi=@Kullanici_Adi and Mail=@Mail_", con);

            komut.Parameters.AddWithValue("@Kullanici_Adi", textBox1.Text);
            komut.Parameters.AddWithValue("@Mail_", textBox2.Text);
            OleDbDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {
                Sifreyenileme yeni = new Sifreyenileme(Convert.ToInt32(reader["id"]));
                panelForm.BringToFront();
                loadform(yeni);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ile mail eşleşmiyor!!!");
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }

        private void Sifremiunuttum_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
