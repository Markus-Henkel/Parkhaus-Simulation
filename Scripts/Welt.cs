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
            for (int i = 0; i < garage.kapazität; i++)
            {
                var fahrzeug = new Fahrzeug(i);
                ungeparkteFahrzeuge.Add(fahrzeug);
            }
        }
    }
}
