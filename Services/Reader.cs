using CSSTask1.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSSTask1.Services
{
	public class Reader : IReader
	{
		public async Task<string> ReadAsync(string url)
		{
			using (var client = new HttpClient())
			{
				return await client.GetStringAsync(url);
			}
		}
	}
}
