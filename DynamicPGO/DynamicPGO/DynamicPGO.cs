using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DynamicPGO
{
    internal partial class DynamicPGO
    {
        static void Main()
        {
            var list = new List<int>();
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (true)
            {
                stopwatch.Restart();
                for (int i = 0; i < 1_000_000_000; i++)
                {
                    IsEmpty(list);
                }
                Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            }
        }
        [MethodImpl(MethodImplOptions.NoInlining)]
        static bool IsEmpty(IList<int> values) => values.Count != 0;
    }
}
