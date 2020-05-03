using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    public enum AnimalSize { Small = 1, Medium = 3, Large = 5 }
    public enum AnimalDiet { Carnivore, Herbivore }

    public class Animal
    {
        public string Name { get; private set; }
        public AnimalSize Size { get; private set; }
        public AnimalDiet Diet { get; private set; }

        public Animal(string name, AnimalSize size, AnimalDiet diet)
        {
            this.Name = name;
            this.Size = size;
            this.Diet = diet;
        }

        public Animal()
        {
         
        }

        public int GetSize()
        {
            return (int)Size;
        }

        public override string ToString()
        {
            return $"{Name} - {Size} - {Diet}";
        }
    }
}
