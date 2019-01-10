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
        bool breakki = false;

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
                    nappi.Tag = fag + ",Valkoinen,Kuningatar";
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
                        List<Button> SallitutLiikkeet = new List<Button>();
                        ValittuNappi = "VTorni";
                        Torni torni = new Torni(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (torni.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && NappiTagi != ruutuTagi)
                            {
                                SallitutLiikkeet.Add(ruutu);
                                ruutu.Enabled = false;
                            }
                            else
                            {
                                ruutu.Enabled = false;
                                nappi.Enabled = true;
                            }
                        }
                        for (int looppi1 = 1; looppi1 < 9; looppi1++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[0] == puoliTagi[0])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }

                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi2 = 1; looppi2 < 9; looppi2++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[0] == puoliTagi[0])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi3 = 1; looppi3 < 9; looppi3++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[1] == puoliTagi[1])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi3)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi4 = 1; looppi4 < 9; looppi4++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[1] == puoliTagi[1])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi4)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                    }
                    else if (puoliTagi[2] == "Valkoinen" && puoliTagi[3] == "Lahetti")
                    {
                        List<Button> SallitutLiikkeet = new List<Button>();
                        ValittuNappi = "VLahetti";
                        Lahetti lahetti = new Lahetti(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (lahetti.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && NappiTagi != ruutuTagi)
                            {
                                SallitutLiikkeet.Add(ruutu);
                                ruutu.Enabled = false;
                            }
                            else
                            {
                                ruutu.Enabled = false;
                                nappi.Enabled = true;
                            }  
                        }
                        for (int looppi1 = 1; looppi1 < 9; looppi1++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi1)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }

                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi2 = 1; looppi2 < 9; looppi2++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi2)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi3 = 1; looppi3 < 9; looppi3++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi3)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi3)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi4 = 1; looppi4 < 9; looppi4++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi4)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi4)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
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
                    else if (puoliTagi[2] == "Valkoinen" && puoliTagi[3] == "Kuningatar")
                    {
                        List<Button> SallitutLiikkeet = new List<Button>();
                        ValittuNappi = "VKuningatar";
                        Kuningatar kuningatar = new Kuningatar(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (kuningatar.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && NappiTagi != ruutuTagi)
                            {
                                SallitutLiikkeet.Add(ruutu);
                                ruutu.Enabled = false;
                            }
                            else
                            {
                                ruutu.Enabled = false;
                                nappi.Enabled = true;
                            }
                        }
                        for (int looppi1 = 1; looppi1 < 9; looppi1++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi1)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }

                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi2 = 1; looppi2 < 9; looppi2++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi2)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi3 = 1; looppi3 < 9; looppi3++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi3)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi3)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi4 = 1; looppi4 < 9; looppi4++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi4)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi4)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi1 = 1; looppi1 < 9; looppi1++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[0] == puoliTagi[0])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }

                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi2 = 1; looppi2 < 9; looppi2++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[0] == puoliTagi[0])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi3 = 1; looppi3 < 9; looppi3++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[1] == puoliTagi[1])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi3)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi4 = 1; looppi4 < 9; looppi4++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[1] == puoliTagi[1])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi4)
                                    {
                                        if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
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
                    else if (ValittuNappi == "VSolttu")
                    {
                        if (Convert.ToInt32(puoliTagi[1]) == 1)
                        {
                            for (int i = 5; i > 1; i++)
                            {
                                NappulaValinta Valitse = new NappulaValinta();
                                var Result = Valitse.ShowDialog();
                                if (Result == DialogResult.OK)
                                {
                                    string muuttuu = Valitse.ValittuNappi;
                                    if (muuttuu == "Kuningatar")
                                    {
                                        nappi.Image = ValkoinenKuningatar;
                                        string VaihettuTagi = puoliTagi[0] + "," + puoliTagi[1] + ",Valkoinen,Kuningatar";
                                        nappi.Tag = VaihettuTagi;
                                        ViimeTagi = VaihettuTagi;
                                        i = 0;
                                    }
                                    else if (muuttuu == "Torni")
                                    {
                                        nappi.Image = ValkoinenTorni;
                                        string VaihettuTagi = puoliTagi[0] + "," + puoliTagi[1] + ",Valkoinen,Torni";
                                        nappi.Tag = VaihettuTagi;
                                        ViimeTagi = VaihettuTagi;
                                        i = 0;
                                    }
                                    else if (muuttuu == "Lahetti")
                                    {
                                        nappi.Image = ValkoinenLahetti;
                                        string VaihettuTagi = puoliTagi[0] + "," + puoliTagi[1] + ",Valkoinen,Lahetti";
                                        nappi.Tag = VaihettuTagi;
                                        ViimeTagi = VaihettuTagi;
                                        i = 0;
                                    }
                                    else
                                    {
                                        nappi.Image = ValkoinenHeppa;
                                        string VaihettuTagi = puoliTagi[0] + "," + puoliTagi[1] + ",Valkoinen,Heppa";
                                        nappi.Tag = VaihettuTagi;
                                        ViimeTagi = VaihettuTagi;
                                        i = 0;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Valitse nappi joksi haluat sotilaan muuttuvan");
                                }
                            }
                        }
                        else
                        {
                            nappi.Image = ValkoinenSolttu;
                            string fag = nappi.Tag.ToString();
                            List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                            nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Valkoinen,Solttu";
                            Sotilas sotilas = new Sotilas(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), "Valkoinen");
                            foreach (Button ruutu in this.Controls)
                            {
                                string ruutuTagi = ruutu.Tag.ToString();
                                List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                                try
                                {
                                    if (Convert.ToInt32(puoliTagi[1]) - 1 == Convert.ToInt32(RuutupuoliTagi[1]) && Convert.ToInt32(puoliTagi[0]) + 1 == Convert.ToInt32(RuutupuoliTagi[0]) && RuutupuoliTagi[2] == "Musta" && RuutupuoliTagi[3] == "Kuningas" ||
                                        Convert.ToInt32(puoliTagi[1]) - 1 == Convert.ToInt32(RuutupuoliTagi[1]) && Convert.ToInt32(puoliTagi[0]) - 1 == Convert.ToInt32(RuutupuoliTagi[0]) && RuutupuoliTagi[2] == "Musta" && RuutupuoliTagi[3] == "Kuningas")
                                    {
                                        MessageBox.Show("Shakki");
                                    }
                                }
                                catch (Exception virhe)
                                {

                                }
                            }
                        }
                    }
                    else if (ValittuNappi == "VHeppa")
                    {
                        nappi.Image = ValkoinenHeppa;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Valkoinen,Heppa";
                        Hevonen hevonen = new Hevonen(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            try
                            {
                                if (hevonen.SallittuLiike(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && RuutupuoliTagi[2] == "Musta" && RuutupuoliTagi[3] == "Kuningas")
                                {
                                    MessageBox.Show("Shakki");
                                }
                            }
                            catch (Exception virhe)
                            {

                            }
                        }
                    }
                    else if (ValittuNappi == "VTorni")
                    {
                        List<Button> SallitutLiikkeet = new List<Button>();
                        nappi.Image = ValkoinenTorni;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Valkoinen,Torni";
                        Torni torni = new Torni(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            try
                            {
                                if (torni.SallittuLiike(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && NappiTagi != ruutuTagi)
                                {
                                    SallitutLiikkeet.Add(ruutu);
                                }
                            }
                            catch (Exception virhe)
                            {

                            }                         
                        }
                        try
                        {
                            for (int looppi1 = 1; looppi1 < 9; looppi1++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[0] == puoliTagi[0])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                        {
                                            if (TestiPuoliTagi[2] == "Musta" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }                                           
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi2 = 1; looppi2 < 9; looppi2++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[0] == puoliTagi[0])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                        {
                                            if (TestiPuoliTagi[2] == "Musta" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if(TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }                                         
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi3 = 1; looppi3 < 9; looppi3++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[1] == puoliTagi[1])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi3)
                                        {
                                            if (TestiPuoliTagi[2] == "Musta" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }                                      
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi4 = 1; looppi4 < 9; looppi4++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[1] == puoliTagi[1])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi4)
                                        {
                                            if (TestiPuoliTagi[2] == "Musta" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                        }
                        catch
                        {

                        }
                    }
                    else if (ValittuNappi == "VLahetti")
                    {
                        List<Button> SallitutLiikkeet = new List<Button>();
                        nappi.Image = ValkoinenLahetti;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Valkoinen,Lahetti";
                        Lahetti lahetti = new Lahetti(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            try
                            {
                                if (lahetti.SallittuLiike(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && NappiTagi != ruutuTagi)
                                {
                                    SallitutLiikkeet.Add(ruutu);
                                }
                            }
                            catch (Exception virhe)
                            {

                            }
                        }
                        try
                        {
                            for (int looppi1 = 1; looppi1 < 9; looppi1++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[0] == puoliTagi[0])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                        {
                                            if (TestiPuoliTagi[2] == "Musta" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi2 = 1; looppi2 < 9; looppi2++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[0] == puoliTagi[0])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                        {
                                            if (TestiPuoliTagi[2] == "Musta" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi3 = 1; looppi3 < 9; looppi3++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[1] == puoliTagi[1])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi3)
                                        {
                                            if (TestiPuoliTagi[2] == "Musta" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi4 = 1; looppi4 < 9; looppi4++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[1] == puoliTagi[1])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi4)
                                        {
                                            if (TestiPuoliTagi[2] == "Musta" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                        }
                        catch
                        {

                        }
                    }
                    else if (ValittuNappi == "VKuningas")
                    {
                        nappi.Image = ValkoinenKuningas;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Valkoinen,Kuningas";
                    }
                    else if (ValittuNappi == "VKuningatar")
                    {
                        nappi.Image = ValkoinenKuningatar;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Valkoinen,Kuningatar";
                        Kuningatar kuningatar = new Kuningatar(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), "Valkoinen");
                        foreach (Button ruutu in this.Controls)
                        {
                                string ruutuTagi = ruutu.Tag.ToString();
                                List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            try
                            {
                                if (kuningatar.SallittuLiike(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && RuutupuoliTagi[2] == "Musta" && RuutupuoliTagi[3] == "Kuningas")
                                {
                                    MessageBox.Show("Shakki");
                                }
                            }catch(Exception virhe)
                            {
                               
                            }
                        }
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
                        List<Button> SallitutLiikkeet = new List<Button>();
                        ValittuNappi = "MTorni";
                        Torni torni = new Torni(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (torni.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && ruutuTagi != NappiTagi)
                            {
                                SallitutLiikkeet.Add(ruutu);
                                ruutu.Enabled = false;
                            }
                            else
                            {
                                ruutu.Enabled = false;
                                nappi.Enabled = true;
                            }
                        }
                        for (int looppi1 = 1; looppi1 < 9; looppi1++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[0] == puoliTagi[0])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }

                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi2 = 1; looppi2 < 9; looppi2++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[0] == puoliTagi[0])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi3 = 1; looppi3 < 9; looppi3++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[1] == puoliTagi[1])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi3)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi4 = 1; looppi4 < 9; looppi4++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[1] == puoliTagi[1])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi4)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                    }
                    else if (puoliTagi[2] == "Musta" && puoliTagi[3] == "Lahetti")
                    {
                        List<Button> SallitutLiikkeet = new List<Button>();
                        ValittuNappi = "MLahetti";
                        Lahetti lahetti = new Lahetti(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (lahetti.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && NappiTagi != ruutuTagi)
                            {
                                SallitutLiikkeet.Add(ruutu);
                                ruutu.Enabled = false;
                            }
                            else
                            {
                                ruutu.Enabled = false;
                                nappi.Enabled = true;
                            }
                        }
                        for (int looppi1 = 1; looppi1 < 9; looppi1++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi1)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }

                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi2 = 1; looppi2 < 9; looppi2++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi2)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi3 = 1; looppi3 < 9; looppi3++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi3)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi3)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi4 = 1; looppi4 < 9; looppi4++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi4)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi4)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
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
                    else if (puoliTagi[2] == "Musta" && puoliTagi[3] == "Kuningatar")
                    {
                        List<Button> SallitutLiikkeet = new List<Button>();
                        ValittuNappi = "MKuningatar";
                        Kuningatar kuningatar = new Kuningatar(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            if (kuningatar.SallittuLiike(Convert.ToInt32(puoliTagi[0]), Convert.ToInt32(puoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && NappiTagi != ruutuTagi)
                            {
                                SallitutLiikkeet.Add(ruutu);
                                ruutu.Enabled = false;
                            }
                            else
                            {
                                ruutu.Enabled = false;
                                nappi.Enabled = true;
                            }
                        }
                        for (int looppi1 = 1; looppi1 < 9; looppi1++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi1)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }

                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi2 = 1; looppi2 < 9; looppi2++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi2)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi3 = 1; looppi3 < 9; looppi3++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi3)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi3)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi4 = 1; looppi4 < 9; looppi4++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi4)
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi4)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi1 = 1; looppi1 < 9; looppi1++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[0] == puoliTagi[0])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }

                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi2 = 1; looppi2 < 9; looppi2++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[0] == puoliTagi[0])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi3 = 1; looppi3 < 9; looppi3++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[1] == puoliTagi[1])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi3)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
                        for (int looppi4 = 1; looppi4 < 9; looppi4++)
                        {
                            if (breakki)
                            {
                                break;
                            }
                            foreach (Button testi in SallitutLiikkeet)
                            {
                                string TestiTagi = testi.Tag.ToString();
                                List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                if (TestiPuoliTagi[1] == puoliTagi[1])
                                {
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi4)
                                    {
                                        if (TestiPuoliTagi[2] == "Valkoinen")
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                            breakki = true;
                                            break;
                                        }
                                        else if (TestiPuoliTagi[2] == "Musta")
                                        {
                                            breakki = true;
                                            break;
                                        }
                                        else
                                        {
                                            testi.Enabled = true;
                                            testi.BackgroundImage = Properties.Resources.VihreaNappi;
                                        }
                                    }
                                }
                            }
                        }
                        breakki = false;
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
                        if (Convert.ToInt32(puoliTagi[1]) == 8)
                        {
                            for (int i = 5; i > 1; i++)
                            {
                                NappulaValinta Valitse = new NappulaValinta();
                                var Result = Valitse.ShowDialog();
                                if (Result == DialogResult.OK)
                                {
                                    string muuttuu = Valitse.ValittuNappi;
                                    if (muuttuu == "Kuningatar")
                                    {
                                        nappi.Image = MustaKuningatar;
                                        string VaihettuTagi = puoliTagi[0] + "," + puoliTagi[1] + ",Musta,Kuningatar";
                                        nappi.Tag = VaihettuTagi;
                                        ViimeTagi = VaihettuTagi;
                                        i = 0;
                                    }
                                    else if (muuttuu == "Torni")
                                    {
                                        nappi.Image = MustaTorni;
                                        string VaihettuTagi = puoliTagi[0] + "," + puoliTagi[1] + ",Musta,Torni";
                                        nappi.Tag = VaihettuTagi;
                                        ViimeTagi = VaihettuTagi;
                                        i = 0;
                                    }
                                    else if (muuttuu == "Lahetti")
                                    {
                                        nappi.Image = MustaLahetti;
                                        string VaihettuTagi = puoliTagi[0] + "," + puoliTagi[1] + ",Musta,Lahetti";
                                        nappi.Tag = VaihettuTagi;
                                        ViimeTagi = VaihettuTagi;
                                        i = 0;
                                    }
                                    else
                                    {
                                        nappi.Image = MustaHeppa;
                                        string VaihettuTagi = puoliTagi[0] + "," + puoliTagi[1] + ",Musta,Heppa";
                                        nappi.Tag = VaihettuTagi;
                                        ViimeTagi = VaihettuTagi;
                                        i = 0;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Valitse nappi joksi haluat sotilaan muuttuvan");
                                }
                            }
                        }
                        else
                        {
                            nappi.Image = MustaSolttu;
                            string fag = nappi.Tag.ToString();
                            List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                            nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Musta,Solttu";
                            Sotilas sotilas = new Sotilas(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), "Musta");
                            foreach (Button ruutu in this.Controls)
                            {
                                string ruutuTagi = ruutu.Tag.ToString();
                                List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                                try
                                {
                                    if (Convert.ToInt32(puoliTagi[1]) + 1 == Convert.ToInt32(RuutupuoliTagi[1]) && Convert.ToInt32(puoliTagi[0]) + 1 == Convert.ToInt32(RuutupuoliTagi[0]) && RuutupuoliTagi[2] == "Valkoinen" && RuutupuoliTagi[3] == "Kuningas" ||
                                        Convert.ToInt32(puoliTagi[1]) + 1 == Convert.ToInt32(RuutupuoliTagi[1]) && Convert.ToInt32(puoliTagi[0]) - 1 == Convert.ToInt32(RuutupuoliTagi[0]) && RuutupuoliTagi[2] == "Valkoinen" && RuutupuoliTagi[3] == "Kuningas")
                                    {
                                        MessageBox.Show("Shakki");
                                    }
                                }
                                catch (Exception virhe)
                                {

                                }
                            }
                        }
                    }
                    else if (ValittuNappi == "MHeppa")
                    {
                        nappi.Image = MustaHeppa;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Musta,Heppa";
                        Hevonen hevonen = new Hevonen(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            try
                            {
                                if (hevonen.SallittuLiike(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && RuutupuoliTagi[2] == "Valkoinen" && RuutupuoliTagi[3] == "Kuningas")
                                {
                                    MessageBox.Show("Shakki");
                                }
                            }
                            catch (Exception virhe)
                            {

                            }
                        }
                    }
                    else if (ValittuNappi == "MTorni")
                    {
                        List<Button> SallitutLiikkeet = new List<Button>();
                        nappi.Image = MustaTorni;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Musta,Torni";
                        Torni torni = new Torni(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            try
                            {
                                if (torni.SallittuLiike(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && NappiTagi != ruutuTagi)
                                {
                                    SallitutLiikkeet.Add(ruutu);
                                }
                            }
                            catch (Exception virhe)
                            {

                            }
                        }
                        try
                        {
                            for (int looppi1 = 1; looppi1 < 9; looppi1++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[0] == puoliTagi[0])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                        {
                                            if (TestiPuoliTagi[2] == "Valkoinen" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi2 = 1; looppi2 < 9; looppi2++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[0] == puoliTagi[0])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                        {
                                            if (TestiPuoliTagi[2] == "Valkoinen" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi3 = 1; looppi3 < 9; looppi3++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[1] == puoliTagi[1])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi3)
                                        {
                                            if (TestiPuoliTagi[2] == "Valkoinen" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi4 = 1; looppi4 < 9; looppi4++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (TestiPuoliTagi[1] == puoliTagi[1])
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi4)
                                        {
                                            if (TestiPuoliTagi[2] == "Valkoinen" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                        }
                        catch
                        {

                        }
                    }
                    else if (ValittuNappi == "MLahetti")
                    {
                        List<Button> SallitutLiikkeet = new List<Button>();
                        nappi.Image = MustaLahetti;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Musta,Lahetti";
                        Lahetti lahetti = new Lahetti(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            try
                            {
                                if (lahetti.SallittuLiike(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && NappiTagi != ruutuTagi)
                                {
                                    SallitutLiikkeet.Add(ruutu);
                                }
                            }
                            catch (Exception virhe)
                            {

                            }
                        }
                        try
                        {
                            for (int looppi1 = 1; looppi1 < 9; looppi1++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi1)
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi1)
                                        {
                                            if (TestiPuoliTagi[2] == "Valkoinen" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi2 = 1; looppi2 < 9; looppi2++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi2)
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - looppi2)
                                        {
                                            if (TestiPuoliTagi[2] == "Valkoinen" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi3 = 1; looppi3 < 9; looppi3++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) + looppi3)
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) - looppi3)
                                        {
                                            if (TestiPuoliTagi[2] == "Valkoinen" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                            for (int looppi4 = 1; looppi4 < 9; looppi4++)
                            {
                                if (breakki)
                                {
                                    break;
                                }
                                foreach (Button testi in SallitutLiikkeet)
                                {
                                    string TestiTagi = testi.Tag.ToString();
                                    List<string> TestiPuoliTagi = TestiTagi.Split(',').ToList<string>();
                                    if (Convert.ToInt32(TestiPuoliTagi[1]) == Convert.ToInt32(puoliTagi[1]) - 1)
                                    {
                                        if (Convert.ToInt32(TestiPuoliTagi[0]) == Convert.ToInt32(puoliTagi[0]) + looppi4)
                                        {
                                            if (TestiPuoliTagi[2] == "Valkoinen" && TestiPuoliTagi[3] == "Kuningas")
                                            {
                                                MessageBox.Show("Shakki");
                                                breakki = true;
                                                break;
                                            }
                                            if (TestiPuoliTagi[2] == "Musta")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                            else if (TestiPuoliTagi[2] == "Valkoinen")
                                            {
                                                breakki = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            breakki = false;
                        }
                        catch
                        {

                        }
                    }
                    else if (ValittuNappi == "MKuningas")
                    {
                        nappi.Image = MustaKuningas;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Musta,Kuningas";
                    }
                    else if (ValittuNappi == "MKuningatar")
                    {
                        nappi.Image = MustaKuningatar;
                        string fag = nappi.Tag.ToString();
                        List<string> fagpuoliTagi = fag.Split(',').ToList<string>();
                        nappi.Tag = fagpuoliTagi[0] + "," + fagpuoliTagi[1] + "," + "Musta,Kuningatar";
                        Kuningatar kuningatar = new Kuningatar(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), "Musta");
                        foreach (Button ruutu in this.Controls)
                        {
                            string ruutuTagi = ruutu.Tag.ToString();
                            List<string> RuutupuoliTagi = ruutuTagi.Split(',').ToList<string>();
                            try
                            {
                                if (kuningatar.SallittuLiike(Convert.ToInt32(fagpuoliTagi[0]), Convert.ToInt32(fagpuoliTagi[1]), Convert.ToInt32(RuutupuoliTagi[0]), Convert.ToInt32(RuutupuoliTagi[1])) && RuutupuoliTagi[2] == "Valkoinen" && RuutupuoliTagi[3] == "Kuningas")
                                {
                                    MessageBox.Show("Shakki");
                                }
                            }
                            catch (Exception virhe)
                            {

                            }
                        }
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