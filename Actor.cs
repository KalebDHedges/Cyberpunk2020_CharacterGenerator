using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020_CharacterGenerator
{
    internal class Actor
    {
        public Actor(Name name,
                     Role role,
                     Gender gender,
                     byte age,
                     Stats stats,
                     Skills skills,
                     Inventory equipment,
                     Inventory cybernetics,
                     Lifepath lifepath)
        {
            Name = name;
            Role = role;
            Gender = gender;
            Age = age;
            Stats = stats;
            Skills = skills;
            Equipment = equipment;
            Cybernetics = cybernetics;
            Lifepath = lifepath;
        }

        public Name Name { get; }
        public Role Role { get; }
        public Gender Gender { get; }
        public byte Age { get; }
        public Stats Stats { get; }
        public Skills Skills { get; }
        public Inventory Equipment { get; }
        public Inventory Cybernetics { get; }
        public Lifepath Lifepath { get; }

        public void Print()
        {
            string dividerBig = new ('=', 80);
            string dividerSmall = new ('-', 80);

            Console.WriteLine(dividerBig);
            Console.WriteLine($"| Name: {Name.GetFull()}\t| Role: {Role}\t| Gender: {this.Gender}| Age: {this.Age}\t|");

            Console.WriteLine(dividerBig);
            Console.WriteLine(Stats.ToString());
            Console.WriteLine(dividerSmall);
            Console.WriteLine(Skills.ToString());

            Console.WriteLine(dividerBig);
            Console.WriteLine(Equipment.ToString());
            Console.WriteLine(dividerSmall);
            Console.WriteLine(Cybernetics.ToString());

            Console.WriteLine(dividerBig);
            Console.WriteLine(Lifepath.ToString());
            Console.WriteLine(dividerBig);
        }
    }
}