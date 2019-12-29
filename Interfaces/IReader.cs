using System.Threading.Tasks;

namespace CSSTask1.Interfaces
{
	public interface IReader
	{
		Task<string> ReadAsync(string url);
	}
}
