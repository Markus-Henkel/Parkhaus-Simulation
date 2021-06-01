using System;

namespace DieGarage
{
    public enum Fahrzeugart { Auto, Motorrad }
    public class Fahrzeug
    {
        public Fahrzeugart fahrzeugart;
        public string kennzeichen;
        public Fahrzeug(int _id)
        {
            var rnd = new Random(_id);
            fahrzeugart = (Fahrzeugart)rnd.Next(0, 2);
            kennzeichen = CreateKennzeichen(_id);
        }
        string CreateKennzeichen(int _id)
        {
            var rnd = new Random(_id);
            var amountOfLetters = rnd.Next(2, 5);
            var amountOfNumbers = rnd.Next(1, 5);
            string s = HelperFunctions.RandomLetters(amountOfLetters, _id) + "-" +
                HelperFunctions.RandomNumbers(amountOfNumbers,_id);
            return s;
        }
    }
}
