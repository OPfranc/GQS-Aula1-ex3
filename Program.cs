using System;
using System.Collections.Generic;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();
            Populate(animals);

            int[] selection = new int[3];
            Console.Clear();
            Console.WriteLine("Escolha uma opção de classe: (1)Mamifero (2)Reptil (3)Ave");
            while (true)
            {
                int res = Convert.ToInt32(Console.ReadLine());
                if (res > 0 && res <= 3)
                {
                    selection[0] = res - 1;
                    break;
                }
            }
            Console.WriteLine("Escolha uma Opção de dieta: (1)Carnivoro (2)Herbivoro (3)Onivoro");
            while (true)
            {
                int res = Convert.ToInt16(Console.ReadLine());
                if (res > 0 && res <= 3)
                {
                    selection[1] = res -1 ;
                    break;
                }
            }
            Console.WriteLine("Escolha uma Opção de movimento: (1)Quadrupede (2)Bipede (3)Outro");
            while (true)
            {
                int res = Convert.ToInt16(Console.ReadLine());
                if (res > 0 && res <= 3)
                {
                    selection[2] = res -1 ;
                    break;
                }
            }
            Console.WriteLine(Animal.FindAnimal(animals, selection));
            Console.ReadKey();
        }

        static void Populate(List<Animal> animals)
        {

            Animal cavalo = new Animal("Cavalo", EnumAnimalClass.Mamifero, EnumDiet.Herbivoro, EnumFeets.Quadrupede);
            animals.Add(cavalo);
            Animal leao = new Animal("Leao", EnumAnimalClass.Mamifero, EnumDiet.Carnivoro, EnumFeets.Quadrupede);
            animals.Add(leao);
            Animal homem = new Animal("Homem", EnumAnimalClass.Mamifero, EnumDiet.Onivoro, EnumFeets.Bipede);
            animals.Add(homem);
            Animal macaco = new Animal("Macaco", EnumAnimalClass.Mamifero, EnumDiet.Herbivoro, EnumFeets.Bipede);
            animals.Add(macaco);

            Animal avestruz = new Animal("Avestruz", EnumAnimalClass.Ave, EnumDiet.Herbivoro, EnumFeets.Bipede);
            animals.Add(avestruz);
            Animal pinguim = new Animal("Pinguim", EnumAnimalClass.Ave, EnumDiet.Carnivoro, EnumFeets.Bipede);
            animals.Add(pinguim);
            Animal pato = new Animal("Pato", EnumAnimalClass.Ave, EnumDiet.Onivoro, EnumFeets.Bipede);
            animals.Add(pato);
            Animal aguia = new Animal("Aguia", EnumAnimalClass.Ave, EnumDiet.Carnivoro, EnumFeets.Bipede);
            animals.Add(aguia);

            Animal tartaruga = new Animal("Tartaruga", EnumAnimalClass.Reptil, EnumDiet.Onivoro, EnumFeets.Quadrupede);
            animals.Add(tartaruga);
            Animal crocodilo = new Animal("Crocodilo", EnumAnimalClass.Reptil, EnumDiet.Carnivoro, EnumFeets.Quadrupede);
            animals.Add(crocodilo);
            Animal cobra = new Animal("Cobra", EnumAnimalClass.Reptil, EnumDiet.Carnivoro, EnumFeets.Outro);
            animals.Add(cobra);
        }
    }
}
