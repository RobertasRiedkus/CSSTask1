using CSSTask1.Interfaces;
using CSSTask1.Services;
using System.Configuration;
using System.Threading.Tasks;

namespace CSSTask1
{
	class Program
	{
		static async Task Main(string[] args)
		{
			string webUrlToRead = ConfigurationManager.AppSettings.Get("WebUrlToRead");
			string resultFolderPath = ConfigurationManager.AppSettings.Get("ResultFolderPath");

			IReader reader = new Reader();
			IWriter writer = new Writer();
			ICharCounter charCounter = new CharCounter();

			var htmlSourceCode = await reader.ReadAsync(webUrlToRead);
			var result = charCounter.CountCharsInString(htmlSourceCode);
			await writer.WriteToFileAsync(resultFolderPath, result);
		}
	}
}
