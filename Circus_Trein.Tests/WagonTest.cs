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
        private Wagon _wagons;

        [TestInitialize]
        public void NewWagons()
        {
            _wagons = new Wagon();
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
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Small_Carnivore_With_Small_Herbivore()
        {
            //var exception = false;

            // catch (WagonException)
            // {
            //     ex = true;
            // }
            //Assert.IsTrue(ex);
            _wagons.AddAnimalToWagon(AnimalFactory.SmallHerbivore);


            _wagons.AddAnimalToWagon(AnimalFactory.SmallCarnivore);
        }

        [TestMethod]
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Small_Carnivore_With_Small_Carnivore()
        {
            // Arrange
            _wagons.AddAnimalToWagon(AnimalFactory.SmallCarnivore);


            // Act
            _wagons.AddAnimalToWagon(AnimalFactory.SmallCarnivore);
        }

        [TestMethod]
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Medium_Carnivore_With_Small_Carnivore()
        {
            // Arrange
            _wagons.AddAnimalToWagon(AnimalFactory.MediumCarnivore);

            // Act
            _wagons.AddAnimalToWagon(AnimalFactory.SmallCarnivore);
        }


        [TestMethod]
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Medium_Carnivore_With_Small_Herbivore()
        {
            // Arrange
            _wagons.AddAnimalToWagon(AnimalFactory.MediumCarnivore);

            // Act
            _wagons.AddAnimalToWagon(AnimalFactory.SmallHerbivore);
        }


        [TestMethod]
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Medium_Carnivore_With_Medium_Carnivore()
        {
            // Arrange
            _wagons.AddAnimalToWagon(AnimalFactory.MediumCarnivore);

            // Act
            _wagons.AddAnimalToWagon(AnimalFactory.MediumCarnivore);
        }

        [TestMethod]
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Medium_Carnivore_With_Medium_Herbivore()
        {
            // Arrange
            _wagons.AddAnimalToWagon(AnimalFactory.MediumCarnivore);

            // Act
            _wagons.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
        }

        /// <summary>
        /// //////////////////////////////////////////////
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Large_Carnivore_With_Small_Herbivore()
        {
            // Arrange
            _wagons.AddAnimalToWagon(AnimalFactory.SmallHerbivore);

            // Act
            _wagons.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
        }


        [TestMethod]
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Large_Carnivore_With_Small_Carnivore()
        {
            // Arrange
            _wagons.AddAnimalToWagon(AnimalFactory.SmallCarnivore);

            // Act
            _wagons.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
        }


        [TestMethod]
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Large_Carnivore_With_Medium_Carnivore()
        {
            // Arrange
            _wagons.AddAnimalToWagon(AnimalFactory.MediumCarnivore);

            // Act
            _wagons.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
        }

        [TestMethod]
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Large_Carnivore_With_Medium_Herbivore()
        {
            // Arrange
            _wagons.AddAnimalToWagon(AnimalFactory.MediumHerbivore);

            // Act
            _wagons.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
        }

        [TestMethod]
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Large_Carnivore_With_Large_Herbivore()
        {
            // Arrange
            _wagons.AddAnimalToWagon(AnimalFactory.LargeHerbivore);

            // Act
            _wagons.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
        }

        [TestMethod]
        [ExpectedException(typeof(WagonException))]
        public void Cant_Add_Large_Carnivore_With_Large_Carnivore()
        {
            // Arrange
            _wagons.AddAnimalToWagon(AnimalFactory.LargeCarnivore);

            // Act
            _wagons.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
        }

        /// <summary>
        /// //////////////////////////////////////////////
        /// </summary>
        
        [TestMethod]
        public void Can_Add_Small_Herbivore_With_Small_Herbivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.SmallHerbivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.SmallHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }
        
        
        [TestMethod]
        public void Can_Add_Small_Herbivore_With_Medium_Herbivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.SmallHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }
        
        [TestMethod]
        public void Can_Add_Small_Herbivore_With_Large_Herbivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.SmallHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }
        
        [TestMethod]
        public void Can_Add_Medium_Herbivore_With_Small_Carnivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.SmallCarnivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }
        
        [TestMethod]
        public void Can_Add_Medium_Herbivore_With_Small_Herbivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.SmallHerbivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }
        
        
        [TestMethod]
        public void Can_Add_Medium_Herbivore_With_Medium_Herbivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }
        
        [TestMethod]
        public void Can_Add_Medium_Herbivore_With_Large_Herbivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.LargeHerbivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }
        
        
        [TestMethod]
        public void Can_Add_Large_Herbivore_With_Small_Herbivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.SmallHerbivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.LargeHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }

        [TestMethod]
        public void Can_Add_Large_Herbivore_With_Small_Carnivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.SmallCarnivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.LargeHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }
        
        [TestMethod]
        public void Can_Add_Large_Herbivore_With_Medium_Carnivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.MediumCarnivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.LargeHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }
        
        [TestMethod]
        public void Can_Add_Large_Herbivore_With_Medium_Herbivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.LargeHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }
        
        [TestMethod]
        public void Can_Add_Large_Herbivore_With_Large_Herbivore()
        {
            _wagons.AddAnimalToWagon(AnimalFactory.LargeHerbivore);
            var exception = true;

            try
            {
                _wagons.AddAnimalToWagon(AnimalFactory.LargeHerbivore);
            }
            catch (WagonException)
            {
                exception = false;
            }

            Assert.IsTrue(exception);
        }
        
    }
}