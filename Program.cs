using R504_TP01_Automobile.Core.Automobile;
using R504_TP01_Automobile.Core.Scooter;
using R504_TP01_Automobile.Factories;

Console.WriteLine("Please select the type of vehicle factory:");
Console.WriteLine("1. Electric Vehicle Factory");
Console.WriteLine("2. Essence Vehicle Factory");
string factoryChoice = Console.ReadLine();

IFabriqueVehicule factory = null;
switch (factoryChoice)
{
    case "1":
        factory = new FabriqueVehiculeElectricite();
        break;
    case "2":
        factory = new FabriqueVehiculeEssence();
        break;
    default:
        Console.WriteLine("Invalid selection.");
        return;
}

Console.WriteLine("Please select the type of vehicle:");
Console.WriteLine("1. Automobile");
Console.WriteLine("2. Scooter");
string vehicleChoice = Console.ReadLine();

switch (vehicleChoice)
{
    case "1":
        IAutomobile automobile = factory.CreeAutomobile();
        automobile.AfficherCaracteristiques();
        break;
    case "2":
        IScooter scooter = factory.CreeScooter();
        scooter.AfficherCaracteristiques();
        break;
    default:
        Console.WriteLine("Invalid selection.");
        break;
}