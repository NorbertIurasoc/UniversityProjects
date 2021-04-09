using System;

namespace AgendaPersonala
{
    class Program
    {
        static void Main(string[] args)
        {

            Activitati UnMeciDeFotbal = new Activitati();
            UnMeciDeFotbal.nume = "Fotbal";
            UnMeciDeFotbal.descriere = "O miuta cu baietii la Oradea!";
            UnMeciDeFotbal.dataoraincepere = new DateTime(2021, 05, 06, 15, 00, 00);

            Console.WriteLine(UnMeciDeFotbal.dataoraincepere);

            Console.ReadKey();
        }
    }
}
