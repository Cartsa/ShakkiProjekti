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
    public partial class NimiForm : Form
    {
        public string MustaPeluri;
        public string ValkoinenPeluri;
        public NimiForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MustaPeluri = textBox1.Text;
            ValkoinenPeluri = textBox2.Text;
            this.Close();
        }
    }
}
