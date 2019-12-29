using CSSTask1.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CSSTask1.Services
{
	public class Writer : IWriter
	{
		public async Task WriteToFileAsync(string resultFolderPath, IEnumerable<string> data)
		{
			Directory.CreateDirectory(resultFolderPath);
			using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultFolderPath, "Result.txt"), true))
			{
				foreach (string dataLine in data)
					await outputFile.WriteLineAsync(dataLine);
			}
		}
	}
}
