using Circus_Trein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holle_dolle_circus_trein
{
    public class AnimalFactory
    {
        private static readonly List<Animal> _animals = new List<Animal>();

        public static List<Animal> TestCase1()
        {
            for (int i = 0; i < 10; i++)
            {
                _animals.Add(new Animal("CarnivoreLarge", AnimalSize.Large, AnimalDiet.Carnivore));
            }

            return _animals;
        }

        public static List<Wagon> ExpectedWagonAnimalsTestCase2()
        {
            List<Wagon> Wagons = new List<Wagon>();

            Wagon wagon1 = new Wagon();
            wagon1.AddAnimalToWagon(new Animal("HerbivoreLarge", AnimalSize.Large, AnimalDiet.Herbivore));
            wagon1.AddAnimalToWagon(new Animal("HerbivoreLarge", AnimalSize.Large, AnimalDiet.Herbivore));


            Wagon wagon2 = new Wagon();
            wagon2.AddAnimalToWagon(new Animal("HerbivoreMedium", AnimalSize.Medium, AnimalDiet.Herbivore));
            wagon2.AddAnimalToWagon(new Animal("HerbivoreMedium", AnimalSize.Medium, AnimalDiet.Herbivore));
            wagon2.AddAnimalToWagon(new Animal("HerbivoreMedium", AnimalSize.Medium, AnimalDiet.Herbivore));
            wagon2.AddAnimalToWagon(new Animal("CarnivoreSmall", AnimalSize.Small, AnimalDiet.Carnivore));

            Wagons.Add(wagon1);
            Wagons.Add(wagon2);

            return Wagons;
        }

        public static List<Animal> TestCase2()
        {
            _animals.Add(new Animal("CarnivoreSmall", AnimalSize.Small, AnimalDiet.Carnivore));
            _animals.Add(new Animal("HerbivoreLarge", AnimalSize.Large, AnimalDiet.Herbivore));
            _animals.Add(new Animal("HerbivoreLarge", AnimalSize.Large, AnimalDiet.Herbivore));
            _animals.Add(new Animal("HerbivoreMedium", AnimalSize.Medium, AnimalDiet.Herbivore));
            _animals.Add(new Animal("HerbivoreMedium", AnimalSize.Medium, AnimalDiet.Herbivore));
            _animals.Add(new Animal("HerbivoreMedium", AnimalSize.Medium, AnimalDiet.Herbivore));

            return _animals;
        }
    }
}
