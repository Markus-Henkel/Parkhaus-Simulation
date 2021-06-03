using System.Collections.Generic;

namespace DieGarage
{
    public class Garage
    {
        public List<ParkingPlace> parkingPlaces;
        public int decks;
        public int placesPerDeck;
        public int capacity;
        public int freePlaces;
        public int occupiedPlaces;

        public Garage(int _decks,int _placesPerDeck)
        {
            decks = _decks;
            placesPerDeck = _placesPerDeck;
            capacity = decks * placesPerDeck;
            freePlaces = capacity;
            occupiedPlaces = 0;
            parkingPlaces = new List<ParkingPlace>();
            for (int i = 0; i < capacity; i++)
            {
                var parkingSpace = new ParkingPlace();
                var a = (double)i / (double)placesPerDeck;
                parkingSpace.deck = (int)a;
                parkingPlaces.Add(parkingSpace);
            }
        }
    }
}
