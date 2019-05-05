using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShakkiProjekti
{
    public partial class Lopetus : Form
    {
        public string ValittuNappi { get; set; }
        public Lopetus()
        {
            InitializeComponent();
        }

        public Lopetus(string ValkoinenPelaaja, string MustaPelaaja, int Vuorot, string voittaja)
        {
            InitializeComponent();
            ShakkiService.Service1Client TallennusService = new ShakkiService.Service1Client();
            if (voittaja == "Valkoinen")
            {
                label1.Text = "Voittaja on " + voittaja + " pelaaja";
                Point Sijainti = new Point(58, 11);
                label1.Location = Sijainti;
                TallennusService.Tallennus(ValkoinenPelaaja,MustaPelaaja,Vuorot, "Valkoinen");
            }else if(voittaja == "Musta")
            {
                label1.Text = "Voittaja on " + voittaja + " pelaaja";
                Point Sijainti = new Point(68, 11);
                label1.Location = Sijainti;
                TallennusService.Tallennus(ValkoinenPelaaja, MustaPelaaja,Vuorot, "Musta");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ValittuNappi = "UusiPeli";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ValittuNappi = "Tarkistele";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ValittuNappi = "Sulje";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
