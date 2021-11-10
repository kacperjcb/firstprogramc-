using System;
using System.Collections.Generic;
using System.Text;

namespace Kacper_Głowacki_Zadanie1
{
    public class Graniastoslup
    {
    
    public Graniastoslup(Figura2D figura, double wysokosc) 
    {
        this.wysokosc = wysokosc;
        this.podstawa = figura;

    }
    private double wysokosc;
    private Figura2D podstawa; //podstawa moze byc dowolną klasą ktora implementuje interfejs Figura2D np Kolo, Kwadrat, Prostokat

    public double GetPole()
    {
        return podstawa.GetPole() * 2 + podstawa.GetObwod() * wysokosc;
    }
        public double GetObjetosc()
        {
            return podstawa.GetPole()* wysokosc;
        }
        




    }
}
