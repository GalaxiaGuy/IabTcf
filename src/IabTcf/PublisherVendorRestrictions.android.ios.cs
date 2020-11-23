using Xamarin.Essentials;

namespace GamesWithGravitas.IabTcf
{
	public class PublisherVendorRestrictions
	{
		public RestrictionString Get(Purpose purpose)
			=> new RestrictionString(Preferences.Get($"{Keys.PublisherRestrictions}{purpose}", string.Empty));

		public RestrictionString this[Purpose purpose] => Get(purpose);
	}
}
