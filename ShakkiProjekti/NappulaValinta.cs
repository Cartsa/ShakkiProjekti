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
    public partial class NappulaValinta : Form
    {
        public string ValittuNappi { get; set; }
        public NappulaValinta()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.ValittuNappi = "Kuningatar";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.ValittuNappi = "Torni";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.ValittuNappi = "Lahetti";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.ValittuNappi = "Hevonen";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
