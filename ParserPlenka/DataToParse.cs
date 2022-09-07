using ParserPlenka.foqusstore;
using ParserPlenka.maxilab;
using ParserPlenka.Model;

namespace ParserPlenka;

public class DataToParse
{
    private List<ISitePlenka> listSiteToParse = new List<ISitePlenka>();

    public List<ISitePlenka> ListSite
    {
        get { return listSiteToParse; }
    }
    public void Add()
    {
        Foqusstore foqusstore = new Foqusstore();
        Maxilab maxilab = new Maxilab();
        
        listSiteToParse.Add(foqusstore);
        listSiteToParse.Add(maxilab);
    }
    
}