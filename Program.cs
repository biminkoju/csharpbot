using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace charpbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i am live");
            var bot = new Bot();
            bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}
