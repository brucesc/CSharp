using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Bird : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "Bird";

        }

        public string GetAnimalSound()
        {
            return "Chirp Chirp";

        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
