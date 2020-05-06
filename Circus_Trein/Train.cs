using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    public class Train
    {
        private List<Wagon> wagons = new List<Wagon>();

        
        public void AddAnimalsToWagons(List<Animal> animalQueueList)
        {
            animalQueueList = animalQueueList.OrderByDescending(x => x.Size)
                .ThenByDescending(x => x.Diet == AnimalDiet.Carnivore).ToList();
            
           // ResetWagons();
            foreach (var animal in animalQueueList)
            {
                if (wagons.Count == 0)
                {
                    wagons.Add(new Wagon());
                }
                for (var i = 0; i < wagons.Count; i++)
                {
                 

                    if (wagons[i].CanFitAnimal(animal))
                    {
                        wagons[i].AddAnimalToWagon(animal);
                        break;
                    }

                    if (i != wagons.Count - 1) continue;
                    // Als het dier niet in de wagon past
                    wagons.Add(new Wagon());
                    wagons[wagons.Count - 1].AddAnimalToWagon(animal);
                    break;
                }
            }
        }

        public List<Wagon> Getwagons()
        {
            return wagons;
        }
    }
}