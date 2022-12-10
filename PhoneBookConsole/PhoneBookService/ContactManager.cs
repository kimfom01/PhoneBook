using PhoneBookConsole.Data;
using PhoneBookConsole.Input;
using PhoneBookConsole.Models;

namespace PhoneBookConsole.PhoneBookService;

public class ContactManager
{
    private readonly UserInput _input = new UserInput();
    private readonly IDbManager _efDbManager = new EfDbManager();

    public void LaunchProgram()
    {
        Menus.DisplayMainMenu();
        var choice = _input.GetInput();
        while (choice != "0")
        {
            switch (choice)
            {
                case "1":
                    ViewAllContacts();
                    break;
                case "2":
                    AddNewContact();
                    break;
                case "3":
                    EditContact();
                    break;
                case "4":
                    DeleteContact();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong input!");
                    break;
            }
            
            Menus.DisplayMainMenu();
            choice = _input.GetInput();
        }
    }
    
    private void ViewAllContacts()
    {
        var contactList = _efDbManager.GetContacts();
        foreach (var contact in contactList)
        {
            Console.WriteLine(contact.Id);
            Console.WriteLine(contact.Name);
            Console.WriteLine(contact.PhoneNumber);
            Console.WriteLine();
        }
    }
    
    private void AddNewContact()
    {
        Console.Write("Enter name: ");
        var name = _input.GetInput();
        Console.Write("Enter phone number: ");
        var phoneNumber = _input.GetInput();

        var contact = new Contact { Name = name, PhoneNumber = phoneNumber };
        _efDbManager.AddNewContact(contact);
    }
    
    private void EditContact()
    {
        throw new NotImplementedException();
    }
    
    private void DeleteContact()
    {
        throw new NotImplementedException();
    }
}