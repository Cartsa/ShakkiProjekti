using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShakkiProjekti
{
    class Nappula
    {
        public int SijaintiX;
        public int SijaintiY;
        public string Vari;
        public Image Kuva;
        public Nappula()
        {
            SijaintiX1 = 1;
            SijaintiY1 = 1;
            Vari = "musta";
        }
        public int SijaintiY1 { get => SijaintiY; set => SijaintiY = value; }
        public int SijaintiX1 { get => SijaintiX; set => SijaintiX = value; }
    }
}
