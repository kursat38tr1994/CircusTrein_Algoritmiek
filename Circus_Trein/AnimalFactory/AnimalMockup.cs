using Circus_Trein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    public class AnimalMockup
    {
        private static readonly List<Animal> _animals = new List<Animal>();


        public static List<Animal> TestCase1()
        {
            for (int i = 0; i < 10; i++)
            {
                _animals.Add(AnimalFactory.LargeCarnivore);
            }

            return _animals;
        }

        public static List<Animal> TestCase2()
        {
            _animals.Add(AnimalFactory.SmallCarnivore);
            for (var i = 0; i < 2; i++)
            {
                _animals.Add(AnimalFactory.LargeHerbivore);
            }
            
            for (var i = 0; i < 3; i++)
            {
                _animals.Add(AnimalFactory.MediumHerbivore);
            }
            
            return _animals;
        }
        
        public static List<Animal> TestCase3()
        {
            for (int i = 0; i < 2; i++)
            {
                _animals.Add(AnimalFactory.LargeCarnivore);
            }

            for (int i = 0; i < 3; i++)
            {
                _animals.Add(AnimalFactory.LargeHerbivore);
            }

            for (int i = 0; i < 2; i++)
            {
                _animals.Add(AnimalFactory.MediumHerbivore);   
            }
           
            _animals.Add(AnimalFactory.SmallCarnivore);

            return _animals;
        }
        
        public static List<Animal> TestCase4()
        {


            return _animals;
        }
        
        public static List<Animal> TestCase5()
        {
          

            return _animals;
        }
        
        public static List<Animal> TestCase6()
        {
         

            return _animals;
            
        }
        public static List<Animal> TestCase7()
        {
        

            return _animals;
        }
        public static List<Animal> TestCase8()
        {
           
            return _animals;
        }
        public static List<Animal> TestCase9()
        {
           

            return _animals;
        }
        
        public static List<Animal> TestCase10()
        {
            
            return _animals;
        }
    }
}