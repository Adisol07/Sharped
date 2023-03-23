using Sharped;
using Sharped.Global;
namespace Demo1;
internal class Program
{
    public static void Main(string[] args)
    {
        Map<int> map = new Map<int>();
        map.Add("value1", 100);
        map.Add("value2", 500);

        Console.WriteLine("value1: " + map["value1"]);
        Console.WriteLine("value2: " + map["value2"]);
    }
}