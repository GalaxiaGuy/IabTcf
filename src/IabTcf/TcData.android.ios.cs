using Xamarin.Essentials;

namespace GamesWithGravitas.IabTcf
{
	public partial class TcData
	{
		public int ConsentManagementPlatformSdkId => Preferences.Get(Keys.ConsentManagementPlatformSdkId, -1);
		public int ConsentManagementPlatformSdkVersion => Preferences.Get(Keys.ConsentManagementPlatformSdkVersion, -1);
		public int PolicyVersion => Preferences.Get(Keys.PolicyVersion, -1);

		public bool? GdprApplies => SafeGetNullableBool(Keys.GdprApplies);
		public string PublisherCountryCode => Preferences.Get(Keys.PublisherCountryCode, "AA");
		public bool UseNonStandardStacks => SafeGetBool(Keys.UseNonStandardStacks);
		public PurposeOneTreatment PurposeOneTreatment => SafeGetBool(Keys.PurposeOneTreatment) ? PurposeOneTreatment.NotDisclosed : PurposeOneTreatment.NotDisclosed;

		public PurposeData Purpose { get; } = new PurposeData();
		public VendorData Vendor { get; } = new VendorData();
		public PublisherData Publisher { get; } = new PublisherData();

		public string TransparencyAndConsentFullString => Preferences.Get(Keys.TransparencyAndConsentFullString, string.Empty);

		public SpecialFeatureString SpecialFeatureOptIns => new SpecialFeatureString(Preferences.Get(Keys.SpecialFeatureOptIns, string.Empty));

		private bool? SafeGetNullableBool(string key) => (Preferences.Get(key, -1)) switch
		{
			0 => false,
			1 => true,
			_ => null,
		};

		private bool SafeGetBool(string key) => Preferences.Get(key, 0) == 1;
	}
}
