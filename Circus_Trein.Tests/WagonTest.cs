using System;
using System.Collections.Generic;
using System.Text;
using Circus_Trein.Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circus_Trein.Tests
{
    [TestClass]
    public class WagonTest
    {
        private  Wagon _wagons;

        [TestInitialize]
        public void NewWagons()
        {
            _wagons = new Wagon();
        }

        [TestMethod]
        public void Cant_Add_Animal_To_Wagon_With_Same_Or_Bigger_Animal()
        {
            _wagons.AddAnimalToWagon(new Animal("Carnivore", AnimalSize.Large, AnimalDiet.Carnivore));


            Animal animal = new Animal("Hernivore", AnimalSize.Medium, AnimalDiet.Herbivore);
            var result = _wagons.CanFitAnimal(animal);

            Assert.IsFalse(result);
        }


        [TestMethod]
        public void Can_Add_Animal_To_Full_Wagon()
        {
            Wagon wagon = new Wagon();
            _wagons.AddAnimalToWagon(new Animal("Carnivore", AnimalSize.Large, AnimalDiet.Herbivore));


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
        //[ExpectedException(typeof(WagonException))]
        public void asdasda()
        {
            var ex = false;
           _wagons.AddAnimalToWagon(AnimalFactory.MediumCarnivore);

           try
           {
               _wagons.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
           }
           catch (WagonException)
           {
               ex = true;
           }
           Assert.IsTrue(ex);
      
           
           
        }
    }
}
