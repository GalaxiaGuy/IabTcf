namespace GamesWithGravitas.IabTcf
{
	public class RestrictionString : ValueListString<Restriction>
	{
		public RestrictionString(string rawValue) : base(rawValue)
		{
		}

		protected override Restriction ConvertValue(char arg)
		{
			return arg switch
			{
				'0' => Restriction.NotAllowed,
				'1' => Restriction.RequireConsent,
				'2' => Restriction.RequireLegitimateInterest,
				_ => Restriction.NotAllowed,
			};
		}

		public new Restriction? this[int vendorId] => RawValue.Length == 0 ? null : (Restriction?)base[vendorId];
	}
}
