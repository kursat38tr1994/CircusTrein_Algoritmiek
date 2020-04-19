using System.Collections.Generic;

namespace Circus_Trein
{
    public interface ITrain
    {
        void AddAnimalsToWagons(List<IAnimal> animalQueueList);
        List<IWagon> Getwagons();
    }
}