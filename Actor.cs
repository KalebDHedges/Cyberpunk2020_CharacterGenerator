using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020_CharacterGenerator
{
    internal class Actor
    {
        public Actor(
            Name name,
            Role role,
            Gender gender,
            byte age,
            Stats stats,
            Skills skills,
            Inventory equipment,
            Inventory cybernetics)
        {
            _name = name;
            _role = role;
            _gender = gender;
            _age = age;
            _stats = stats;
            _skills = skills;
            _equipment = equipment;
            _cybernetics = cybernetics;
        }

        public Name Name() { return _name; }
        public Role Role() { return _role; }
        public Gender Gender() { return _gender; }
        public byte Age() { return _age; }
        public Stats Stats() { return _stats; }
        public Skills Skills() { return _skills; }
        public Inventory Equipment() { return _equipment; }
        public Inventory Cybernetics() { return _cybernetics; }

        public void Print()
        {
            string dividerBig = new ('=', 80);
            string dividerSmall = new ('-', 80);

            Console.WriteLine(dividerBig);
            Console.WriteLine($"| Name: {_name.GetFull()}\t| Role: {_role}\t| Gender: {_gender}| Age: {_age}\t|");

            Console.WriteLine(dividerBig);
            Console.WriteLine(_stats.ToString());
            Console.WriteLine(dividerSmall);
            Console.WriteLine(_skills.ToString());

            Console.WriteLine(dividerBig);
            Console.WriteLine(_equipment.ToString());
            Console.WriteLine(dividerSmall);
            Console.WriteLine(_cybernetics.ToString());

            Console.WriteLine(dividerBig);
        }

        private readonly Name _name;
        private readonly Role _role;
        private readonly Gender _gender;
        private readonly byte _age;
        private readonly Stats _stats;
        private readonly Skills _skills;
        private readonly Inventory _equipment;
        private readonly Inventory _cybernetics;
    }
}