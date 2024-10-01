Main();

static void Main()
{
    PrintMenu();
    InputOption();
}

static void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish");
    Console.WriteLine("3. Hello in German");
    Console.WriteLine("4. Hello in Italian");
    Console.WriteLine("0. Exit application");


}

static void InputOption()
{
    string optionName = "";

    try
    {

        int option = Convert.ToInt32((Console.ReadLine()));

        switch (option)
        {
            case 0:
                break;
            case 1:
                optionName = ("Bonjour");
                break;
            case 2:
                optionName = ("Hola");
                break;
            case 3:
                optionName = ("Hallo");
                break;
            case 4:
                optionName = ("Ciao");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }

        Console.WriteLine(optionName);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    }
}