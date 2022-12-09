using PhoneBook.Console.Models;

namespace PhoneBook.Console.Data;

public interface IDbManager
{
    public void AddNewContact(Contact newContact);
    public void UpdateContact(Contact oldContact, Contact newContact);
    public void DeleteContact(Contact contact);
    public List<Contact> GetContacts();
}