using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _150201_Win_MercedesTalep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            ListViewItem satır = new ListViewItem();

            satır.UseItemStyleForSubItems = false;
            satır.Text = txtAd.Text;
            satır.SubItems.Add(cmbModel.Text);
            satır.SubItems.Add("");
            satır.SubItems[2].BackColor = btnRenk.BackColor;
            satır.SubItems.Add(cmbVites.Text);
            satır.SubItems.Add(cmbMotor.Text);
            satır.SubItems.Add(cmbHacim.Text);

            listView1.Items.Add(satır);
            txtAd.Clear();
            cmbHacim.SelectedIndex = -1;
            cmbModel.SelectedIndex = -1;
            cmbMotor.SelectedIndex = -1;
            cmbVites.SelectedIndex = -1;
            txtAd.Focus();

        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            DialogResult sonuc = colorDialog1.ShowDialog();
            
            if(sonuc == DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }
        }

        private void btnKaldır_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnKaldır_Click(null, null);
        }

        ListViewItem secili;

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secili = listView1.SelectedItems[0];
            txtAd.Text = secili.Text;
            cmbModel.Text = secili.SubItems[1].Text;
            btnRenk.BackColor = secili.SubItems[2].BackColor;
            cmbVites.Text = secili.SubItems[3].Text;
            cmbMotor.Text = secili.SubItems[4].Text;
            cmbHacim.Text = secili.SubItems[5].Text;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            secili.Text = txtAd.Text;
            secili.SubItems[1].Text = cmbModel.Text;
            secili.SubItems[2].BackColor = btnRenk.BackColor;
            secili.SubItems[3].Text = cmbVites.Text;
            secili.SubItems[4].Text = cmbMotor.Text;
            secili.SubItems[5].Text = cmbHacim.Text;
        }
    }
}
