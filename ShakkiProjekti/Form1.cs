﻿using System;
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
        Bitmap MustaHeppa = Properties.Resources.ShakkiHeppa;
        Bitmap ValkoinenHeppa = Properties.Resources.ValkoinenShakkiHeppas;
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

                    //Hepat
                    if (tagi == "2,1")
                    {
                    nappi.BackgroundImage = MustaHeppa;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",MHeppa";
                    }
                    if (tagi == "7,1")
                    {
                        nappi.BackgroundImage = MustaHeppa;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",MHeppa";
                    }
                    if (tagi == "2,8")
                    {
                        nappi.BackgroundImage = ValkoinenHeppa;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",VHeppa";
                    }
                    if (tagi == "7,8")
                    {
                        nappi.BackgroundImage = ValkoinenHeppa;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",VHeppa";
                    }

                    //Soltut
                    if (puoliTagi[1] == "2")
                    {
                        nappi.BackgroundImage = MustaSolttu;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",MSolttu";
                    }
                    if (puoliTagi[1] == "7")
                    {
                        nappi.BackgroundImage = ValkoinenSolttu;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",VSolttu";
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
