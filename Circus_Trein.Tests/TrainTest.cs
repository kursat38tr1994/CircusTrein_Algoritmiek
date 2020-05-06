using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using circus_trein.ExtentionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circus_Trein.Tests
{
        [TestClass]
        public class TrainTest
        {

            [TestMethod]
            public void No_Animals_Lead_To_0_Wagons()
            {
                var train = new Train();

                var result = train.Getwagons();

                Assert.AreEqual(0, result.Count);

            }

            [TestMethod]
            public void One_Carni_Small__Herbi_Medium_Two_Herbi_Large_In_Ten_Wagons()
            {
                Train train = new Train();
                
                var animals = AnimalMockup.TestCase2();
                train.AddAnimalsToWagons(animals);

                ///////
              
                var train1 = ExpectedAnimals.ExpectedWagonAnimalsTestCase2();
                var train2 = train.Getwagons();

                var expected = ExtentionMethods.CompareWagonAnimals(train1);
                var actual = ExtentionMethods.CompareWagonAnimals(train2);
                
                
                CollectionAssert.AreEquivalent(expected, actual);
                Assert.AreEqual(2, train.Getwagons().Count);
                
            }

            [TestMethod]
            public void Ten_Large_Carnivores_In_Ten_Wagons()
            {
                var train = new Train();

                var list = AnimalMockup.TestCase1();
                train.AddAnimalsToWagons(list);

                var train1 = ExpectedAnimals.ExpectedWagonAnimalsTestCase1();
                var train2 = train.Getwagons();

                var expected = ExtentionMethods.CompareWagonAnimals(train1);
                var actual = ExtentionMethods.CompareWagonAnimals(train2);
                
                
                CollectionAssert.AreEquivalent(expected, actual);
                Assert.AreEqual(10, train.Getwagons().Count);
            }
            
            [TestMethod]
            public void Two_Carnivore_Large_Three_Herbivore_Large_Medium_Herbivore_Small_Carnivore_Medium_Herbivore_In_Five_Wagons2()
            {
                var train = new Train();

                var list = AnimalMockup.TestCase3();
                train.AddAnimalsToWagons(list);
    
                
                var train1 = ExpectedAnimals.ExpectedWagonAnimalsTestCase3();
                var train2 = train.Getwagons();
                
                var expected = ExtentionMethods.CompareWagonAnimals(train1);
                var actual = ExtentionMethods.CompareWagonAnimals(train2);
                
                
                CollectionAssert.AreEqual(expected, actual);
                Assert.AreEqual(5, train.Getwagons().Count);
            }
    }
}
