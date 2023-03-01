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
    public partial class Sifreyenileme : Form
    {
        int id;

        public Sifreyenileme(int prmtre)
        {
            InitializeComponent();
            id = prmtre;
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
        public Sifreyenileme()
        {
            InitializeComponent();
        }
        
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\omermmz\\Desktop\\EsasProje\\EsasProje\\Halısaha.mdb");
        OleDbCommand command;

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
            textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style ^ FontStyle.Italic);
            textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style ^ FontStyle.Bold);

            textBox2.PasswordChar = '*';
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Bold);

            textBox1.PasswordChar = '*';
        }


        private void ıconButton2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                string sorgu = "UPDATE Kullanicilar Set Sifre=@sifre WHERE id=@id";
                command = new OleDbCommand(sorgu, connection);
                command.Parameters.AddWithValue("@sifre", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Şifreniz güncellenmiştir.");
                panelForm.BringToFront();
                loadform(new Girisyap());
            }
            else
            {
                MessageBox.Show("Şifreleriniz uyuşmamaktadır.");
            }
        }
    }
}
