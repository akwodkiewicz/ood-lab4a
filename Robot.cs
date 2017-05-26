using System;
using System.Text;

namespace Robotics
{
    /**
	 * @brief Klasa robota, w szczególności sam jest częścią metalową którą można wyprodukować
	 */
    public abstract class Robot : MetalPart
    {
        public Robot() : base(Car.Standard) { }
        public abstract bool Build(MetalPart p, bool verbose);
        public abstract bool Build(RubberPart p, bool verbose);
    }
}
