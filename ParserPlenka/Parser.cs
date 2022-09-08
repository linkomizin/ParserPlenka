using System.Text;
using HtmlAgilityPack;
using ParserPlenka.Model;

namespace ParserPlenka;

public class Parser
{
    private Site _site;
    
    public Parser(Site site)
    {
        _site = site;
    }
    public ParsingPlenka GetResult(Plenka plenka)
    {
        HtmlWeb webPage = new HtmlWeb();
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
       // webPage.OverrideEncoding = Encoding.GetEncoding("windows-1251");
       HtmlDocument? page = new HtmlDocument();
       try
       {
           page = webPage.Load(plenka.Addres);
       }
       catch (Exception e)
       {
           Console.WriteLine(e);
           throw;
       }
       
        var someNamePlenka = page.DocumentNode.SelectSingleNode(_site.FromParse.XpathName);
        var somePlenkaPrice = page.DocumentNode.SelectSingleNode(_site.FromParse.XpathPrice);
        
        // return someJoke.OuterHtml

        return new ParsingPlenka()
        {
            NamePlenka = someNamePlenka?.InnerHtml, Price = somePlenkaPrice?.InnerText
                .Replace(" ", "")
                .Split("&")[0] 
        };
    }

}