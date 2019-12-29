using CSSTask1.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CSSTask1.Services
{
	public class CharCounter : ICharCounter
	{
		public IEnumerable<string> CountCharsInString(string data)
		{
			return data.GroupBy(x => x).Select(x => $"{x.Key} = {x.Count()}").OrderBy(y => y);
		}
	}
}
