namespace Circus_Trein
{
    public class AnimalFactory
    {
        public static Animal SmallCarnivore => new Animal("CarnivoreSmall", AnimalSize.Small, AnimalDiet.Carnivore);
        public static Animal MediumCarnivore => new Animal("CarnivoreMedium", AnimalSize.Medium, AnimalDiet.Carnivore);
        public static Animal LargeCarnivore => new Animal("CarnivoreLarge", AnimalSize.Large, AnimalDiet.Carnivore);


        public static Animal SmallHerbivore => new Animal("HerbivoreSmall", AnimalSize.Small, AnimalDiet.Herbivore);
        public static Animal MediumHerbivore => new Animal("HerbivoreMedium", AnimalSize.Medium, AnimalDiet.Herbivore);
        public static Animal LargeHerbivore => new Animal("HerbivoreLarge", AnimalSize.Large, AnimalDiet.Herbivore);
    }
}