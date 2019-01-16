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
