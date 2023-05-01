namespace Api.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Person
{
    //[Key]
    public int Id { get; set; }
    public string Name {get; set; } = String.Empty;
    public string Email {get; set; } = String.Empty;
    public string Gender {get; set; } = String.Empty;
    public string Password {get; set; } = String.Empty;
    public string Phone {get; set; } = String.Empty;

    [ForeignKey("Address")]
    public int? AddressId { get; set; }
    public Address? Address { get; set; }
}

