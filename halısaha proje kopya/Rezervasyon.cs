using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halısaha_proje_kopya
{
    public partial class Rezervasyon : Form
    {
        public int x;
        public int Id;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\omermmz\\Desktop\\EsasProje\\EsasProje\\Halısaha.mdb");
        OleDbCommand komut;
        OleDbDataReader re;

        public void Alert(string msg)
        {
            warning f = new warning();
            f.showalert(msg);
        }

        public Rezervasyon(string halisaha,int id)
        {
            InitializeComponent();
            x = Convert.ToInt32(halisaha);
            Id = id;
            acilis(x);
        }
        

        

        private void acilis(int x)
        {
            baglanti.Open();
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("SELECT Rezervler.[id], Rezervler.[Gun], Rezervler.[Saat], Rezervler.[Halisaha] FROM Rezervler WHERE Halisaha=@no");
            komut.Parameters.AddWithValue("@no", x);
            
             re = komut.ExecuteReader();
            
            
            
            while (re.Read())
            {
                ArrayList labels = new ArrayList();
                Labels(labels);


                if (re["Saat"].ToString() == cmbsaat.Items[0].ToString())
                {
                    foreach (Label c in labels)
                    {



                        if (c.Name.Equals(re["Gun"].ToString() + 16))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;


                        }

                    }
                }

                else if (re["Saat"].ToString() == cmbsaat.Items[1].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 17))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }

                else if (re["Saat"].ToString() == cmbsaat.Items[2].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 18))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[3].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 19))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[4].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 20))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[5].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 21))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[6].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 22))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[7].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 23))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
            }
            re.Close();
            baglanti.Close();

        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            // yanlışlıkla tıkladım.
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cmbgun.Text == string.Empty || cmbsaat.Text == string.Empty)
            {
                this.Alert("Hata!");
            }
            else
            {
                ArrayList labels = new ArrayList();
                Labels(labels);

                string sorgu = "INSERT INTO Rezervler(Halisaha,Gun,Saat,Kullanici) values (@halisaha,@gun,@saat,@kullanici)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@halisaha", x);
                komut.Parameters.AddWithValue("@gun", cmbgun.Text.ToString());
                komut.Parameters.AddWithValue("@saat", cmbsaat.Text.ToString());
                komut.Parameters.AddWithValue("@kullanici", Id);
                baglanti.Open();
                int sayac = 0;
                foreach (Label l in labels)
                {
                    if (l.ForeColor == Color.Red && l.BackColor == Color.DarkGreen && cmbsaat.Text.ToString() == l.Text && l.Name.IndexOf(cmbgun.Text.ToString(), 0) != -1)
                    {
                        this.Alert("Hata!");
                        sayac++;
                    }

                }

                if (sayac == 0)
                {
                    komut.ExecuteNonQuery();
                }

                baglanti.Close();
                foreach (Label label in labels)
                {
                    label.BackColor = Color.Empty;
                    label.ForeColor = Color.Empty;
                }
                Hide();
                Show();
                acilis(x);
            }
        }
    }
}
      