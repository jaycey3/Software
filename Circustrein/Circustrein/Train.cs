using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public class Train
    {
        public List<Wagon> Wagons { get; set; }

        public Train()
        {
            Wagons = new List<Wagon>();
        }

        private bool WillEatEachother(Animal animal, Wagon wagon)
        {
            foreach (Animal wagonAnimal in wagon.Contents)
            {
                if (animal.Canibalism(wagonAnimal))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Wagon> SortAnimals(List<Animal> animals)
        {
            Wagons.Clear();
            foreach (Animal animal in animals)
            {
                if (Wagons.Count == 0)
                {
                    Wagons.Add(new Wagon());
                }

                bool animalAdded = false;

                foreach (Wagon wagon in Wagons)
                {
                    if (!wagon.CanAddAnimal(animal))
                    {
                        continue; 
                    }

                    if (WillEatEachother(animal,wagon))
                    {
                        continue;
                    }

                    wagon.AddAnimal(animal);
                    animalAdded = true;
                    break;
                }

                if (!animalAdded)
                {
                    Wagon wagon = new Wagon();
                    wagon.Contents.Add(animal);
                    Wagons.Add(wagon);
                }
            }

            return Wagons;
        }
    }
}
