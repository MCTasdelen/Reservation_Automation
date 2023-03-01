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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
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

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            loadform(new Bos());
            MessageBox.Show("onur_arikan2002@hotmail.com mailine ulaşabilirsiniz.");
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            loadform(new Kayıtol());
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            loadform(new Girisyap());
        }
    }
}
