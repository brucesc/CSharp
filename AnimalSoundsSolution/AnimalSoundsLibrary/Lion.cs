using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Lion : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "Lion";

        }

        public string GetAnimalSound()
        {
            return "Roooaaaaaaaaaaaarrrrrrrrrrrrr!";

        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
