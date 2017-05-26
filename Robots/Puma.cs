using System;
using System.Text;

namespace Robotics
{
    /**
	 * @brief Robot puma
	 * Puma potrafi wyprodukować każdy element gumowy o rozmiarze nie przekraczającym 1.5 m
	 * Robot potrafi produkować części zarówno standardowe jak i dedykowane do specyficznych modeli aut.
	 * Sam robot jest metalowy i waży 3000 kg.
	 */
    public class Puma : Robot
    {
        public override string GetName()
        {
            return "puma";
        }

        public override double GetWeight()
        {
            return 3000;
        }
        public override bool Build(MetalPart p, bool verbose)
        {
            return false;
        }

        public override bool Build(RubberPart p, bool verbose)
        {
            if (p.GetSize() > 1.5)
                return false;
            else
            {
                if (verbose)
                    Console.WriteLine("{0} tworzy metalowy element o nazwie {1} i rozmiarze {2} m do auta {3} ",GetName(), p.GetName(), p.GetSize(), p.GetCar());
                return true;
            }
        }
        public override bool GetBuilt(Robot r, bool verbose)
        {
            return r.Build(this, verbose);
        }
    }
}
