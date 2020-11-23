using Xamarin.Essentials;

namespace GamesWithGravitas.IabTcf
{
    public partial class CustomPurposeData
    {
        public PurposeString Consents => new PurposeString(Preferences.Get(Keys.PublisherCustomPurposesConsents, string.Empty));
        public PurposeString LegitimateInterests => new PurposeString(Preferences.Get(Keys.PublisherCustomPurposesLegitimateInterests, string.Empty));
    }
}
