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
    public partial class Form1 : Form
    {
        int Vuoro = 0;
        Bitmap MustaSolttu = Properties.Resources.ShakkiSolttu;
        Bitmap ValkoinenSolttu = Properties.Resources.ValkoinenShakkiSolttu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button nappi in this.Controls)
            {
                    string tagi = Convert.ToString(nappi.Tag);
                    List<string> puoliTagi = tagi.Split(',').ToList<string>();
                    if (puoliTagi[1] == "2")
                    {
                        string tagert = nappi.Tag.ToString();
                        nappi.BackgroundImage = MustaSolttu;
                        nappi.Tag = tagert + ",MSolttu";
                    }
                    if (puoliTagi[1] == "7")
                    {
                        nappi.BackgroundImage = ValkoinenSolttu;
                        string tagert = nappi.Tag.ToString();
                        nappi.Tag = tagert + ",VSolttu";
                    }               
            }
        }

        private void button_Click(Object sender, EventArgs e)
        {
            if (Vuoro == 0)
            {
                Button nappi = (Button)sender;
                string NappiTagi = nappi.Tag.ToString();
                List<string> puoliTagi = NappiTagi.Split(',').ToList<string>();
                if (puoliTagi[2] == "VSolttu")
                {

                }               
            }
        }
    }
}
