using System.Collections.Generic;
using System.Linq;
using Circus_Trein;

namespace circus_trein.ExtentionMethods
{
    public static class ExtentionMethods
    {
        public static List<string> CompareWagonAnimals(List<Wagon> wagons)
        {
            var animal = wagons.Select(x => x.ToString()).ToList();
            
            return animal;
        }
    }
}