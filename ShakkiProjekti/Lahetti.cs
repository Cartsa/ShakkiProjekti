using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShakkiProjekti
{
    class Lahetti : Nappula
    {

        public Lahetti(int X, int Y, string U_Vari)
        {
            SijaintiX1 = X;
            SijaintiY1 = Y;
            Vari = U_Vari;
            if (U_Vari == "Musta")
            {
                Kuva = Properties.Resources.ShakkiLahetti;
            }
        }

        public bool SallittuLiike(int AlotusX, int AlotusY, int LopetusX, int LopetusY)
        {
            if (AlotusX < LopetusX && AlotusY < LopetusY)
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
