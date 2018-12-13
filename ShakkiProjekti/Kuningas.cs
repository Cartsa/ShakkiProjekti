using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShakkiProjekti
{
    class Kuningas : Nappula
    {
        public Kuningas(int X, int Y, string U_Vari)
        {
            SijaintiX1 = X;
            SijaintiY1 = Y;
            Vari = U_Vari;
            if (U_Vari == "Musta")
            {
                Kuva = Properties.Resources.ShakkiKunkku;
            }
        }

        public bool SallittuLiike(int AlotusX, int AlotusY, int LopetusX, int LopetusY)
        {
                if (AlotusY + 1 == LopetusY && AlotusX + 1 == LopetusX || AlotusY - 1 == LopetusY && AlotusX - 1 == LopetusX || AlotusY + 1 == LopetusY && AlotusX - 1 == LopetusX || AlotusY - 1 == LopetusY && AlotusX + 1 == LopetusX)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
}
