using System;

namespace Solid.FullExample.better
{
    public class SuperLoadVolumeComponent : VolumeComponent
    {
        public override void VolumeUp()
        {
            base.VolumeUp();

            if (true)
            {
                Console.WriteLine();
            }
        }
    }
}
