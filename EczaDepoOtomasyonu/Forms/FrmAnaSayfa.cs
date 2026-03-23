using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaDepoOtomasyonu.Forms
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ilaçYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmIlaclar ilacFormu = new Forms.FrmIlaclar();
            ilacFormu.MdiParent = this;
            ilacFormu.Show();
        }

        private void stokGrafiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmGrafik grafikFormu = new Forms.FrmGrafik();
            grafikFormu.MdiParent = this; // Ana sayfanın içinde aç
            grafikFormu.Show();
        }

        private void yedeklemeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmDosya dosyaFormu = new Forms.FrmDosya();
            dosyaFormu.MdiParent = this;
            dosyaFormu.Show();
        }

        private void yedeklemeEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmDosya dosyaFormu = new Forms.FrmDosya();
            dosyaFormu.MdiParent = this;
            dosyaFormu.Show();
        }
    }
}
