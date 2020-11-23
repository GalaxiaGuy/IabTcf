using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GamesWithGravitas.IabTcf
{
	public abstract class ValueListString<T> : IReadOnlyList<T>
		where T : struct
	{
		public string RawValue { get; }
		public int Count => RawValue.Length;

		public ValueListString(string rawValue)
		{
			RawValue = rawValue;
			_values = new Lazy<List<T>>(() => rawValue.Select(ConvertValue).ToList().ToList());
		}

		private readonly Lazy<List<T>> _values;

		public T this[int index] => RawValue.Length > index ? ConvertValue(RawValue[index]) : default;

		public IEnumerator<T> GetEnumerator() => _values.Value.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => _values.Value.GetEnumerator();

		protected abstract T ConvertValue(char arg);
	}
}
