using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakkiProjekti
{
    class Poyta
    {
        //Valkoiset sotilaat
        Sotilas vSolttu1 = new Sotilas(1, 7, "Valkoinen");
        Sotilas vSolttu2 = new Sotilas(2, 7, "Valkoinen");
        Sotilas vSolttu3 = new Sotilas(3, 7, "Valkoinen");
        Sotilas vSolttu4 = new Sotilas(4, 7, "Valkoinen");
        Sotilas vSolttu5 = new Sotilas(5, 7, "Valkoinen");
        Sotilas vSolttu6 = new Sotilas(6, 7, "Valkoinen");
        Sotilas vSolttu7 = new Sotilas(7, 7, "Valkoinen");
        Sotilas vSolttu8 = new Sotilas(8, 7, "Valkoinen");

        //Mustat sotilaat
        Sotilas mSolttu1 = new Sotilas(1, 2, "Musta");
        Sotilas mSolttu2 = new Sotilas(2, 2, "Musta");
        Sotilas mSolttu3 = new Sotilas(3, 2, "Musta");
        Sotilas mSolttu4 = new Sotilas(4, 2, "Musta");
        Sotilas mSolttu5 = new Sotilas(5, 2, "Musta");
        Sotilas mSolttu6 = new Sotilas(6, 2, "Musta");
        Sotilas mSolttu7 = new Sotilas(7, 2, "Musta");
        Sotilas mSolttu8 = new Sotilas(8, 2, "Musta");

        //Valkoiset hevoset
        Hevonen vHeppa1 = new Hevonen(2, 8, "Valkoinen");
        Hevonen vHeppa2 = new Hevonen(7, 8, "Valkoinen");

        //Mustat hevoset
        Hevonen mHeppa1 = new Hevonen(2, 1, "Musta");
        Hevonen mHeppa2 = new Hevonen(7, 1, "Musta");

        //Valkoiset tornit
        Torni vTorni1 = new Torni(1, 8, "Valkoinen");
        Torni vTorni2 = new Torni(8, 8, "Valkoinen");

        //Mustat tornit
        Torni mTorni1 = new Torni(1, 1, "Musta");
        Torni mTorni2 = new Torni(8, 1, "Musta");

        //Valkoiset lähetit
        Torni vLahetti1 = new Torni(3, 8, "Valkoinen");
        Torni vLahetti2 = new Torni(6, 8, "Valkoinen");

        //Mustat lähetit
        Torni mLahetti1 = new Torni(3, 1, "Musta");
        Torni mLahetti2 = new Torni(6, 1, "Musta");
    }
}
