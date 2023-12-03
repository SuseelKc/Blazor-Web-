using System.ComponentModel.DataAnnotations;

namespace blazor.Client.Models;

public class Stocks
{
    public int ID { get; set; }

    [Required]
    [StringLength(100)]
    public required string CompanyName { get; set; }

    [Required]
    [StringLength(50)]
    public required string Sector { get; set; }

    [Range(1, int.MaxValue)]
    public int PublicIssueShares { get; set; }

    [Range(1, 999999999)]
    public decimal Rate { get; set; }

    public DateTime OpenDate { get; set; }

    public DateTime CloseDate { get; set; }



}