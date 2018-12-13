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
        int Klikit = 0;
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
        string ViimeTagi;

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
                    nappi.Tag = fag + ",Musta,Solttu";
                }
                if (puoliTagi[1] == "7")
                {
                    nappi.Image = ValkoinenSolttu;
                    string fag = puoliTagi[0] + "," + puoliTagi[1];
                    nappi.Tag = fag + ",Valkoinen,Solttu";
                }

                //Hepat
                if (tagi == "2,1")
                {
                    nappi.Image = MustaHeppa;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Musta,Heppa";
                }
                if (tagi == "7,1")
                {
                    nappi.Image = MustaHeppa;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Musta,Heppa";
                }
                if (tagi == "2,8")
                {
                    nappi.Image = ValkoinenHeppa;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Valkoinen,Heppa";
                }
                if (tagi == "7,8")
                {
                    nappi.Image = ValkoinenHeppa;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Valkoinen,Heppa";
                }

                //Tornit
                if (tagi == "1,1")
                {
                    nappi.Image = MustaTorni;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Musta,Torni";
                }
                if (tagi == "8,1")
                {
                    nappi.Image = MustaTorni;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Musta,Torni";
                }
                if (tagi == "1,8")
                {
                    nappi.Image = ValkoinenTorni;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Valkoinen,Torni";
                }
                if (tagi == "8,8")
                {
                    nappi.Image = ValkoinenTorni;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Valkoinen,Torni";
                }

                //Lähetit
                if (tagi == "3,1")
                {
                    nappi.Image = MustaLahetti;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Musta,Lahetti";
                }
                if (tagi == "6,1")
                {
                    nappi.Image = MustaLahetti;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Musta,Lahetti";
                }
                if (tagi == "3,8")
                {
                    nappi.Image = ValkoinenLahetti;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Valkoinen,Lahetti";
                }
                if (tagi == "6,8")
                {
                    nappi.Image = ValkoinenLahetti;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Valkoinen,Lahetti";
                }

                //Kuningatar
                if (tagi == "4,1")
                {
                    nappi.Image = MustaKuningatar;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Musta,Kuningatar";
                }
                if (tagi == "4,8")
                {
                    nappi.Image = ValkoinenKuningatar;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Valkoinen,Lahetti";
                }

                //Kuningas
                if (tagi == "5,1")
                {
                    nappi.Image = MustaKuningas;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Musta,Kuningas";
                }
                if (tagi == "5,8")
                {
                    nappi.Image = ValkoinenKuningas;
                    string fag = nappi.Tag.ToString();
                    nappi.Tag = fag + ",Valkoinen,Kuningas";
                }
            }
        }

        private void button_Click(Object sender, EventArgs e)
        {
            Button nappi = (Button)sender;
            if (Vuoro == 0)
            {
                string NappiTagi = nappi.Tag.ToString();
                List<string> puoliTagi = NappiTagi.Split(',').ToList<string>();
                if (Valittu == 0)
                {
                    klikattuNappi = (Button)sender;
                    ViimeTagi = NappiTagi;
                    if (puoliTagi[2] == "EiNappia")
                    {
                        return;
                    }
                    else if (puoliTagi[2] == "Valkoinen" && puoliTagi[3] == "Solttu")
                    {
                        ValittuNappi = "VSolttu";
                        Sotilas solttu = new Sotilas(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (solttu.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && RuutupuoliTagi[2] == "EiNappia")
                            {
                                ruutu.BackgroundImage = Properties.Resources.VihreaNappi;
                            }
                            else if (Convert.ToInt32(puoliTagi[1]) - 1 == Convert.ToInt32(RuutupuoliTagi[1]) && Convert.ToInt32(puoliTagi[0]) + 1 == Convert.ToInt32(RuutupuoliTagi[0]) && RuutupuoliTagi[2] == "Musta" ||
                                     Convert.ToInt32(puoliTagi[1]) - 1 == Convert.ToInt32(RuutupuoliTagi[1]) && Convert.ToInt32(puoliTagi[0]) - 1 == Convert.ToInt32(RuutupuoliTagi[0]) && RuutupuoliTagi[2] == "Musta")
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
                    else if (puoliTagi[2] == "Valkoinen" && puoliTagi[3] == "Heppa")
                    {
                        ValittuNappi = "VHeppa";
                        Hevonen Heppa = new Hevonen(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (Heppa.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && RuutupuoliTagi[2] != "Valkoinen")
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
                    else if (puoliTagi[2] == "Valkoinen" && puoliTagi[3] == "Torni")
                    {
                        ValittuNappi = "VTorni";
                        Torni torni = new Torni(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (torni.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])))
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
                    else if (puoliTagi[2] == "Valkoinen" && puoliTagi[3] == "Lahetti")
                    {
                        ValittuNappi = "VLahetti";
                        Lahetti lahetti = new Lahetti(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (lahetti.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])))
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
                    else if (puoliTagi[2] == "Valkoinen" && puoliTagi[3] == "Kuningas")
                    {
                        ValittuNappi = "VKuningas";
                        Kuningas kuningas = new Kuningas(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (kuningas.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && RuutupuoliTagi[2] != "Valkoinen")
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
                    else
                    {
                        Valittu = 0;
                        return;
                    }
                    Valittu = 1;
                }
                else if (Valittu == 1)
                {
                    if(ViimeTagi == nappi.Tag.ToString())
                    {
                        Klikit = 0;
                        Valittu = 0;
                        foreach (Button clear in this.Controls)
                        {
                            clear.Enabled = true;
                            clear.BackgroundImage = null;
                        }
                        return;
                    }
                    else if (ValittuNappi == "VSolttu")
                    {
                        nappi.Image = ValkoinenSolttu;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Valkoinen,Solttu";
                    }                  
                    else if (ValittuNappi == "VHeppa")
                    {
                        nappi.Image = ValkoinenHeppa;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Valkoinen,Heppa";
                    }
                    else if (ValittuNappi == "VTorni")
                    {
                        nappi.Image = ValkoinenTorni;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Valkoinen,Torni";
                    }
                    else if (ValittuNappi == "VLahetti")
                    {
                        nappi.Image = ValkoinenLahetti;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Valkoinen,Lahetti";
                    }
                    else if (ValittuNappi == "VKuningas")
                    {
                        nappi.Image = ValkoinenKuningas;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Valkoinen,Kuningas";
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
            else if (Vuoro == 1)
            {
                string NappiTagi = nappi.Tag.ToString();
                List<string> puoliTagi = NappiTagi.Split(',').ToList<string>();
                if (Valittu == 0)
                {
                    klikattuNappi = (Button)sender;
                    ViimeTagi = NappiTagi;
                    if (puoliTagi[2] == "EiNappia")
                    {
                        return;
                    }
                    else if(puoliTagi[2] == "Musta" && puoliTagi[3] == "Solttu")
                    {
                        ValittuNappi = "MSolttu";
                        Sotilas solttu = new Sotilas(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (solttu.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && RuutupuoliTagi[2] == "EiNappia")
                            {
                                ruutu.BackgroundImage = Properties.Resources.VihreaNappi;
                            }

                            else if (Convert.ToInt32(puoliTagi[1]) + 1 == Convert.ToInt32(RuutupuoliTagi[1]) && Convert.ToInt32(puoliTagi[0]) + 1 == Convert.ToInt32(RuutupuoliTagi[0]) && RuutupuoliTagi[2] == "Valkoinen" ||
                                     Convert.ToInt32(puoliTagi[1]) + 1 == Convert.ToInt32(RuutupuoliTagi[1]) && Convert.ToInt32(puoliTagi[0]) - 1 == Convert.ToInt32(RuutupuoliTagi[0]) && RuutupuoliTagi[2] == "Valkoinen")
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
                    else if(puoliTagi[2] == "Musta" && puoliTagi[3] == "Heppa")
                    {
                        ValittuNappi = "MHeppa";
                        Hevonen Heppa = new Hevonen(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (Heppa.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && RuutupuoliTagi[2] != "Musta")
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
                    else if(puoliTagi[2] == "Musta" && puoliTagi[3] == "Torni")
                    {
                        ValittuNappi = "MTorni";
                        Torni torni = new Torni(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (torni.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])))
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
                    else if (puoliTagi[2] == "Musta" && puoliTagi[3] == "Lahetti")
                    {
                        ValittuNappi = "MLahetti";
                        Lahetti lahetti = new Lahetti(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (lahetti.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])))
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
                    else if (puoliTagi[2] == "Musta" && puoliTagi[3] == "Kuningas")
                    {
                        ValittuNappi = "MKuningas";
                        Kuningas kuningas = new Kuningas(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (kuningas.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && RuutupuoliTagi[2] != "Musta")
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
                    else
                    {
                        Valittu = 0;
                        return;
                    }
                    Valittu = 1;
                }
                else if (Valittu == 1)
                {
                    if (ViimeTagi == nappi.Tag.ToString())
                    {
                        Klikit = 0;
                        Valittu = 0;
                        foreach (Button clear in this.Controls)
                        {
                            clear.Enabled = true;
                            clear.BackgroundImage = null;
                        }
                        return;
                    }
                    else if (ValittuNappi == "MSolttu")
                    {
                        nappi.Image = MustaSolttu;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Musta,Solttu";
                    }
                    else if (ValittuNappi == "MHeppa")
                    {
                        nappi.Image = MustaHeppa;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Musta,Heppa";
                    }
                    else if (ValittuNappi == "MTorni")
                    {
                        nappi.Image = MustaTorni;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Musta,Torni";
                    }
                    else if (ValittuNappi == "MLahetti")
                    {
                        nappi.Image = MustaLahetti;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Musta,Lahetti";
                    }
                    else if (ValittuNappi == "MKuningas")
                    {
                        nappi.Image = MustaKuningas;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Musta,Kuningas";
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
            Klikit++;
            if (Klikit == 2)
            {
                if (Vuoro == 0)
                {
                    Vuoro = 1;
                }

                else if (Vuoro == 1)
                {
                    Vuoro = 0;
                }
                Klikit = 0;
            }
        }
    }
}
