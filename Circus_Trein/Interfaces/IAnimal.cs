namespace Circus_Trein
{
    public interface IAnimal
    {
        AnimalDiet Diet { get; }
        string Name { get; }
        AnimalSize Size { get; }

        int GetSize();
        string ToString();
    }
}