using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace unitests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Scenario_1()
        {
            List<Animal> animals = new List<Animal>();
            Director Director = new Director();

            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));

            Director.SortAndProcessAnimals(animals);

            Assert.AreEqual(2, Director.Train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario_2()
        {
            List<Animal> animals = new List<Animal>();
            Director Director = new Director();

            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Herbivore));

            Director.SortAndProcessAnimals(animals);

            Assert.AreEqual(2, Director.Train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario_3()
        {
            List<Animal> animals = new List<Animal>();
            Director Director = new Director();

            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));

            Director.SortAndProcessAnimals(animals);

            Assert.AreEqual(4, Director.Train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario_4()
        {
            List<Animal> animals = new List<Animal>();
            Director Director = new Director();

            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Herbivore));

            Director.SortAndProcessAnimals(animals);

            Assert.AreEqual(5, Director.Train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario_5()
        {
            List<Animal> animals = new List<Animal>();
            Director Director = new Director();

            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Herbivore));

            Director.SortAndProcessAnimals(animals);

            Assert.AreEqual(2, Director.Train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario_6()
        {
            List<Animal> animals = new List<Animal>();
            Director Director = new Director();

            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));

            Director.SortAndProcessAnimals(animals);

            Assert.AreEqual(3, Director.Train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario_7()
        {
            List<Animal> animals = new List<Animal>();
            Director Director = new Director();

            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));

            Director.SortAndProcessAnimals(animals);

            Assert.AreEqual(13, Director.Train.Wagons.Count);
        }

        [TestMethod]
        public void SortAnimalsTest()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(Animal.Size.Small, Animal.Diet.Carnivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));
            animals.Add(new Animal(Animal.Size.Large, Animal.Diet.Herbivore));

            train.SortAnimals(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void CanAddAnimalTest()
        {
            Wagon wagon = new Wagon();

            wagon.Contents.Add(new Animal(Animal.Size.Medium, Animal.Diet.Herbivore));
            wagon.Contents.Add(new Animal(Animal.Size.Small, Animal.Diet.Herbivore));

            Animal animal = new Animal(Animal.Size.Large, Animal.Diet.Herbivore);

            wagon.CanAddAnimal(animal);

            Assert.AreEqual(true, wagon.CanAddAnimal(animal));
        }

        [TestMethod]
        public void AddAnimalTest()
        {
            Wagon wagon = new Wagon();

            Animal animal = new Animal(Animal.Size.Large, Animal.Diet.Herbivore);

            wagon.AddAnimal(animal);
  
            bool animalInWagon = false;

            if (wagon.Contents.Contains(animal))
            {
                animalInWagon = true;
            }

            Assert.AreEqual(true, animalInWagon);
        }

        [TestMethod]
        public void WillEatEachotherTest()
        {
            Wagon wagon = new Wagon();

            Animal carnivore = new Animal(Animal.Size.Medium, Animal.Diet.Carnivore);
            wagon.Contents.Add(new Animal(Animal.Size.Small, Animal.Diet.Herbivore));

            bool result = carnivore.WillEatEachother(carnivore, wagon);

            Assert.AreEqual(true, result);
        }
    }
}
