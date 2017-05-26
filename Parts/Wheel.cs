using System;
using System.Text;

namespace Robotics
{
    public class Wheel : RubberPart
    {
        private double _size;

        public Wheel(Car car, double size) : base(car)
        {
            _size = size;
        }

        public override string GetName()
        {
            return "wheel";
        }

        public override double GetSize()
        {
            return _size;
        }
        public override bool GetBuilt(Robot r, bool verbose)
        {
            return r.Build(this, verbose);
        }
    }
}
