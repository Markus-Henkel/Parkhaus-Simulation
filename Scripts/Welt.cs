using System.Collections.Generic;

namespace DieGarage
{
    public class Welt
    {
        public Garage garage;
        public List<Fahrzeug> ungeparkteFahrzeuge;

        public Welt(Einstellungen _einstellungen)
        {
            garage = new Garage(_einstellungen);
            ungeparkteFahrzeuge = new List<Fahrzeug>();
            var seedAdd = 0;
            for (int i = 0; i < _einstellungen.fahrzeugeInWelt; i++)
            {
                var fahrzeug = new Fahrzeug(i);
                var kennzeichen = fahrzeug.kennzeichen;
                while (!IsKennzeichenUnique(kennzeichen))
                {
                    seedAdd++;
                    kennzeichen = HelperFunctions.CreateKennzeichen(i + seedAdd);
                }
                fahrzeug.kennzeichen = kennzeichen;
                ungeparkteFahrzeuge.Add(fahrzeug);
            }
        }
        bool IsKennzeichenUnique(string kennzeichen)
        {
            for (int i = 0; i < ungeparkteFahrzeuge.Count; i++)
            {
                if (kennzeichen == ungeparkteFahrzeuge[i].kennzeichen)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
