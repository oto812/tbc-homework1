using System.Diagnostics;

namespace homework1.homework12;

public static class Menu
{
    public static Vehicle createdCar;
    
    public static void displayMenu()
    {
        Console.WriteLine("Enter which Category vehicle you want to create");
        Console.Write("1 -> Combat, 2-> Commercial, 3 -> Public, 4-> Sport : ");
        int category = Convert.ToInt32(Console.ReadLine());
        while (category < 1 || category > 4)
        {
            Console.WriteLine("please enter a valid category");
            category = Convert.ToInt32(Console.ReadLine());
        }

        int concretetype = -1;

        switch (category)
        {
            case 1: 
                Console.WriteLine("Enter concrete type of Combat transport");
                Console.Write("1 -> Tank, 2 -> BTR: ");
                concretetype = Convert.ToInt32(Console.ReadLine());
                while (concretetype < 1 || concretetype > 2)
                {
                    Console.WriteLine("please enter a valid type: ");
                    concretetype = Convert.ToInt32(Console.ReadLine());
                }
                break;
            case 2:
                Console.WriteLine("Enter concrete type of Commercial transport");
                Console.Write("1 -> Sedan, 2 -> Jeep, 3 -> Bicycle : ");
                concretetype = Convert.ToInt32(Console.ReadLine());
                while (concretetype < 1 || concretetype > 3)
                {
                    Console.WriteLine("please enter a valid type: ");
                    concretetype = Convert.ToInt32(Console.ReadLine());
                }
                break;
            case 3:
                Console.WriteLine("Enter concrete type of public transport");
                Console.Write("1 -> Bus, 2 -> Tram :  ");
                concretetype = Convert.ToInt32(Console.ReadLine());
                while (concretetype < 1 || concretetype > 2)
                {
                    Console.WriteLine("please enter a valid type: ");
                    concretetype = Convert.ToInt32(Console.ReadLine());
                }
                break;
            case 4: 
                Console.WriteLine("Enter concrete type of Sport transport");
                Console.WriteLine("1 -> Formula1, 2 -> RallyCar : ");
                concretetype = Convert.ToInt32(Console.ReadLine());
                while (concretetype < 1 || concretetype > 2)
                {
                    Console.WriteLine("please enter a valid type: ");
                    concretetype = Convert.ToInt32(Console.ReadLine());
                }
                break;
        }

        AskForParameters(category, concretetype);
    }

