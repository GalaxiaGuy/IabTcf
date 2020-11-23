namespace GamesWithGravitas.IabTcf
{
	public class SpecialFeatureString : BinaryString
	{
		public SpecialFeatureString(string rawValue) : base(rawValue)
		{
		}

		public bool this[SpecialFeature feature] => this[(int)feature];
	}
}
