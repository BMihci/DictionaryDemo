using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
		numberNames.Add(1,"Bir"); 
		numberNames.Add(3,"Üç");
		numberNames.Add(5,"Beş");
		
		foreach(KeyValuePair<int, string> kvp in numberNames)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

		var Sehirler = new Dictionary<string, string>(){
			{"UK","London, Manchester, Birmingham"},
			{"RU","Moscow, St.Petersburg, Kaliningrad"},
			{"TR","Adana, Istanbul, Ankara"}
		};
		
		foreach(var kvp in Sehirler)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
