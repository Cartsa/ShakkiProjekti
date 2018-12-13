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
        int juu;
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
            juu = 0;
            for(int i = 0; i < 9; i++)
            {
                if (AlotusX + i == LopetusX && AlotusY + i == LopetusY ||
                    AlotusX + i == LopetusX && AlotusY - i == LopetusY ||
                    AlotusX - i == LopetusX && AlotusY + i == LopetusY ||
                    AlotusX - i == LopetusX && AlotusY - i == LopetusY)
                {
                    juu = 1;
                }           
            }
            if(juu == 1)
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
