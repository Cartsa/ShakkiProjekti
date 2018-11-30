using System;
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
        bool ylitys;
        Image solttu = Image.FromFile("Resources.ShakkiHeppa.png");
        int SallittuLiike;
        public Sotilas(int X, int Y)
        {
            SijaintiX = X;
            SijaintiY = Y;
        }
    }   
}
