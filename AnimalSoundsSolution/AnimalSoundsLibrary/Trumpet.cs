using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Trumpet : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "Trumpet";

        }

        public string GetAnimalSound()
        {
            return "whatever sound a trumpet makes...";

        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
