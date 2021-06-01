using System;
using System.Linq;

namespace DieGarage
{
    public static class HelperFunctions
    {
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
