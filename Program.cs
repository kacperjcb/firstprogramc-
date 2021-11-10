using System;

namespace Kacper_Głowacki_Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat prostokat = new Prostokat(2.5, 5);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Pole prostokąta: "+prostokat.GetPole()); 
            Console.WriteLine("Obwód prostokąta: "+prostokat.GetObwod());  
            prostokat.Wypisywanie(); // Wypisywanie boków prostokąta
            Kolo kolo = new Kolo();
            Console.WriteLine("---------------------------------------");
            kolo.SetPromien(3); //Dla odmiany tutaj użyłem Settera zamiast konstruktora aby pokazać, że tak też się da.
            Console.WriteLine("Pole Koła: " + kolo.GetPole());
            Console.WriteLine("Obwód Koła: " + kolo.GetObwod());
            Kwadrat kwadrat = new Kwadrat(2);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Pole kwadratu: "+kwadrat.GetPole());
            Console.WriteLine("Pole kwadratu: "+kwadrat.GetObwod());
            kwadrat.Wypisywanie(); // Wypisywanie boków kwadratu
            Console.WriteLine("---------------------------------------");
            Graniastoslup graniastoslup = new Graniastoslup(prostokat, 4);
            Console.WriteLine("Pole całkowite graniastosłupa o podstawie 2.5x5 i h=4: " +graniastoslup.GetPole());
            Console.WriteLine("Objętość graniastosłupa o podstawie 2.5x5 i h=4: " +graniastoslup.GetObjetosc());
            Brylywksztalcieklocka klocek = new Brylywksztalcieklocka(5);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Pole klocka 5x5x5: "+klocek.GetPole());
            Console.WriteLine("Objętość klocka 5x5x5: "+klocek.GetObjetosc());
            Console.WriteLine("---------------------------------------");
            Graniastoslup walec = new Graniastoslup(kolo,3);
            Console.WriteLine("Pole walca o promieniu 3 i wysokości 3: " + walec.GetPole());
            Console.WriteLine("Objętość walca o promieniu 3 i wysokości 3: " + walec.GetObjetosc());

            Trojkat tr = new Trojkat(3, 3);
            Console.WriteLine("Pole trójkąta wynosi: "+tr.GetPole());
            Graniastoslup trojkat3d = new Graniastoslup(tr, 4);
            Console.WriteLine("Objętość ostrosłupa prawidłowego trojkątnego: " + trojkat3d.GetObjetosc());









        }


    }
        }
    

