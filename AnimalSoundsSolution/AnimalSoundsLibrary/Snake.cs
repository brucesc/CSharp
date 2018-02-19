using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Snake : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "Snake";

        }

        public string GetAnimalSound()
        {
            return "ssssssssssssss";

        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
