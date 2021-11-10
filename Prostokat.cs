using System;
using System.Collections.Generic;
using System.Text;

namespace Kacper_Głowacki_Zadanie1
{
    public class Prostokat : Figura2D // Prostokąt dziedziczy metody GetPole i GetObwód z Figury2D
    {
        public Prostokat(double boka,double bokb) 
        {
            this.boka = boka;
            this.bokb = bokb;
        }

        public double boka;
        public double bokb;

        virtual public void  Wypisywanie()
        {
            Console.WriteLine("bok a wynosi: " +boka);
            Console.WriteLine("bok b wynosi: " +bokb);
        }
        public double GetPole()
        {
            return boka * bokb;
        }
        public double GetObwod()
        {
            return boka * 2 + bokb * 2;
        }


    }
}
