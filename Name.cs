using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020_CharacterGenerator
{
    internal class Name
    {
        // The empty constructor will be removed once the implementation is done
        public Name() { }

        public Name(string firstName, string lastName) {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string GetFirst() { return _firstName; }
        public string GetLast() { return _lastName;  }
        public string GetFull() { return _firstName + " " + _lastName; }

        private readonly string _firstName;
        private readonly string _lastName;
    }
}
