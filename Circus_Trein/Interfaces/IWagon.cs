using System.Collections.Generic;

namespace Circus_Trein
{
    public interface IWagon
    {
        void AddAnimalToWagon(Animal animalToAdd);
        bool CanFitAnimal(Animal animalToAdd);
        List<Animal> GetAnimalsList();
    }
}