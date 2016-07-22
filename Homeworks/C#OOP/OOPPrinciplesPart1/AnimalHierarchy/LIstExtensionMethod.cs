namespace AnimalHierarchy
{
    using System.Collections.Generic;
    public static class LIstExtensionMethod
    {
        public static int CalculateAverageAge(this List<Animal> animals)
        {
            int sumOfAges = 0;
            foreach (var animal in animals)
            {
                sumOfAges += animal.Age;
            }
            return sumOfAges /= animals.Count;

        }
    }
}