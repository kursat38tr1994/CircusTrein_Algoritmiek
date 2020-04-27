using System;
using System.Collections.Generic;
using System.Text;
using Holle_dolle_circus_trein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circus_Trein.Tests
{
        [TestClass]
        public class TrainTest
        {

            [TestMethod]
            public void No_Animals_Lead_To_0_Wagons()
            {
                Train train = new Train();

                var result = train.Getwagons();

                Assert.AreEqual(0, result.Count);

            }

            [TestMethod]
            public void One_Carni_Small__Herbi_Medium_Two_Herbi_Large_In_Ten_Wagons()
            {
                Train train = new Train();

                var animallist = AnimalFactory.TestCase2();
                train.AddAnimalsToWagons(animallist);

                var expected = AnimalFactory.ExpectedWagonAnimalsTestCase1();
                var actual = train.Getwagons();

                CollectionAssert.AreEqual(expected, actual);
                Assert.AreEqual(2, train.Getwagons().Count);
            }

            //[TestMethod]
            //public void Ten_Large_Carnivores_In_Ten_Wagons()
            //{
            //    Train train = new Train();

            //    var list = AnimalFactory.TestCase1();
            //    train.AddAnimalsToWagons(list);

            //    Assert.AreEqual(10, train.Getwagons().Count);
            //}
    }
}
