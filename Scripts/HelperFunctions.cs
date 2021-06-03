using System;
using System.Linq;

namespace DieGarage
{
    public static class HelperFunctions
    {
        public static string CreateNumberPlate(int _id)
        {
            var rnd = new Random(_id);
            var amountOfLetters = rnd.Next(2, 5);
            var amountOfNumbers = rnd.Next(1, 5);
            string s = RandomLetters(amountOfLetters, _id) + "-" +
                RandomNumbers(amountOfNumbers, _id);
            return s;
        }
        public static string RandomLetters(int length, int seed)
        {
            var rnd = new Random(seed);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
        public static string RandomNumbers(int length, int seed)
        {
            var rnd = new Random(seed);
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}
