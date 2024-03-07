using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Circustrein;
using System.Collections.Generic;

namespace UnitTests
{   
    [TestClass]
    public class CircustreinTests
    {
        Director Director = new Director();

        [TestMethod]
        public void Scenario_1()
        {
            List<Animal> animals = new List<Animal>();

            Train train = new Train();

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

            Train train = new Train();

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

            Train train = new Train();

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

            Train train = new Train();

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

            Train train = new Train();

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

            Train train = new Train();

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

            Train train = new Train();

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
    }
}

