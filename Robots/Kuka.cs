using System;
using System.Text;

namespace Robotics
{
    /**
	 * @brief Robot Kuka
	 * Kuka potrafi wyprodukować każdy element metalowy o wadze mniejszej niż 2000 kg.
	 * Robot potrafi produkować części zarówno standardowe jak i dedykowane do specyficznych modeli aut.
	 * Sam robot jest metalowy i waży 1700 kg.
	 */
    public class Kuka : Robot
    {
        public override string GetName()
        {
            return "kuka";
        }

        public override double GetWeight()
        {
            return 1700;
        }
        public override bool Build(MetalPart p, bool verbose)
        {
            if (p.GetWeight() > 2000)
                return false;
            else
            {
                if (verbose)
                    Console.WriteLine("{0} tworzy metalowy element o nazwie {1} i rozmiarze {2} m do auta {3} ", GetName(), p.GetName(), p.GetWeight(), p.GetCar());
                return true;
            }
        }

        public override bool Build(RubberPart p, bool verbose)
        {
            return false;
        }
        public override bool GetBuilt(Robot r, bool verbose)
        {
            return r.Build(this, verbose);
        }
    }
}
