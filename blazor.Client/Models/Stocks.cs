namespace blazor.Client.Models;

public class Stocks
{
    public int ID { get; set; }

    public required string CompanyName { get; set; }

    public required string Sector { get; set; }

    public int PublicIssueShares { get; set; }

    public int Rate { get; set; }

    public DateTime OpenDate { get; set; }

    public DateTime CloseDate { get; set; }



}