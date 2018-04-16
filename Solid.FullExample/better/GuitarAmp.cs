namespace Solid.FullExample.better
{
    public class GuitarAmp : IGuitarAmp
    {
        private readonly IVolumeComponent _volumeComponent;
        private readonly IHeadphoneComponent _headphoneComponent;
        private readonly FootSwitcher _footswitcher;
        private readonly SpecialEffectComponent _specialEffectsComponent;

        public GuitarAmp(IVolumeComponent volumeComponent, IHeadphoneComponent headphoneComponent,
            FootSwitcher footswitcher, SpecialEffectComponent specialEffectsComponent)
        {
            _volumeComponent = volumeComponent;
            _headphoneComponent = headphoneComponent;
            _footswitcher = footswitcher;
            _specialEffectsComponent = specialEffectsComponent;
        }

        public void PlayAwesome()
        {
            _volumeComponent.VolumeUp();
            _volumeComponent.VolumeUp();

            _headphoneComponent.OutputToHeadphones();
            _footswitcher.HandleFootswitchPress();
            _specialEffectsComponent.AddSpecialEffect();
        }
    }
}
