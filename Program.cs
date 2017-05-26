using System;
using System.Text;

namespace Robotics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // część 1
            Console.WriteLine("==> Tworzenie części potrzebnych dla serwisów samochodowych");

            Part[] partsForServices = new Part[]
            {
                new Bumper(Car.Bison, 2.0), 	// długi 2.0 m zderzak do Bisona
				new Engine(Car.Comet, 120.0), 	// lekki 120 kb silnik do Comet
				new Hood(Car.Mesa, 200.0), 		// standardowy dach o wadze 200 kg
				new Wheel(Car.Serrano, 40.0), 	// koło do Serrano o wadze 40 kg
				new Bumper(Car.Standard, 1.2) 	// standardowy zderzak, 1.2 m
			};

            Console.WriteLine("Lista elementów do wyprodukowania:");

            int index = 0;

            foreach (Part p in partsForServices)
                Console.WriteLine("[{0}] część '{1}' do '{2}'", ++index, p.GetName(), p.GetCar().ToString());

            Robot[] availableRobots = new Robot[] {
                new Puma(),
                new Kuka(),
                new ABB()
            };

            /* UZUPEŁNIJ */
            foreach (var part in partsForServices)
                foreach (var robot in availableRobots)
                    part.GetBuilt(robot, true);


            // część 2
            Console.WriteLine();
            Console.WriteLine("==> Wyznaczanie liczby robotów zdolnych do wyprodukowania poszczególnych części, o jakimkolwiek rozmiarze i jakiejkolwiek wadze");

            Part[] allPartTypes = new Part[] { new Bumper(Car.Standard, 0), new Engine(Car.Standard, 0), new Hood(Car.Standard, 0), new Wheel(Car.Standard, 0) };

            foreach (Part p in allPartTypes)
            {
                int partConstructionCapableRobots = 0;

                foreach (Robot r in availableRobots)
                    if (p.GetBuilt(r, false))
                        partConstructionCapableRobots++;

                Console.WriteLine("Liczba robotow mogących wyprodukować {0}: {1}", p.GetName(), partConstructionCapableRobots);
            }

            Console.WriteLine();

            // część 3
            Console.WriteLine("==> Wyprodukowanie robota drugiej generacji");

            foreach (Robot parent in new Robot[] { new ABB(), new Kuka(), new Puma() })
                foreach (Robot child in new Robot[] { new ABB(), new Kuka(), new Puma() })
                    child.GetBuilt(parent, true);
        }
    }
}
