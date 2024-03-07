using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Animal
    {
        public enum Size
        {
            Small=1,
            Medium=3,
            Large=5
        }

        public enum Diet
        {
            Carnivore,
            Herbivore
        }

        public Size AnimalSize { get; set; }
        public Diet AnimalDiet {  get; set; }

        public Animal(Size size, Diet diet)
        {
            AnimalSize = size;
            AnimalDiet = diet;
        }

        public override string ToString()
        {
            return AnimalSize.ToString() + " " + AnimalDiet.ToString();
        }

        public bool Canibalism(Animal animal)
        {
            return ((AnimalDiet == Diet.Carnivore && (int)AnimalSize >= (int)animal.AnimalSize) ||
                (animal.AnimalDiet == Diet.Carnivore && (int)animal.AnimalSize >= (int)AnimalSize));
        }
    }
}
