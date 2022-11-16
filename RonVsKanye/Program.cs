using Newtonsoft.Json.Linq; 
using System.Text.Json.Nodes;
using static RonVsKanye.RonVSKayneAPI;

var client = new HttpClient();
var ronVSKanye = new RonVSKanyeAPI(client);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Kanye: \"{ronVSKanye.KayneQuote()}.\"");
    Console.WriteLine();
    Thread.Sleep(500);
    Console.WriteLine($"Ron: {ronVSKanye.RonQuote()}");
    Console.WriteLine();
    Thread.Sleep(500);
}
