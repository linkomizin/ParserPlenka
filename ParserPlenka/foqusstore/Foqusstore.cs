using ParserPlenka.Model;

namespace ParserPlenka.foqusstore;

public class Foqusstore:ISitePlenka
{
    private Site foqusstoreSite = new Site() { NameSite = "foqusstore.com" };
    public Site Site
    {
        get { return foqusstoreSite; }
        set { foqusstoreSite = value; }
    }

    public void AddRange()
    {
        foqusstoreSite.FromParse = new FromParse()
        {
            XpathName =
                "//div[@class='product-details__sidebar']/h1[@class='product-details__product-title ec-header-h3']",
            XpathPrice =
                "//div[@class='product-details__product-price ec-price-item']/span"
            , XpathOnSale = "//div[@class='form-control form-control--button" +
                            " form-control--large form-control--primary " +
                            "form-control--flexible form-control--animated " +
                            "details-product-purchase__add-to-bag " +
                            "form-control__button--icon-center form-control--done']" +
                            "/button[@class='form-control__button']"

        };
        var listPlenkass = new List<Plenka>()
        {
            new Plenka()
            {
                Addres = "https://foqusstore.com/shop/Fujicolor-C200-200-36-35mm-p40016296"
            },
            new Plenka()
            {
                Addres = "https://foqusstore.com/shop/Kodak-Gold-200-35mm-p57124193"
            },
            new Plenka()
            {
                Addres = "https://foqusstore.com/shop/Kodak-ColorPlus-200-36-35mm-p44577778"
            },
            new Plenka()
            {
                Addres = "https://foqusstore.com/shop/Kodak-Portra-400-35mm-p37286174"
            },
            new Plenka()
            {
                Addres = "https://foqusstore.com/shop/Ilford-HP5-400-35mm-FOQUS-p35273314"
            },
            new Plenka()
            {
                Addres = "https://foqusstore.com/shop/Fomapan-400-35mm-p40016292"
            },
            new Plenka()
            {
                Addres = "https://foqusstore.com/shop/Ilford-Pan-100-35mm-p44785292"
            },
            new Plenka()
            {
                Addres = "https://foqusstore.com/shop/Ilford-FP4-125-35mm-p37234060"
            },
            new Plenka()
            {
                Addres = "https://foqusstore.com/shop/Ilford-Delta-400-35mm-p44785329"
            }
        };
        
        
        foqusstoreSite.ListPlenkas.AddRange(listPlenkass);


    }

    
}