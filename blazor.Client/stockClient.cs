using blazor.Client.Models;

namespace blazor.Client;

public static class stockClient
{
    private static readonly List<Stocks> stocks = new() {

            new Stocks(){

            ID= 1,
            CompanyName ="Hathway Investment Nepal Ltd.",
            Sector = "Investment",
            PublicIssueShares= 2925000,
            Rate= 50,
            OpenDate=new DateTime(2023,9,10),
            CloseDate=new DateTime(2023,9,22)

            },
            new Stocks(){

            ID= 2,
            CompanyName ="Ime Life Insurance",
            Sector = "Insurance",
            PublicIssueShares= 12925000,
            Rate=240,
            OpenDate=new DateTime(2023,10,10),
            CloseDate=new DateTime(2023,10,13)

            },
            new Stocks(){

            ID= 3,
            CompanyName ="Goldman Sachs",
            Sector = "Banking",
            PublicIssueShares= 52925000,
            Rate=600,
            OpenDate=new DateTime(2023,12,10),
            CloseDate=new DateTime(2023,12,15)

            },
            new Stocks(){

            ID= 4,
            CompanyName ="Tewa Multipurpose Finance Ltd.",
            Sector = "Finance",
            PublicIssueShares= 3925000,
            Rate=100,
            OpenDate=new DateTime(2023,10,10),
            CloseDate=new DateTime(2023,10,13)

            },
            new Stocks(){
            ID= 5,
            CompanyName ="Uttam Steels",
            Sector = "Manufacturing",
            PublicIssueShares= 5020000,
            Rate=100,
            OpenDate=new DateTime(2023,10,10),
            CloseDate=new DateTime(2023,10,13)

            }
            };

    public static Stocks[] GetStocks()
    {

        return stocks.ToArray();
    }

    // add elements method
    public static void AddStocks(Stocks stock)
    {
        stock.ID = stocks.Max(stock => stock.ID) + 1;
        stocks.Add(stock);

    }
}