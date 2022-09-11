using ParserPlenka.Model;

namespace ParserPlenka.maxilab;

public class Maxilab:ISitePlenka
{
    private Site maxilab = new Site() { NameSite = "maxilabphoto.ru" };

    public Site Site
    {
        get { return maxilab; }
        set { maxilab = value; }
    }

    public void AddRange()
    {
        maxilab.FromParse = new FromParse()
        {
            XpathName =
                "//div[@class='single-product__info']/p[@class='single-product__title']",
            XpathPrice =
                "//p[@class='single-product__price-new']/span[@class='woocommerce-Price-amount amount']"
            ,XpathOnSale = "//form[@class='cart']/button[@type='submit']"
        };
        var listPlenkass = new List<Plenka>()
        {
            new Plenka()
            {
                Addres = "https://maxilabphoto.ru/product/agfa-apx-100-36/"
            },
            new Plenka()
            {
                Addres = "https://maxilabphoto.ru/product/fujicolor-c200-36/"
            },
            new Plenka()
            {
                Addres = "https://maxilabphoto.ru/product/fomapan-100-36/"
            },
            new Plenka()
            {
                Addres = "https://maxilabphoto.ru/product/kodak-gold-200-24/"
            },

        };
        
        
        maxilab.ListPlenkas.AddRange(listPlenkass);
    }
}