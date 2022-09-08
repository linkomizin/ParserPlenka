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
        foqusstore.AddRange();
        Maxilab maxilab = new Maxilab();
        maxilab.AddRange();
        listSiteToParse.Add(foqusstore);
        listSiteToParse.Add(maxilab);
    }
    
}