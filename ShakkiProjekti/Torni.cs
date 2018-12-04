﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShakkiProjekti
{
    class Torni
    {
        int SijaintiX;
        int SijaintiY;
        string Vari;
        bool Ylitys;
        Image Kuva;
        public Torni(int X, int Y, string U_Vari)
        {
            SijaintiX1 = X;
            SijaintiY1 = Y;
            Vari = U_Vari;
            if (U_Vari == "Musta")
            {
                Kuva = Properties.Resources.ShakkiTorni;
            }
        }

        public int SijaintiY1 { get => SijaintiY; set => SijaintiY = value; }
        public int SijaintiX1 { get => SijaintiX; set => SijaintiX = value; }

        public bool SallittuLiike(int AlotusX, int AlotusY, int LopetusX, int LopetusY)
        {
            if (Vari == "Musta")
            {
                if (AlotusY + 1 == LopetusY && AlotusX == LopetusX)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (Vari == "Valkoinen")
            {
                if (AlotusY - 1 == LopetusY && AlotusX == LopetusX)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}