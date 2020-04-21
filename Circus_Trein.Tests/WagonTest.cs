using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circus_Trein.Tests
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void Cant_Add_Animal_To_Wagon_With_Same_Or_Bigger_Animal()
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(new Animal("Carnivore", AnimalSize.Large, AnimalDiet.Carnivore));


            Animal animal = new Animal("Hernivore", AnimalSize.Medium, AnimalDiet.Herbivore);
            var result = wagon.CanFitAnimal(animal);

            Assert.IsFalse(result);
        }


        [TestMethod]
        public void Can_Add_Animal_To_Full_Wagon()
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(new Animal("Carnivore", AnimalSize.Large, AnimalDiet.Herbivore));


            Animal animal = new Animal("Hernivore", AnimalSize.Medium, AnimalDiet.Herbivore);
            var result = wagon.CanFitAnimal(animal);

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void Cant_Add_Smaller_Animal_To_Wagon_With_Same_Or_Bigger_Animal()
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(new Animal("Carnivore", AnimalSize.Large, AnimalDiet.Herbivore));


            Animal animal = new Animal("Hernivore", AnimalSize.Large, AnimalDiet.Carnivore);
            var result = wagon.CanFitAnimal(animal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetAnimalList()
        {
           
        }
    }
}
