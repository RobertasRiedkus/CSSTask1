using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSSTask1.Interfaces
{
	public interface IWriter
	{
		Task WriteToFileAsync(string resultFolderPath, IEnumerable<string> data);
	}
}
