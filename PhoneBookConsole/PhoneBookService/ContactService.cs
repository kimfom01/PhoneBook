using PhoneBookConsole.Data;
using PhoneBookConsole.Input;
using PhoneBookConsole.Models;

namespace PhoneBookConsole.PhoneBookService;

public class ContactService : IContactService
{
    private readonly IUserInput _input = new UserInput();
    private readonly IDbManager _efDbManager = new EfDbManager();

    public void ViewAllContacts()
    {
        Console.Clear();
        var contactList = _efDbManager.GetContacts();
        foreach (var contact in contactList)
        {
            Console.Write($"Name: {contact.Name} Phone Number: {contact.PhoneNumber} Email: {contact.Email}\n");
            Console.WriteLine();
        }

        Console.Write("Press Enter to continue: ");
        Console.ReadLine();
    }

    public void AddNewContact()
    {
        Console.Clear();
        Console.Write("Enter name: ");
        var name = _input.GetInput();
        Console.Write("Enter phone number: ");
        var phoneNumber = _input.GetInput();
        Console.Write("Enter email: ");
        var email = _input.GetInput();

        var contact = new Contact { Name = name, PhoneNumber = phoneNumber, Email = email };
        _efDbManager.AddNewContact(contact);
    }

    public void EditContact()
    {
        Console.Clear();
        Console.Write("Enter name of contact to edit: ");
        var oldName = _input.GetInput();
        Console.Write("Enter new name: ");
        var newName = _input.GetInput();
        Console.Write("Enter new phone number: ");
        var newPhoneNumber = _input.GetInput();
        Console.Write("Enter new email: ");
        var newEmail = _input.GetInput();

        var oldContact = new Contact { Name = oldName };
        var newContact = new Contact { Name = newName, PhoneNumber = newPhoneNumber, Email = newEmail };
        _efDbManager.UpdateContact(oldContact, newContact);
    }

    public void DeleteContact()
    {
        Console.Clear();
        Console.Write("Enter name of contact to delete: ");
        var contactToDelete = _input.GetInput();

        var contact = new Contact { Name = contactToDelete };
        _efDbManager.DeleteContact(contact);
    }
}