using System;
using System.Collections.Generic;
using System.Text;

namespace Kacper_Głowacki_Zadanie1
{
    public class Brylywksztalcieklocka : Graniastoslup
    {

        public Brylywksztalcieklocka(double bok) : base(new Kwadrat(bok), bok) // Użycie konstruktora z klasy bazowej(Graniastoslup)
        {
        }
    }
}
