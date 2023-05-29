using System.Net.Cache;

namespace Cyberpunk2020_CharacterGenerator
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // 1. Load Data Files
            //   1.1 Load Lifepath from 'lifepath.dat'
            //   1.2 Load Names from 'names.dat'
            //   1.3 Load Equipment from 'equipment.dat'
            //   1.4 Load Cybernetics from 'cybernetics.dat'

            // 2. Start Generating Actor
            //   2.1 Gender
            //   2.2 Age
            //   2.3 Lifepath
            //     2.3.1 Origins and Personal Style
            //       2.3.1.1 Clothes
            //       2.3.1.2 Hairstyle
            //       2.3.1.3 Affections
            //       2.3.1.4 Ethnicity
            //
            //     2.3.2 Family Background
            //       2.3.2.1 Rank
            //       2.3.2.2 Parents
            //       2.3.2.3 Family Status
            //       2.3.2.4 Childhood
            //       2.3.2.5 Siblings
            //         2.3.2.5.1 Age difference
            //         2.3.2.5.2 Gender
            //         2.3.2.5.3 Feelings
            //
            //     2.3.3 Motivations
            //       2.3.3.1 Traits
            //       2.3.3.2 Person Valued Most
            //       2.3.3.3 Valued Most
            //       2.3.3.4 Valued Possession
            //       2.3.3.5 Feeling About Most People
            //
            //     2.3.4 Life Events (Repeat from age 16 to Age)
            //       2.3.4.1 Age Event Happened
            //       2.3.4.2 What Happened
            //
            //   2.4 Name (dependent on Ethnicity)
            //   2.5 Role (influences Stats and Skills)
            //   2.6 Stats
            //   2.7 Skills
            //   2.8 Equipment (Weapons and Armor)
            //   2.9 Cybernetics

            Name name       = new();            // Have to create the names.dat file before I can implement
            Role role       = (Role)Die.RollDie(0, Enum.GetNames(typeof(Role)).Length);
            Gender gender   = (Gender)Die.RollDie(0, Enum.GetNames(typeof(Gender)).Length);
            byte age        = (byte)Die.RollDie(14, 40);

            Stats stats = new();

            Skills skills = new();              // This will be a pain in the ass
            Inventory equipment = new();        // Have to create the equipment.dat file before I can implement
            Inventory cybernetics = new();      // Have to create the cybernetics.dat file before I can implement
            Lifepath lifepath = new();

            Actor actor = new(name, role, gender, age, stats, skills, equipment, cybernetics, lifepath);
        }
    }
}