using System;

namespace ExceptionHandling
{
    class array
        //1. Maak een eenvoudige array van 3 integers.
            //Vraag de gebruiker welk array element getoond moet worden en toon dit element (houd er rekening mee dat de gebruiker vanaf 1 zal nummeren en niet vanaf 0). 
            //Zorg er met try/catch voor dat ongeldige invoer correct afgehandeld wordt en de gebruiker opnieuw een element kan kiezen.
            //Handel twee specifieke fouten af: IndexOutOfRangeException,FormatException.
    {
        static void Main()
        {
            int[] array = { 5, 10, 20 };
            int i;
            do {
                Console.WriteLine("element?: ");
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(array[i - 1]);
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is buiten bereik. Index moet een geheel getal zijn tussen 1 en 3");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Index is geen integer. Index moet een geheel getal zijn tussen 1 en 3");
                }
            }
            while (true);

        }
    }
}