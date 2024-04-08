using System;

abstract class Spacecraft
{
    public abstract void Launch();
}
class SpacecraftForPlanetWithAtmosphere : Spacecraft
{
    public override void Launch()
    {
        Console.WriteLine("Корабель для планети з густою атмосферою стартує.");
    }
}
class SpacecraftForPlanetWithoutAtmosphere : Spacecraft
{
    public override void Launch()
    {
        Console.WriteLine("Корабель для планети без атмосфери стартує.");
    }
}
class SpacecraftForHighGravityPlanet : Spacecraft
{
    public override void Launch()
    {
        Console.WriteLine("Корабель для планети з високою гравітацією стартує.");
    }
}
abstract class SpacecraftFactory
{
    public abstract Spacecraft CreateSpacecraft();
}
class SpacecraftForPlanetWithAtmosphereFactory : SpacecraftFactory
{
    public override Spacecraft CreateSpacecraft()
    {
        return new SpacecraftForPlanetWithAtmosphere();
    }
}
class SpacecraftForPlanetWithoutAtmosphereFactory : SpacecraftFactory
{
    public override Spacecraft CreateSpacecraft()
    {
        return new SpacecraftForPlanetWithoutAtmosphere();
    }
}
class SpacecraftForHighGravityPlanetFactory : SpacecraftFactory
{
    public override Spacecraft CreateSpacecraft()
    {
        return new SpacecraftForHighGravityPlanet();
    }
}

class Program
{
    static void Main(string[] args)
    {
    
            Console.WriteLine("Оберіть тип планети (введіть відповідний номер):");
            Console.WriteLine("1. Планета з густою атмосферою");
            Console.WriteLine("2. Планета без атмосфери");
            Console.WriteLine("3. Планета з високою гравітацією");

            int choice = int.Parse(Console.ReadLine());

            SpacecraftFactory factory;

            switch (choice)
            {
                case 1:
                    factory = new SpacecraftForPlanetWithAtmosphereFactory();
                    break;
                case 2:
                    factory = new SpacecraftForPlanetWithoutAtmosphereFactory();
                    break;
                case 3:
                    factory = new SpacecraftForHighGravityPlanetFactory();
                    break;
                default:
                    throw new ArgumentException("Неправильний вибір.");
            }

            Spacecraft spacecraft = factory.CreateSpacecraft();
            spacecraft.Launch();
        
    }
}
