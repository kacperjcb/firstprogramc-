using System;
using System.Collections.Generic;
using System.Text;

namespace Kacper_Głowacki_Zadanie1
{
    public class Trojkat: Figura2D
    {
        public double boka;
        public double h;
        public Trojkat(double boka,double h) 
        {
            this.boka = boka;
            this.h = h;
        }
        public void Wypisywanie()
        {
            Console.WriteLine("bok a wynosi: " + boka);
            Console.WriteLine("Wysokość wynosi: " + h);
       
        }
        public double GetPole()
        {
            return (boka * h)/2;
        }
        public double GetObwod()
        {
            return (404);
        }
    }

}
