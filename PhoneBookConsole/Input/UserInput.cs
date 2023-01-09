namespace PhoneBookConsole.Input;

public class UserInput : IUserInput
{
    public string GetInput()
    {
        return Console.ReadLine().Trim();
    }
}