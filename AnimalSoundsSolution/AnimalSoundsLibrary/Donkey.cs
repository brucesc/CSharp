using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Donkey : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "Donkey";

        }

        public string GetAnimalSound()
        {
            return "Hee Haaww";

        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
