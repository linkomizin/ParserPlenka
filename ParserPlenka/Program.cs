﻿// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using ParserPlenka;
using ParserPlenka.foqusstore;
using ParserPlenka.maxilab;

Console.WriteLine("Hello, Parse!");
Foqusstore foqusstore = new Foqusstore();
foqusstore.AddRange();
//Parser parser = new Parser(foqusstore.Site);

DataToParse dataToParse = new DataToParse();
dataToParse.Add();

var maxilabList = dataToParse.ListSite[1];
Parser parser;
if (maxilabList is Maxilab maxilab)
{
    parser = new Parser(maxilab.Site);
    foreach (var plenka in maxilab.Site.ListPlenkas)
    {
        var result = parser.GetResult(plenka);
        Console.WriteLine(result.ToString());
    }
}
    





// foreach (var plenka in foqusstore.Site.ListPlenkas)
// {
//     Thread.Sleep(3000);
//     try
//     {
//         var result = parser.GetResult(plenka);
//         Console.WriteLine(result.ToString());
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine(e.Message);
//
//     }
// }
  
  
  