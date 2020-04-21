using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circus_Trein.Tests
{
    public class TrainTest
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void AddAnimalToWagon() 
            {
                List<Animal> animals = new List<Animal>();
                Train train = new Circus_Trein.Train();

                animals.Add(new Animal("Animal", AnimalSize.Large, AnimalDiet.Herbivore));
                animals.Add(new Animal("Animal", AnimalSize.Large, AnimalDiet.Herbivore));
                animals.Add(new Animal("Animal", AnimalSize.Small, AnimalDiet.Carnivore));
                animals.Add(new Animal("Animal", AnimalSize.Medium, AnimalDiet.Herbivore));
                animals.Add(new Animal("Animal", AnimalSize.Medium, AnimalDiet.Herbivore));
                animals.Add(new Animal("Animal", AnimalSize.Medium, AnimalDiet.Herbivore));

                train.AddAnimalsToWagons(animals);

                Assert.AreEqual(2, train.Getwagons().Count);
            }
        }
    }
}
