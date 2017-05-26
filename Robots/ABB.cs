using System;
using System.Text;

namespace Robotics
{
    /**
	 * @brief Robot ABB
	 * ABB potrafi wyprodukować każdy element metalowy o wadze mniejszej niż 500 kg.
	 * Robot potrafi produkować tylko elementy standardowe (tj. uniwersalne).
	 * Sam robot jest metalowy i waży 1250 kg.
	 */
    public class ABB : Robot
    {

        public override string GetName()
        {
            return "abb";
        }

        public override double GetWeight()
        {
            return 1250;
        }

        public override bool Build(MetalPart p, bool verbose)
        {
            if (p.GetWeight() > 500 || p.GetCar() != Car.Standard)
                return false;
            else
            {
                if (verbose)
                    Console.WriteLine("{0} tworzy metalowy element o nazwie {1} i rozmiarze {2} m do auta {3} ",GetName(), p.GetName(), p.GetWeight(), p.GetCar());
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
