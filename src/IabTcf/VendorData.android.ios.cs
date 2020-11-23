using Xamarin.Essentials;

namespace GamesWithGravitas.IabTcf
{
    public partial class VendorData
    {
        public BinaryString Consents => new BinaryString(Preferences.Get(Keys.VendorConsents, string.Empty));
        public BinaryString LegitimateInterests => new BinaryString(Preferences.Get(Keys.VendorLegitimateInterests, string.Empty));
    }
}
