namespace PhoneBookConsole.PhoneBookService;

public class Menus
{
    public static void DisplayMainMenu()
    {
        Console.Clear();
        Console.WriteLine("**********WELCOME**********");
        Console.WriteLine("1 to view all contacts");
        Console.WriteLine("2 to add a new contact");
        Console.WriteLine("3 to edit a contact");
        Console.WriteLine("4 to delete a contact");
        Console.WriteLine("0 to close the app");
    }
}