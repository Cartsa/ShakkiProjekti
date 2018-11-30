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
        Bitmap Solttu = Properties.Resources.ShakkiSolttu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button nappi in this.Controls)
            {
                if(nappi.Tag != null)
                {
                    string tagi = Convert.ToString(nappi.Tag);
                    List<string> puoliTagi = tagi.Split(',').ToList<string>();
                    if (puoliTagi[1] == "2")
                    {
                        nappi.BackgroundImage = Solttu;
                    }
                }               
            }
        }

        private void button_Click(Object sender, EventArgs e)
        {
            if (Vuoro == 0)
            {
                
            }
        }
    }
}
