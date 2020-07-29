using System.Collections.Generic;
using System;
using System.Linq;

namespace ex3
{
    public class Animal
    {
        public int[] DNA = new int[3];
        public string Spicie { get; set; }
        private EnumAnimalClass AnimalClass { get; set; }
        private EnumDiet Diet { get; set; }
        private EnumFeets Feets { get; set; }


        private void SetDNA(int animalClass, int diet, int feets)
        {
            DNA[0] = animalClass;
            DNA[1] = diet;
            DNA[2] = feets;
        }

        public Animal(string spicie, EnumAnimalClass animalClass, EnumDiet diet, EnumFeets feets)
        {
            Spicie = spicie;
            AnimalClass = animalClass;
            Diet = diet;
            Feets = feets;

            SetDNA((int)AnimalClass, (int)Diet, (int)Feets);
        }

        public static string FindAnimal(List<Animal> animals, int[] sel)
        {


            foreach (var animal in animals)
            {
                if (sel[0] == animal.DNA[0] && sel[1] == animal.DNA[1] && sel[2] == animal.DNA[2])
                {
                    return $"{animal.Spicie}!! animal encontrado - {animal.AnimalClass} - {animal.Diet} - {animal.Feets}";
                }
            }

            return "Nenhum animal encontrado";
        }
    }

}