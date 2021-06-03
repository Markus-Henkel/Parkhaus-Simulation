using System.Collections.Generic;

namespace DieGarage
{
    public class World
    {
        public double time;
        public double speed = 1;
        public double timeBetweenParkingTries;
        public double parktime;
        public ParkingLot garage;
        public List<Vehicle> freeroamingCars;
        public int decks;
        public int placesPerDeck;
        public int amountOfCars;
        public double lastTimeCarParked;

        public World(int _decks, int _parkstellenPerDeck, int _fahrzeugeInWelt)
        {
            garage = new ParkingLot(_decks, _parkstellenPerDeck);
            freeroamingCars = new List<Vehicle>();
            var seedAdd = 0;
            for (int i = 0; i < _fahrzeugeInWelt; i++)
            {
                var car = new Vehicle(i);
                var numberPlate = car.numberPlate;
                while (!IsNumberPlateUnique(numberPlate))
                {
                    seedAdd++;
                    numberPlate = HelperFunctions.CreateNumberPlate(i + seedAdd);
                }
                car.numberPlate = numberPlate;
                freeroamingCars.Add(car);
            }
        }
        bool IsNumberPlateUnique(string numberPlate)
        {
            for (int i = 0; i < freeroamingCars.Count; i++)
            {
                if (numberPlate == freeroamingCars[i].numberPlate)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
