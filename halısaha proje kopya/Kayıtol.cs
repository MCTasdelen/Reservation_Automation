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
    public partial class Kayıtol : Form
    {
        public Kayıtol()
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

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\omermmz\\Desktop\\EsasProje\\EsasProje\\Halısaha.mdb");
        OleDbCommand command;
        private void textclear(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                if (item.Controls.Count > 0)
                {
                    textclear(item);
                }
                if (item is ComboBox)
                {
                    comboBox1.Text = null;
                }
            }
        }

        private int deger;
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            // Bu kaydet butonuna bakılması lazım

            if (maskedTextBox1.Text == "")
                deger++;
            if (maskedTextBox2.Text == "")
                deger++;
            if (maskedTextBox3.Text == "")
                deger++;
            if (maskedTextBox4.Text == "")
                deger++;
            if (maskedTextBox5.Text == "")
                deger++;
            if (maskedTextBox7.Text == "")
                deger++;
            if (maskedTextBox8.Text == "")
                deger++;
            if (maskedTextBox9.Text == "")
                deger++;
            if (maskedTextBox10.Text == "")
                deger++;
            if (maskedTextBox11.Text == "")
                deger++;
            if (comboBox1.Text == "")
                deger++;
            if (deger > 0)
            {
                MessageBox.Show("Boş Alan Bırakılamaz");
            }
            else
            {
                deger = 0;
                string sorgu = "INSERT INTO Kullanicilar(Ad,Soyad,DogumTarihi,Boy,Kilo,Cinsiyet,Mail,TelefonNo,KullaniciAdi,Sifre) VALUES (@ad,@soyad,@dogumtarihi,@boy,@kilo,@cinsiyet,@mail,@telno,@kullaniciadi,@sifre)";
                command = new OleDbCommand(sorgu, connection);
                command.Parameters.AddWithValue("@ad", maskedTextBox1.Text.ToString());
                command.Parameters.AddWithValue("@soyad", maskedTextBox2.Text.ToString());
                command.Parameters.AddWithValue("@dogumtarihi", maskedTextBox3.Text.ToString());
                command.Parameters.AddWithValue("@boy", maskedTextBox4.Text.ToString());
                command.Parameters.AddWithValue("@kilo", maskedTextBox5.Text.ToString());
                command.Parameters.AddWithValue("@cinsiyet", comboBox1.Text.ToString());
                command.Parameters.AddWithValue("@mail", maskedTextBox7.Text.ToString());
                command.Parameters.AddWithValue("@telno", maskedTextBox8.Text.ToString());
                command.Parameters.AddWithValue("@kullaniciadi", maskedTextBox9.Text.ToString());
                command.Parameters.AddWithValue("@sifre", maskedTextBox10.Text.ToString());
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt Başarılı");
                textclear(this);
                panelForm.BringToFront();
                loadform(new Girisyap());
            }
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            textclear(this);
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
