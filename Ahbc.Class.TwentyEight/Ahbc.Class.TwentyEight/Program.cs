using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.TwentyEight
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat { Owner = new Owner(), Age = 5};
            
            var cat2 = cat;

            cat2.Age = 3;

            Console.WriteLine(cat.Age);
            Console.ReadLine();
        }
    }

    public class Cat 
    {
        public int Age { get; set; }

        public Owner Owner { get; set; }

    }

    public class Owner
    {

    }
    
}
