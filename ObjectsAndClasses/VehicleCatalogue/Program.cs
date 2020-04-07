using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vechicle> cars = new List<Vechicle>();
            List<Vechicle> trucks = new List<Vechicle>();
            double averageCars = 0;
            double averageTrucs = 0;
            string cmd;
            while ((cmd=Console.ReadLine())!="End")
            {
                string[] cmdArgs = cmd.Split().ToArray();
                string type = cmdArgs[0];
                string model = cmdArgs[1];
                    string color = cmdArgs[2];
                int hp = int.Parse(cmdArgs[3]);
                Vechicle vechicle = new Vechicle(type,model,color,hp);
                if (type == "car")
                {
                    cars.Add(vechicle);
                    averageCars += hp;
                }
                else
                {
                    trucks.Add(vechicle);
                    averageTrucs += hp;

                }
            }
            while ((cmd = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = cmd;
                if(cars.Find(x=>x.Model==model)!=null)
                {
                    int indexModel = cars.FindIndex(x => x.Model == model);
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {cars[indexModel].Model}");
                    Console.WriteLine($"Color: {cars[indexModel].Color}");
                    Console.WriteLine($"Horsepower: {cars[indexModel].HorsePower}");
                }
                else
                {
                    int indexModel = trucks.FindIndex(x => x.Model == model);
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {trucks[indexModel].Model}");
                    Console.WriteLine($"Color: {trucks[indexModel].Color}");
                    Console.WriteLine($"Horsepower: {trucks[indexModel].HorsePower}");
                }
                
            }
           if(averageCars / cars.Count > 0&&averageTrucs/trucks.Count>0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCars / cars.Count:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucs / trucks.Count:f2}.");
            }
           else if(averageTrucs/trucks.Count>0&& averageCars / cars.Count <=0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucs / trucks.Count:f2}.");
            }
           else if(averageCars / cars.Count > 0&&averageTrucs/trucks.Count<=0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCars / cars.Count:f2}.");
            }
        }
        class Vechicle
        {
            public Vechicle(string type,string model, string color, int hP)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = hP;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
           
        }
    }
}
