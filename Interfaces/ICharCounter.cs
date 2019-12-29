using System.Collections.Generic;

namespace CSSTask1.Interfaces
{
	public interface ICharCounter
	{
		IEnumerable<string> CountCharsInString(string data);
	}
}
