using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halısaha_proje_kopya
{
    public partial class Adres : Form
    {
        public int Id;
        public Adres()
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

        public string isim, ilce, fiyat, id, adres, telefon;

        private void telefonlabel_Click(object sender, EventArgs e)
        {

        }

        private void Adres_Load(object sender, EventArgs e)
        {
            idlabel.Text = id;
            halısahaadı_label.Text = isim;
            ilcelabel.Text = ilce;
            fiyatlabel.Text = fiyat;
            adreslabel.Text = adres;
            telefonlabel.Text = telefon;
        }

        private void rezervasyon_Click(object sender, EventArgs e)
        {
            Rezervasyon ac = new Rezervasyon(idlabel.Text.ToString(),Id);
            panelForm.BringToFront();
            loadform(ac);
            //Hide();
        }
    }
}
