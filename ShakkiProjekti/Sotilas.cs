﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShakkiProjekti
{
    class Sotilas : Nappula
    {
        public Sotilas(int X, int Y, string U_Vari)
        {
            SijaintiX1 = X;
            SijaintiY1 = Y;
            Vari = U_Vari;          
            if(U_Vari == "Musta")
            {
                Kuva = Properties.Resources.ShakkiSolttu;
            }
        }

        public bool SallittuLiike(int AlotusX, int AlotusY ,int LopetusX, int LopetusY)
        {
            if (Vari == "Musta")
            {
                if (AlotusY == 2)
                {
                    if(AlotusY + 3 > LopetusY && AlotusX == LopetusX && LopetusY > AlotusY)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (AlotusY + 1 == LopetusY && AlotusX == LopetusX)
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
                if (AlotusY == 7)
                {
                    if (AlotusY - 3 < LopetusY && AlotusX == LopetusX && LopetusY < AlotusY)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
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
