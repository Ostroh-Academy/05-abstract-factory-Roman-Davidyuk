using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    
    public interface IPlant
    {
        string Grow();
    }

    
    public class Potato : IPlant
    {
        public string Grow()
        {
            return "Growing a potato.";
        }
    }

    
    public class Tomato : IPlant
    {
        public string Grow()
        {
            return "Growing a tomato.";
        }
    }

    public interface IAnimal
    {
        string Feed();
    }

    
    public class Cow : IAnimal
    {
        public string Feed()
        {
            return "Feeding a cow.";
        }
    }

    
    public class Chicken : IAnimal
    {
        public string Feed()
        {
            return "Feeding a chicken.";
        }
    }

    public interface IFarmFactory
    {
        IPlant CreatePlant();
        IAnimal CreateAnimal();
    }

    
    public class VegetableFarm : IFarmFactory
    {
        public IPlant CreatePlant()
        {
            return new Potato();
        }

        public IAnimal CreateAnimal()
        {
            return new Cow();
        }
    }

    
    public class PoultryFarm : IFarmFactory
    {
        public IPlant CreatePlant()
        {
            return new Tomato();
        }

        public IAnimal CreateAnimal()
        {
            return new Chicken();
        }
    }
    public class Farmer
    {
        public Farmer(IFarmFactory factory)
        {
            var plant = factory.CreatePlant();
            Console.WriteLine(plant.Grow());

            var animal = factory.CreateAnimal();
            Console.WriteLine(animal.Feed());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Farmer(new VegetableFarm());

           Console.WriteLine();

            new Farmer(new PoultryFarm());

            Console.ReadKey();
        }
    }
}
