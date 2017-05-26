using System;
using System.Text;

namespace Robotics
{
	public class Engine: MetalPart
	{
		private double _weight;

		public Engine (Car car, double weight) : base(car)
		{
			_weight = weight;
		}

		public override string GetName ()
		{
			return "engine";
		}

		public override double GetWeight()
		{
			return _weight;
		}
        public override bool GetBuilt(Robot r, bool verbose)
        {
            return r.Build(this, verbose);
        }
    }
}
