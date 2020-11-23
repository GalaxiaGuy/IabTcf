namespace GamesWithGravitas.IabTcf
{
	public class PurposeString : BinaryString
	{
		public PurposeString(string rawValue) : base(rawValue)
		{
		}

		public bool this[Purpose purpose] => this[(int)purpose];
	}
}
