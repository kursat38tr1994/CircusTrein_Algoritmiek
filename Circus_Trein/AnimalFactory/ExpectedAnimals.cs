using System.Collections.Generic;

namespace Circus_Trein
{
    public class ExpectedAnimals
    {
        public static List<Wagon> ExpectedWagonAnimalsTestCase1()
        {
            List<Wagon> Wagons = new List<Wagon>();

            Wagon wagon1 = new Wagon();
            Wagon wagon2 = new Wagon();
            Wagon wagon3 = new Wagon();
            Wagon wagon4 = new Wagon();
            Wagon wagon5 = new Wagon();
            Wagon wagon6 = new Wagon();
            Wagon wagon7 = new Wagon();
            Wagon wagon8 = new Wagon();
            Wagon wagon9 = new Wagon();
            Wagon wagon10 = new Wagon();

            wagon1.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
            wagon2.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
            wagon3.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
            wagon4.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
            wagon5.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
            wagon6.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
            wagon7.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
            wagon8.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
            wagon9.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
            wagon10.AddAnimalToWagon(AnimalFactory.LargeCarnivore);

            Wagons.Add(wagon1);
            Wagons.Add(wagon2);
            Wagons.Add(wagon3);
            Wagons.Add(wagon4);
            Wagons.Add(wagon5);
            Wagons.Add(wagon6);
            Wagons.Add(wagon7);
            Wagons.Add(wagon8);
            Wagons.Add(wagon9);
            Wagons.Add(wagon10);

            return Wagons;
        }

        public static List<Wagon> ExpectedWagonAnimalsTestCase2()
        {
            var Wagons = new List<Wagon>();

            var wagon1 = new Wagon();
            for (var i = 0; i < 2; i++)
            {
                wagon1.AddAnimalToWagon(AnimalFactory.LargeHerbivore);
            }


            var wagon2 = new Wagon();
            for (var i = 0; i < 3; i++)
            {
                wagon2.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
            }
            wagon2.AddAnimalToWagon(AnimalFactory.SmallCarnivore);

            Wagons.Add(wagon1);
            Wagons.Add(wagon2);

            return Wagons;
        }
        
        public static List<Wagon> ExpectedWagonAnimalsTestCase3()
        {
            List<Wagon> Wagons = new List<Wagon>();

            Wagon wagon1 = new Wagon();
            wagon1.AddAnimalToWagon(AnimalFactory.LargeCarnivore);
            
            Wagon wagon2 = new Wagon();
            wagon2.AddAnimalToWagon(AnimalFactory.LargeCarnivore);

            Wagon wagon3 = new Wagon();
            for (int i = 0; i < 2; i++)
            {
                wagon3.AddAnimalToWagon(AnimalFactory.LargeHerbivore);
            }
            
            Wagon wagon4 = new Wagon();
            wagon4.AddAnimalToWagon(AnimalFactory.LargeHerbivore);
            wagon4.AddAnimalToWagon(AnimalFactory.MediumHerbivore);
            wagon4.AddAnimalToWagon(AnimalFactory.SmallCarnivore);
         
            
            Wagon wagon5 = new Wagon(); 
            wagon5.AddAnimalToWagon(AnimalFactory.MediumHerbivore);   
            
            
            Wagons.Add(wagon1);
            Wagons.Add(wagon2);
            Wagons.Add(wagon3);
            Wagons.Add(wagon4);
            Wagons.Add(wagon5);

            return Wagons;
        }
    }
}