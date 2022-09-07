namespace ParserPlenka.Model;

public class Site
{
    public string NameSite { get; set; }

    public FromParse FromParse { get; set; }
    public List<Plenka> ListPlenkas { get; set; } = new List<Plenka>();
}

public class Plenka
{
    public string Addres { get; set; }
}

public class FromParse
{
    public string XpathName { get; set; }
    public string XpathPrice { get; set; }
}