﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShakkiProjekti
{
    class Sotilas
    {
        int SijaintiX;
        int SijaintiY;
        string Vari;
        bool ylitys;
        public Sotilas(int X, int Y, string U_Vari)
        {
            SijaintiX = X;
            SijaintiY = Y;
            Vari = U_Vari;
            
        }
        public bool SallittuLiike(int AlotusX, int AlotusY ,int LopetusX, int LopetusY)
        {
            if(Vari == "Musta")
            {
                if (AlotusY + 1 == LopetusY)
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
                if (AlotusY - 1 == LopetusY)
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
