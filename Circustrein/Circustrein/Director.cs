using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Director
    {
        public Train Train { get; set; }
        public Director()
        {
            Train = new Train();
        }

        public void SortAndProcessAnimals(List<Animal> animals)
        {
            List<Animal> ascending = animals.OrderByDescending(a => a.AnimalDiet == Animal.Diet.Carnivore)
                           .ThenBy(a => a.AnimalSize)
                           .ToList();
            List<Animal> decending = animals.OrderByDescending(a => a.AnimalDiet == Animal.Diet.Carnivore)
                                       .ThenByDescending(a => a.AnimalSize)
                                       .ToList();

            List<Wagon> wagonCountAsc = Train.SortAnimals(ascending);
            List<Wagon> wagonCountDesc = Train.SortAnimals(decending);

            if (wagonCountAsc.Count < wagonCountDesc.Count)
            {
                Train.SortAnimals(ascending);
            }
        }
    }
}
