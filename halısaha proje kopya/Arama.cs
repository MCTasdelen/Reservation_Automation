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
    public partial class Arama : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\omermmz\\Desktop\\EsasProje\\EsasProje\\Halısaha.mdb");
        // Yolu buraya girin.

        // Bu datagridview'i yiğite kitledim.
        public int Id;
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
        public Arama(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void SıralaBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            comboBox1.Text = "";
            OleDbDataAdapter adpt = new OleDbDataAdapter("Select id,HalısahaAdı,Ilce,Fiyat From Ana", baglanti);
            adpt.Fill(tbl3);
            dataGridView1.DataSource = tbl3;
            baglanti.Close();
        }

        private void Arama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adpt = new OleDbDataAdapter("Select id,HalısahaAdı,Ilce,Fiyat From Ana", baglanti);
            adpt.Fill(tbl);
            dataGridView1.DataSource = tbl;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 250;
            baglanti.Close();
        }
        DataTable tbl = new DataTable();
        DataTable tbl2 = new DataTable();
        DataTable tbl3 = new DataTable();
        DataView Filtrele_ılce()
        {
            DataView dv = new DataView();
            dv = tbl.DefaultView;
            dv.RowFilter = "Ilce Like '" + comboBox1.Text + "%'";
            return dv;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
            textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style ^ FontStyle.Italic);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Connection = baglanti;

            string a = "Select id,HalısahaAdı,Ilce,Fiyat From Ana Where Fiyat Between ? And ?";
            komut2.CommandText = a;
            komut2.Parameters.Add("@v1", OleDbType.Integer).Value = this.textBox1.Text;

            komut2.Parameters.Add("@v2", OleDbType.Integer).Value = this.textBox2.Text;

            OleDbDataAdapter adptFiyat = new OleDbDataAdapter(komut2);
            adptFiyat.Fill(tbl2);
            dataGridView1.DataSource = tbl2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            OleDbDataAdapter adpt = new OleDbDataAdapter("Select id,HalısahaAdı,Ilce,Fiyat From Ana", baglanti);
            adpt.Fill(tbl);
            dataGridView1.DataSource = tbl;

            Filtrele_ılce();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Burası boş yanlışlıkla tıkladım
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Burası da yanlış oldu
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Adres deger = new Adres();
            deger.Id = Id;
            deger.id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            deger.isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            deger.ilce = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            deger.fiyat = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From Ana");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == oku["id"].ToString())
                {
                    deger.adres = oku["Adres"].ToString();
                }
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == oku["id"].ToString())
                {
                    deger.telefon = oku["Telefon"].ToString();
                }
            }
            baglanti.Close();
            panelForm.BringToFront();
            loadform(deger);
            //Hide();
        }
    }
}
