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
        int Valittu = 0;
        string ValittuNappi;
        Button klikattuNappi;
        Bitmap MustaSolttu = Properties.Resources.ShakkiSolttu;
        Bitmap ValkoinenSolttu = Properties.Resources.ValkoinenShakkiSolttu;
        Bitmap MustaHeppa = Properties.Resources.ShakkiHeppa;
        Bitmap ValkoinenHeppa = Properties.Resources.ValkoinenShakkiHeppas;
        Bitmap MustaTorni = Properties.Resources.ShakkiTorni;
        Bitmap ValkoinenTorni = Properties.Resources.ValkoinenShakkiTorni;
        Bitmap MustaLahetti = Properties.Resources.ShakkiLahetti;
        Bitmap ValkoinenLahetti = Properties.Resources.ValkoinenShakkiLahetti;
        Bitmap MustaKuningatar = Properties.Resources.ShakkiKuningatar;
        Bitmap ValkoinenKuningatar = Properties.Resources.ValkoinenShakkiKuningatar;
        Bitmap MustaKuningas = Properties.Resources.ShakkiKunkku;
        Bitmap ValkoinenKuningas = Properties.Resources.ValkoinenShakkiKunkku;
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

                    //Soltut
                    if (puoliTagi[1] == "2")
                    {
                        nappi.Image = MustaSolttu;
                        string fag = puoliTagi[0] + "," + puoliTagi[1];
                        nappi.Tag = fag + ",MSolttu";
                    }
                    if (puoliTagi[1] == "7")
                    {
                        nappi.Image = ValkoinenSolttu;
                        string fag = puoliTagi[0] + "," + puoliTagi[1];
                        nappi.Tag = fag + ",VSolttu";
                    }

                    //Hepat
                    if (tagi == "2,1")
                    {
                    nappi.Image = MustaHeppa;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",MHeppa";
                    }
                    if (tagi == "7,1")
                    {
                        nappi.Image = MustaHeppa;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",MHeppa";
                    }
                    if (tagi == "2,8")
                    {
                        nappi.Image = ValkoinenHeppa;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",VHeppa";
                    }
                    if (tagi == "7,8")
                    {
                        nappi.Image = ValkoinenHeppa;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",VHeppa";
                    }

                    //Tornit
                    if (tagi == "1,1")
                    {
                        nappi.Image = MustaTorni;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",MTorni";
                    }
                    if (tagi == "8,1")
                    {
                        nappi.Image = MustaTorni;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",MTorni";
                    }
                    if (tagi == "1,8")
                    {
                        nappi.Image = ValkoinenTorni;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",VTorni";
                    }
                    if (tagi == "8,8")
                    {
                        nappi.Image = ValkoinenTorni;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",VTorni";
                    }

                    //Lähetit
                    if (tagi == "3,1")
                    {
                        nappi.Image = MustaLahetti;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",MLahetti";
                    }
                    if (tagi == "6,1")
                    {
                        nappi.Image = MustaLahetti;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",MLahetti";
                    }
                    if (tagi == "3,8")
                    {
                        nappi.Image = ValkoinenLahetti;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",VLahetti";
                    }
                    if (tagi == "6,8")
                    {
                        nappi.Image = ValkoinenLahetti;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",VLahetti";
                    }

                    //Kuningatar
                    if (tagi == "4,1")
                    {
                        nappi.Image = MustaKuningatar;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",MKuningatar";
                    }
                    if (tagi == "4,8")
                    {
                        nappi.Image = ValkoinenKuningatar;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",VLahetti";
                    }

                    //Kuningas
                    if (tagi == "5,1")
                    {
                        nappi.Image = MustaKuningas;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",MKuningas";
                    }
                    if (tagi == "5,8")
                    {
                        nappi.Image = ValkoinenKuningas;
                        string fag = nappi.Tag.ToString();
                        nappi.Tag = fag + ",VKuningas";
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
                if (Valittu == 0)
                {
                    klikattuNappi = (Button)sender;
                    if (puoliTagi[2] == "EiNappia")
                    {
                        return;
                    }
                    if (puoliTagi[2] == "VSolttu")
                    {
                        ValittuNappi = "VSolttu";
                        Sotilas solttu = new Sotilas(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (solttu.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])))
                            {
                                ruutu.BackgroundImage = Properties.Resources.VihreaNappi;
                            }
                            else
                            {
                                ruutu.Enabled = false;
                                nappi.Enabled = true;
                            }
                        }
                    }
                    if (puoliTagi[2] == "MSolttu")
                    {
                        ValittuNappi = "MSolttu";
                        Sotilas solttu = new Sotilas(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (solttu.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])))
                            {
                                ruutu.BackgroundImage = Properties.Resources.VihreaNappi;
                            }
                            else
                            {
                                ruutu.Enabled = false;
                                nappi.Enabled = true;
                            }
                        }
                    }
                    Valittu = 1;
                }
                else if(Valittu == 1)
                {
                    if(ValittuNappi == "VSolttu")
                    {
                        nappi.Image = ValkoinenSolttu;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "VSolttu";
                    }
                    if (ValittuNappi == "MSolttu")
                    {
                        nappi.Image = MustaSolttu;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "MSolttu";
                    }
                    foreach (Button clear in this.Controls)
                    {
                        clear.Enabled = true;
                        clear.BackgroundImage = null;
                    }
                    klikattuNappi.Image = null;
                    string nappitagi = klikattuNappi.Tag.ToString();
                    List<string> nappipuoliTagi = nappitagi.Split(',').ToList<string>();
                    klikattuNappi.Tag = nappipuoliTagi[0] + "," + nappipuoliTagi[1] + "," + "EiNappia";
                    Valittu = 0;
                }
            }
        }
    }
}
