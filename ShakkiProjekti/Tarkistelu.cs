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
    public partial class Tarkistelu : Form
    {
        public string ValittuNappi { get; set; }
        public Tarkistelu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ValittuNappi = "Sallittu";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ValittuNappi = "EiSallittu";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
