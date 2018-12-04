using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.TwentyFive
{
  public static class LinkedListExtensions
  {
    public static bool RemoveAt<T>(this LinkedList<T> list, int index)
    {
      return false;
    }
  }

  public class ExampleNode
  {
    public string Name { get; set; }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      // LinkedList
      var list = new LinkedList<ExampleNode>();
      list.AddFirst(new ExampleNode{ Name = "Jason" });
      list.AddLast(new ExampleNode{ Name = "Robert" });

      LinkedListExtensions.RemoveAt(list, 2);
      list.RemoveAt(2);

      var item = list.First;
      Console.WriteLine(item.Value.Name);
      item = item.Next;
      Console.WriteLine(item.Value.Name);

      // ConcurrentDictionary
      var dictionary = new ConcurrentDictionary<int, ExampleNode>();
      dictionary.TryAdd(1, new ExampleNode { Name = "Adam" });

      // Sorted
      
      // ReadOnly

      Console.ReadKey();
    }
  }
}
