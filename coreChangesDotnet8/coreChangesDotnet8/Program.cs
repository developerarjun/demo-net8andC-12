using System.Text.Json;
using System.Text.Json.Serialization;

namespace coreChangesDotnet8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Serializer
            var sampleJson = File.ReadAllText(@"C:\Users\DELL\Downloads\.net 8\sample.json");
            var newFoo = JsonSerializer.Deserialize<fooObject>(sampleJson);
            Console.WriteLine(newFoo?.Name);
            Console.WriteLine();

            #endregion

            #region Time abstraction
            var time = TimeProvider.System.GetLocalNow();
            Console.WriteLine(time);
            Console.WriteLine();

            #endregion

            #region Random and shuffle
            var names = new[]
            {
                "Arjun","Rahul","Ram", "Nick", "Amy", "Hari", "Rajan"
            };
            //new
            Console.WriteLine("--------Random----------");
            Random.Shared.Shuffle(names);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine("--------Genearte Random----------");
            var generateRandom = Random.Shared.GetItems(names, 50);
            foreach (var name in generateRandom)
            {
                Console.WriteLine(name);
            }
            #endregion

            #region C# 12
            var cSharp12 = new newChangeinCSharp12();
            cSharp12.demo();
            #endregion
        }
    }
    [JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Skip)]
    public class fooObject 
    { 
        public string Name { get; set; }
    }
}
