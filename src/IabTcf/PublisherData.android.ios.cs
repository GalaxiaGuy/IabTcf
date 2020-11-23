using Xamarin.Essentials;

namespace GamesWithGravitas.IabTcf
{
    public partial class PublisherData
    {
        public PurposeString Consents => new PurposeString(Preferences.Get(Keys.PublisherConsents, string.Empty));
        public PurposeString LegitimateInterests => new PurposeString(Preferences.Get(Keys.PublisherLegitimateInterests, string.Empty));
        public CustomPurposeData Custom { get; } = new CustomPurposeData();
        public PublisherVendorRestrictions Restrictions { get; } = new PublisherVendorRestrictions();
    }
}
