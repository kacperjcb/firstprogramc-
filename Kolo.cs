using System;
using System.Collections.Generic;
using System.Text;

namespace Kacper_Głowacki_Zadanie1
{
    class Kolo : Figura2D // Kolo dziedziczy metody GetPole i GetObwód z Figury2D
    {
        private double promien;
       

        public double GetPromien()
        {
            return promien;
        }
        public double GetPole()// Kola
        {
            return Math.Pow(promien,2)*3.14;
        }

        public double GetObwod() 
        {
            return 2 * 3.14 * promien;
        }
        
        public void SetPromien(double w)
        {
            if (w > 0)
                promien = w;
        }
      
        

    }
}
