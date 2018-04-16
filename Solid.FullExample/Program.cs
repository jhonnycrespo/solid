using Solid.FullExample.better;
using GuitarAmp = Solid.FullExample.better.GuitarAmp;

namespace Solid.FullExample
{

    class Program
    {
        static void Main(string[] args)
        {
            var guitarAmp = new GuitarAmp(new SuperLoadVolumeComponent(), new HeadphoneComponent(), new FootSwitcher(), new SpecialEffectComponent());
        }
    }
}
