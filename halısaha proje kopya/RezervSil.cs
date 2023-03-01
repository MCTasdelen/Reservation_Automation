using System;
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
    public partial class RezervSil : Form
    {
        public int kullaniciId;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\omermmz\\Desktop\\EsasProje\\EsasProje\\Halısaha.mdb");
        // Yolu Girin Buraya
       
        OleDbCommand komut;
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
        public RezervSil(int kullaniciid)
        {
            InitializeComponent();
            kullaniciId = kullaniciid;
            string sorgu = "SELECT Rezervler.id,Ana.HalısahaAdı,Rezervler.Gun,Rezervler.Saat FROM Ana INNER JOIN Rezervler ON Ana.[id] = Rezervler.[Halisaha] WHERE Kullanici=@no";
            baglanti.Open();
            OleDbCommand command = new OleDbCommand(sorgu, baglanti);
            command.Parameters.AddWithValue("@no", kullaniciid);

            OleDbDataAdapter adpt = new OleDbDataAdapter();
            //OleDbDataAdapter adpt = new OleDbDataAdapter("SELECT Rezervler.id as RezervNo,Ana.HalısahaAdı,Rezervler.Gun,Rezervler.Saat FROM Ana INNER JOIN Rezervler ON Ana.[id] = Rezervler.[Halisaha] WHERE Kullanici="+1+"", baglanti);
            DataTable tbl = new DataTable();
            adpt.SelectCommand = command;
            adpt.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
        }

        public void silme()
        {
            string sorgu = "SELECT Rezervler.id,Ana.HalısahaAdı,Rezervler.Gun,Rezervler.Saat FROM Ana INNER JOIN Rezervler ON Ana.[id] = Rezervler.[Halisaha] WHERE Kullanici=@no";
            baglanti.Open();
            OleDbCommand command = new OleDbCommand(sorgu, baglanti);
            command.Parameters.AddWithValue("@no", kullaniciId);

            OleDbDataAdapter adpt = new OleDbDataAdapter();
            //OleDbDataAdapter adpt = new OleDbDataAdapter("SELECT Rezervler.id as RezervNo,Ana.HalısahaAdı,Rezervler.Gun,Rezervler.Saat FROM Ana INNER JOIN Rezervler ON Ana.[id] = Rezervler.[Halisaha] WHERE Kullanici="+1+"", baglanti);
            DataTable tbl = new DataTable();
            adpt.SelectCommand = command;
            adpt.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Rezervler WHERE id=@id";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            Hide();
            Show();
            silme();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            RezervGuncelle rezervGuncelle = new RezervGuncelle(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());
            panelForm.BringToFront();
            loadform(rezervGuncelle);
            //Hide();
        }

        private void RezervSil_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].Width = 130;


        }
    }
}
