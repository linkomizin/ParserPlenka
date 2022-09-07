// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using ParserPlenka;
using ParserPlenka.foqusstore;

Console.WriteLine("Hello, Parse!");


Foqusstore foqusstore = new Foqusstore();
foqusstore.AddRange();

Parser parser = new Parser(foqusstore.Site);

foreach (var plenka in foqusstore.Site.ListPlenkas)
{
    Thread.Sleep(3000);
    try
    {
        var result = parser.GetResult(plenka);
        Console.WriteLine(result.ToString());
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);

    }
}
  
  
  