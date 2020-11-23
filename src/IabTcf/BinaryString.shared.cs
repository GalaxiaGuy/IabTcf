namespace GamesWithGravitas.IabTcf
{
	public class BinaryString : ValueListString<bool>
	{
		public BinaryString(string rawValue) : base(rawValue)
		{
		}

		protected override bool ConvertValue(char arg) => arg == '1';
	}
}
