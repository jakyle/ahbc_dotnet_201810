using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.Fifteen
{
  class Program
  {
    static void Main(string[] args)
    {
      //var path = "Something.txt";
      //File.Create(path);
      //File.ReadAllLines(path);
      //File.Delete(path);
      //
      //var info = new FileInfo(path);

      var directoryPath = @"C:\Jason\Repositories\gc\TestData";
      if (Directory.Exists(directoryPath) == false)
      {
        Directory.CreateDirectory(directoryPath);
      }

      var file = Path.Combine(directoryPath, "SomeLog.log");
      using (var writer = new StreamWriter(file))
      {
        writer.WriteLine("Down");
        writer.WriteLine("Here");
        writer.WriteLine("We");
        writer.WriteLine("Float");
      }

      using (var reader = new StreamReader(file))
      {
        string line;
        do
        {
          line = reader.ReadLine();
          Console.WriteLine(line);
        } while (line != null);
      }

      Console.ReadKey();
    }
  }
}
