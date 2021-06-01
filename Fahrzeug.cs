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
            string s = "12345";
            return s;
        }
    }
}
