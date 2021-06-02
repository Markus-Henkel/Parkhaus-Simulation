using System.Collections.Generic;

namespace DieGarage
{
    public class Welt
    {
        public double time;
        public double speed = 1;
        public int parkversucheProStunde;
        public double parkdauer;
        public Garage garage;
        public List<Fahrzeug> ungeparkteFahrzeuge;
        public int etagen;
        public int parkstellenProEtage;
        public int fahrzeugeInWelt;

        public Welt(int _decks, int _parkstellenPerDeck, int _fahrzeugeInWelt)
        {
            garage = new Garage(_decks, _parkstellenPerDeck);
            ungeparkteFahrzeuge = new List<Fahrzeug>();
            var seedAdd = 0;
            for (int i = 0; i < _fahrzeugeInWelt; i++)
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
