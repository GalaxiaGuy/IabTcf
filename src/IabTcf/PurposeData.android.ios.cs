using Xamarin.Essentials;

namespace GamesWithGravitas.IabTcf
{
    public partial class PurposeData
    {
        public PurposeString Consents => new PurposeString(Preferences.Get(Keys.PurposeConsents, string.Empty));
        public PurposeString LegitimateInterests => new PurposeString(Preferences.Get(Keys.PurposeLegitimateInterests, string.Empty));
    }
}
