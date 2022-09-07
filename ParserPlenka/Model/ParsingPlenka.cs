namespace ParserPlenka.Model;

public class ParsingPlenka
{
    public string NamePlenka { get; set; }
    public string Price { get; set; }

    public override string ToString()
    {
        return $"Name: {NamePlenka}, price: {Price}";
    }
}