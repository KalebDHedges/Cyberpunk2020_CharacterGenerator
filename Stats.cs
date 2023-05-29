using System.Runtime.InteropServices;

namespace Cyberpunk2020_CharacterGenerator
{
    internal class Stats
    {
        public Stats()
        {
            Intelligence    = (byte)Die.RollDie(3, 10);
            Reflexes        = (byte)Die.RollDie(3, 10);
            Cool            = (byte)Die.RollDie(3, 10);
            Technical       = (byte)Die.RollDie(3, 10);
            Luck            = (byte)Die.RollDie(3, 10);
            Attractiveness  = (byte)Die.RollDie(3, 10);
            Movement        = (byte)Die.RollDie(3, 10);
            Empathy         = (byte)Die.RollDie(3, 10);
            Body            = (byte)Die.RollDie(3, 10);
        }

        public byte Intelligence { get; init; }
        public byte Cool { get; init; }
        public byte Reflexes { get; init; }
        public byte Attractiveness { get; init; }
        public byte Technical { get; init; }
        public byte Luck { get; init; }
        public byte Body { get; init; }
        public byte Empathy { get; init; }
        public byte Movement { get; init; }
    }
}