﻿using System.Collections.Generic;

namespace DieGarage
{
    public class Garage
    {
        public List<Parkplatz> parkstellen;
        public int decks;
        public int parkstellenProDeck;
        public int kapazität;
        public int freiePlaetze;
        public int vergebenePlaetze;

        public Garage(int _decks,int _parkstellenProDeck)
        {
            decks = _decks;
            parkstellenProDeck = _parkstellenProDeck;
            kapazität = decks * parkstellenProDeck;
            freiePlaetze = kapazität;
            vergebenePlaetze = 0;
            parkstellen = new List<Parkplatz>();
            for (int i = 0; i < kapazität; i++)
            {
                var parkplatz = new Parkplatz();
                var a = (double)i / (double)parkstellenProDeck;
                parkplatz.etage = (int)a;
                parkstellen.Add(parkplatz);
            }
        }
    }
}
