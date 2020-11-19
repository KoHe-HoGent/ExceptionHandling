using System;

namespace ExceptionHandling
{
    class cats
        //2. Voorzie een Cat class met een int property: Age.
            //Maak een eigen error type CustomCatError aan dat overerft van System.ApplicationException.
            //Maak een lijst van Catobjecten aan, geef deze lijst door aan een method die de leeftijd van de katten controleert en CustomCatError opwerpt indien er een object is met leeftijd gelijk aan of kleiner dan 0.
            //Vang dergelijke exceptions op.
    {
        public class Cat
        {
            public int Age { get; set; }
        }

        internal class CustomCatError : Exception
        {
            public CustomCatError()
            {

            }

            public CustomCatError(string message) : base(message)
            {

            }

            public CustomCatError(string message, Exception innerException) : base(message, innerException)
            {

            }
        }

        private static void AgeCheck(Cat cat)
        {
            if (cat.Age < 1) 
            {
                throw new CustomCatError();
            }
        }
        static void MainCats()
        {
            Cat cat1 = new Cat { Age = -1 };
            Cat cat2 = new Cat { Age = 1 };
            Cat cat3 = new Cat { Age = 10 };
            Cat cat4 = new Cat { Age = -10 };
            Cat[] catLijst = { cat1, cat2, cat3, cat4 };

            foreach (Cat cat in catLijst)
            {
                try
                {
                    AgeCheck(cat);
                }
                catch(CustomCatError)
                {
                    Console.WriteLine($"{cat}'s Age is 0 of lager: {cat.Age}");
                }
            }
        }
    }
}
