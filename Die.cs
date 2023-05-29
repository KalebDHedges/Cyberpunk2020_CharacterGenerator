using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020_CharacterGenerator
{
    internal static class Die
    {
        public static int RollDie(int min, int max)
        {
            return _random.Next(min, max);
        }

        private static readonly Random _random = new();
    }
}
