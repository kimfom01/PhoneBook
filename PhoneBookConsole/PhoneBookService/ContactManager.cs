using PhoneBookConsole.Input;

namespace PhoneBookConsole.PhoneBookService;

public class ContactManager
{
    private readonly UserInput _input = new UserInput();

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

    private void DeleteContact()
    {
        throw new NotImplementedException();
    }

    private void EditContact()
    {
        throw new NotImplementedException();
    }

    private void AddNewContact()
    {
        throw new NotImplementedException();
    }

    private void ViewAllContacts()
    {
        throw new NotImplementedException();
    }
}