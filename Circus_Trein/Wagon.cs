using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    public class Wagon
    {
        
        private List<Animal> animalsInWagon = new List<Animal>();
        private int maxSize = 10;


        // Kijkt of de Animal erin past en krijgt grootte terug
        public bool CanFitAnimal(Animal animalToAdd)
        {
            // Als er niet genoeg ruimte over is voor het dier
            if (GetEmptySize() < animalToAdd.GetSize())
            {
                return false;
            }
            // Als er een dier in de animalList zit die carnivore is en groter of gelijk is dan het dier dat je wilt toevoegen
            // Index groter dan -1 betekent dat er een dier is gevonden in de lijst
            if (animalsInWagon.FindIndex(a => a.Diet == AnimalDiet.Carnivore && a.Size >= animalToAdd.Size) > -1)
            {
                return false;
            }
            // Als je een carnivore toevoegt terwijl er in de wagon al een ander dier zit dat even groot of kleiner is
            if (animalsInWagon.FindIndex(a => a.Size <= animalToAdd.Size && animalToAdd.Diet == AnimalDiet.Carnivore) > -1)
            {
                return false;
            }

            return true;
        }

        public void AddAnimalToWagon(Animal animalToAdd)
        {

            Animal animal;

            animal = animalToAdd;
            try
            {
                
                if (CanFitAnimal(animal))
                {
                    animalsInWagon.Add(animal);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }



        private int GetEmptySize()
        {
            int size = maxSize;
            // De size van de animal wordt van de 10 afgetrokken
            for (int i = 0; i < animalsInWagon.Count; i++)
            {
                // De Animal size van de animal methode in de animal class wordt hier doorheen gelopen
                size -= animalsInWagon[i].GetSize();
            }

            // Return the size
            return size;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var animal in animalsInWagon)
            {
                result =  animal.ToString();
            }

            return result;
        }

        public List<Animal> GetAnimalsList()
        {
            return animalsInWagon;
        }
    }
}
