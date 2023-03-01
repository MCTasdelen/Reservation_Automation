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
    public partial class Profil : Form
    {
        public int id;
        
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\omermmz\\Desktop\\EsasProje\\EsasProje\\Halısaha.mdb");

        public Profil(int Id)
        {
            InitializeComponent();
            id = Id;
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

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            loadform(new Arama(id));
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            loadform(new RezervSil(id));
            
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profil_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("Select Ad,Soyad from Kullanicilar where id=@id", con);
            komut.Parameters.AddWithValue("@id",id);
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                label2.Text = "Sn." + reader["Ad"].ToString() + " " + reader["Soyad"].ToString();
            }

        }
    }
}
