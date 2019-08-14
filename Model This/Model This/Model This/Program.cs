using System;
using System.Collections.Generic;

namespace Model_This
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Да приложа този замисъл, но с автопарковете. Да проверявам от кой вид автопарк и да пресмятам.
            После от всички автопаркове да извеждам броя превозни средства. :p

            foreach(var v in vehicles)
            {
                if(v is Car)
                {

                }
            }
            */

            List<Autopark> autoparks = new List<Autopark>();
            /*
            Console.WriteLine("Please set parking capacity of the both parkings");

            Console.Write("Public Transportation Autopark with maximum passengers capacity of: ");
            int capacityPassengers = int.Parse(Console.ReadLine());
            Console.Write("Logistic Autopark with maximum cargo weight of: ");
            double capacityCargoWeight = double.Parse(Console.ReadLine());
            
            Console.WriteLine();
            */
            Console.WriteLine($"What vehicle you want to create?\n" +
                  $"1.Car\n" +
                  $"2.Bus\n" +
                  $"3.Van\n");

            int typeVehicleCommand = int.Parse(Console.ReadLine());

            Console.WriteLine();

            while (typeVehicleCommand != 0)
            {
                if (typeVehicleCommand == 1)
                {
                    Console.Write("Power: ");
                    int power = int.Parse(Console.ReadLine());
                    Console.Write("Passengers: ");
                    int passengers = int.Parse(Console.ReadLine());
                    Console.Write("Cargo Weight: ");
                    int cargo = int.Parse(Console.ReadLine());

                    Car car = new Car(power, passengers, cargo);

                    Console.WriteLine();

                    Console.WriteLine($"Where would you like to park the vehicle?\n" +
                                        $"1.Public Transportation Autopark\n" +
                                        $"2.Logistic Autopark\n" +
                                        $"0.Exit\n");

                    int parkingVehicle = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    while (parkingVehicle != 0)
                    {

                        if(parkingVehicle == 1)
                        {
                            Autopark p = new PublicTransportationAutopark(car, car.maxPassenger);
                            autoparks.Add(p);

                        }else if(parkingVehicle == 2)
                        {
                            Autopark l = new LogisticAutopark(car, car.maxPassenger);
                            autoparks.Add(l);
                        }

                        Console.WriteLine($"Please write 0, to return to the first menu.");

                        parkingVehicle = int.Parse(Console.ReadLine());
                    }

                }
                else if (typeVehicleCommand == 2)
                {
                    Console.Write("Power: ");
                    int power = int.Parse(Console.ReadLine());
                    Console.Write("Passengers: ");
                    int passengers = int.Parse(Console.ReadLine());
                    Console.Write("Cargo Weight: ");
                    int cargo = int.Parse(Console.ReadLine());

                    Bus bus = new Bus(power, passengers, cargo);


                    Console.WriteLine($"Where would you like to park the vehicle?\n" +
                                        $"1.Public Transportation Autopark\n" +
                                        $"2.Logistic Autopark\n" +
                                        $"0.Exit\n");

                    int parkingVehicle = int.Parse(Console.ReadLine());

                    while (parkingVehicle != 0)
                    {

                        if (parkingVehicle == 1)
                        {

                            Autopark p = new PublicTransportationAutopark(bus,bus.maxPassenger);
                            autoparks.Add(p);

                        }
                        else if (parkingVehicle == 2)
                        {
                            Autopark l = new LogisticAutopark(bus,bus.maxPassenger);
                            autoparks.Add(l);
                        }

                        Console.WriteLine($"Please write 0, to return to the first menu.");

                        parkingVehicle = int.Parse(Console.ReadLine());
                    }
                }
                else if (typeVehicleCommand == 3)
                {
                    Console.Write("Power: ");
                    int power = int.Parse(Console.ReadLine());
                    Console.Write("Passengers: ");
                    int passengers = int.Parse(Console.ReadLine());
                    Console.Write("Cargo Weight: ");
                    int cargo = int.Parse(Console.ReadLine());

                    Van van = new Van(power, passengers, cargo);


                    Console.WriteLine($"Where would you like to park the vehicle?\n" +
                                        $"1.Public Transportation Autopark\n" +
                                        $"2.Logistic Autopark\n" +
                                        $"0.Exit\n");

                    int parkingVehicle = int.Parse(Console.ReadLine());

                    while (parkingVehicle != 0)
                    {

                        if (parkingVehicle == 1)
                        {

                            Autopark p = new PublicTransportationAutopark(van,van.maxPassenger);
                            autoparks.Add(p);

                        }
                        else if (parkingVehicle == 2)
                        {
                            Autopark l = new LogisticAutopark(van, van.maxPassenger);
                            autoparks.Add(l);
                        }

                        Console.WriteLine($"Please write 0, to return to the first menu.");

                        parkingVehicle = int.Parse(Console.ReadLine());
                    }
                }




                Console.WriteLine();

                Console.WriteLine($"What vehicle you want to create?\n" +
                                  $"1.Car\n" +
                                  $"2.Bus\n" +
                                  $"3.Van\n" +
                                  $"0.EXit(END OF PROGRAM!)\n");

                typeVehicleCommand = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            int counterPublic = 0;
            int counterLogistic = 0;

            int sumOfPassengers = 0;
            double sumOfCargo = 0;

            foreach (var v in autoparks)
            {
                
                if(v is PublicTransportationAutopark)
                {
                    counterPublic++;
                    sumOfPassengers += (int)v.MAX();
                }
                else if (v is LogisticAutopark)
                {
                    counterLogistic++;
                    sumOfCargo += v.MAX();
                }
            }

            Console.WriteLine($"The numbers of vehicles in Public Transportation Autopark is: {counterPublic}");
            Console.WriteLine($"The numbers of vehicles in Logistic Autopark is: {counterLogistic}");
            Console.WriteLine($"Maximum passengers in Public Transportation Autopark is: {sumOfPassengers}");
            Console.WriteLine($"Maximum cargo in Logistic Autopark is: {sumOfCargo}");

            Console.WriteLine($"Total vehicles in both parkings: {counterLogistic + counterPublic}");

        }
    }
}
