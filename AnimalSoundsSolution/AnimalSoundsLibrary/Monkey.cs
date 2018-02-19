using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Monkey : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "Monkey";

        }

        public string GetAnimalSound()
        {
            return "oo oo aa aa";

        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