    public static void AskForParameters(int category, int concreteType)
    {
        if (concreteType == -1)
        {
            Console.WriteLine("Something went wrong");
            return;
        }
        
        Console.Write("Enter Make of vehicle : ");
        string make = Console.ReadLine();
        Console.Write("Enter model of vehicle : ");
        string model = Console.ReadLine();
        Console.Write("Enter year of vehicle : ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter MaxSpeed of vehicle : ");
        int maxSpeed = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter weight of vehicle : ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter engineType of vehicle");
        Console.WriteLine("1 -> combustion, 2 -> electric, 3 -> hybrid : ");
        EngineType engineType = (EngineType)Convert.ToInt32(Console.ReadLine());
        
        bool isEngineRunning = false;

        switch (category)
        {
            case 1:
                Console.Write("Enter MainWeapon of combat vehicle : ");
                string mainWeapon = Console.ReadLine();
                Console.Write("Enter MainWeapon Ammo amount :");
                int mainWeaponAmmo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Crew Capacity : ");
                int crewCapacity = Convert.ToInt32(Console.ReadLine());
                switch (concreteType)
                {
                    case 1:
                        Console.WriteLine("Enter Tank ArmorType : ");
                        string armorType = Console.ReadLine();
                        Console.WriteLine("does your Tank have protection system?");
                        Console.Write("0 -> No, 1 -> Yes : ");
                        int ps = Convert.ToInt32(Console.ReadLine());
                        bool hasProtectionSystem = ps == 1;

                        createdCar = new Tank(make,model,year,maxSpeed,weight,engineType,mainWeapon,mainWeaponAmmo,crewCapacity,armorType,hasProtectionSystem);
                        break;
                    case 2: 
                       Console.Write("Enter wheelConfiguration : ");
                       int conf = Convert.ToInt32(Console.ReadLine());
                       createdCar = new BTR(make,model,year,maxSpeed,weight,engineType,mainWeapon,mainWeaponAmmo,crewCapacity,conf);
                        break;
                }

                break;
            case 2:
                Console.Write("Enter passenger Seats for commercial vehicle : ");
                int seats = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Comfort Level ");
                Console.WriteLine("1 -> very low, 2 -> low, 3 -> medium, 4 -> high, 5 -> very high");
                ComfortLevel level = (ComfortLevel)Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter cargo capacity : ");
                int cargoCapacity = Convert.ToInt32(Console.ReadLine());
                switch (concreteType)
                {
                    case 1:
                        Console.WriteLine("Enter Trunk capacity : ");
                        int trunkCapacity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("does your sedan have sunroof : ");
                        Console.WriteLine("0 -> No, 1 -> Yes : ");
                        bool sunroof = Convert.ToInt32(Console.ReadLine()) == 1;
                        
                        createdCar = new Sedan(make,model,year,maxSpeed,weight,engineType,seats,level,cargoCapacity,trunkCapacity,sunroof);
                        break;
                    case 2:
                        Console.WriteLine("Does your Jeep has four wheel drive");
                        Console.Write("0 -> no, 1 -> Yes : ");
                        bool fourwheelDrive = Convert.ToInt32(Console.ReadLine()) == 1;
                        createdCar = new Jeep(make, model, year, maxSpeed, weight, engineType, seats, level,
                            cargoCapacity, fourwheelDrive);
                        break;
                    case 3:
                        Console.WriteLine("Enter number of gears for your bicycle");
                        int gears = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("does you bicycle have busket");
                        bool busket = Convert.ToInt32(Console.ReadLine()) == 1;
                        createdCar = new Jeep(make, model, year, maxSpeed, weight, engineType, seats, level, gears, busket);
                        break;
                }

                break;
            case 3:
                Console.Write("Enter Route with space in between them (example : firstStop secondStop thirdStop): ");
                string[] route = Console.ReadLine().Split(' ');
                Console.WriteLine("Enter cost of ride : ");
                int cost = Convert.ToInt32(Console.ReadLine());
                switch (concreteType)
                {
                    case 1:
                        Console.Write("Enter standing capacity of bus : ");
                        int standingCapacity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter starting hour : ");
                        int startingHour = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter ending hour : ");
                        int endingHour = Convert.ToInt32(Console.ReadLine());
                        
                        createdCar = new Bus(make,model,year,maxSpeed,weight,engineType,route,0,cost,standingCapacity,startingHour,endingHour);
                        break;
                    case 2:
                        Console.WriteLine("Enter number of cars for Tram : ");
                        int numOfCars = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("is Pantograph up ?");
                        Console.Write("0 -> no, 1 -> yes : ");
                        bool pantographUp = Convert.ToInt32(Console.ReadLine()) == 1;
                        createdCar = new Tram(make,model,year,maxSpeed,weight,engineType,route,0,cost,numOfCars,pantographUp);
                        break;
                }

                break;
            case 4:
                Console.Write("Enter Competition winnings : ");
                int competitionWinnings = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("is your car customized ?");
                Console.WriteLine("0 -> no, 1 -> yes ");
                bool customized = Convert.ToInt32(Console.ReadLine()) == 1;
                switch (concreteType)
                {
                    case 1:
                        Console.Write("Enter tire compound : ");
                        string tireCompound = Console.ReadLine();
                        Console.WriteLine("does your formula1 have DRS?");
                        Console.Write("0 -> no, 1 -> yes : ");
                        bool dRS = Convert.ToInt32(Console.ReadLine()) == 1;
                        createdCar = new Formula1(make,model,year,maxSpeed,weight,engineType,competitionWinnings,customized,tireCompound,dRS);
                        break;
                    case 2:
                        Console.WriteLine("Enter suspension type : ");
                        string suspensionType = Console.ReadLine();
                        Console.WriteLine("does your rally car has rollcage ?");
                        Console.Write("0 -> no, 1 -> yes : ");
                        bool hasRollCage = Convert.ToInt32(Console.ReadLine()) == 1;
                        createdCar = new RallyCar(make,model,year,maxSpeed,weight,engineType,competitionWinnings,customized,suspensionType,hasRollCage);
                        break;
                }

                break;



        }

        

    }
}