// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using ParserPlenka;
using ParserPlenka.foqusstore;
using ParserPlenka.maxilab;

Console.WriteLine("Hello, Parse!");


DataToParse dataToParse = new DataToParse();
dataToParse.Add();

var sitePlenkaFoqus = dataToParse.ListSite[0];
var sitePlenkaMaxilab = dataToParse.ListSite[1];

Parser parser;
Focusstore(sitePlenkaFoqus);
Maxilab(sitePlenkaMaxilab);

void Focusstore(ISitePlenka foqusstore)
{
    Console.WriteLine(foqusstore.Site.NameSite);
    if (foqusstore is Foqusstore focusStore)
    {
        Parser parser = new Parser(foqusstore.Site);

        foreach (var plenka in focusStore.Site.ListPlenkas)
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

        Console.WriteLine("\n\n");
    }
}


void Maxilab(ISitePlenka sitePlenka)
{
    Console.WriteLine(sitePlenka.Site.NameSite);
    if (sitePlenka is Maxilab maxilab)
    {
        parser = new Parser(maxilab.Site);
        foreach (var plenka in maxilab.Site.ListPlenkas)
        {
            var result = parser.GetResult(plenka);
            Console.WriteLine(result.ToString());
        }
    }
    Console.WriteLine("\n\n");
}


 