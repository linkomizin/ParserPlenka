namespace ParserPlenka.Model;

public class ParsingPlenka
{
    public string NamePlenka { get; set; }
    public string Price { get; set; }

    private bool onSale;

    public bool Onsale
    {
        get { return onSale; }
        set { onSale = value; }
    }

    public override string ToString()
    {
        return $"Name: {NamePlenka}, price: {Price}, Onsale(bool): {Onsale}";
    }
}