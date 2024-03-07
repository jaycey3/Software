using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Wagon
    {
        private const int capacity = 10;
        public List<Animal> Contents { get; set; }

        public Wagon()
        {
            Contents = new List<Animal>();
        }

        public bool CanAddAnimal(Animal animal)
        {
            int animalSize = (int)animal.AnimalSize;
            int wagonContents = 0;

            foreach (Animal animalInWagen in Contents)
            {
                wagonContents += (int)animalInWagen.AnimalSize;
            }

            if (wagonContents >= capacity || wagonContents + animalSize > capacity) 
            { 
                return false;
            } else
            {
                return true;
            }
        }

        public void AddAnimal(Animal a)
        {
            Contents.Add(a);
        }
    }
}
