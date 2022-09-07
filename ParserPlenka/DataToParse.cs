using ParserPlenka.foqusstore;
using ParserPlenka.maxilab;
using ParserPlenka.Model;

namespace ParserPlenka;

public class DataToParse
{
    private List<ISitePlenka> ListSiteToParse = new List<ISitePlenka>();

    public List<ISitePlenka> ListSite
    {
        get { return ListSiteToParse; }
    }
    public void Add()
    {
        Foqusstore foqusstore = new Foqusstore();
        Maxilab maxilab = new Maxilab();
        
        ListSiteToParse.Add(foqusstore);
        ListSiteToParse.Add(maxilab);
    }
    
}