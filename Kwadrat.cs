using System;
using System.Collections.Generic;
using System.Text;

namespace Kacper_Głowacki_Zadanie1
{
    public class Kwadrat : Prostokat // Klasa kwadrat dziedziczy po klasie prostokąt
    {

        public Kwadrat(double bok) : base(bok, bok)
        {
            
        }
        public override void Wypisywanie() // Nadpisujemy metodę Wypisywanie boka i bok b będą zawsze równe.
        {
            Console.WriteLine("Wymiary kwadratu to: "+boka+"x"+bokb);
        }
    }
}
