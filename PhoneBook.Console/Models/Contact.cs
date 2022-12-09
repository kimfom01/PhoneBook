using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Console.Models;

public class Contact
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
}