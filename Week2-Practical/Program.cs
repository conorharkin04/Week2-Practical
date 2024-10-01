//Main();
using System.Globalization;
using System.Net.Security;

//Task5();

Encrypt();

static void Main()
{
    int option;
    do
    {
        PrintMenu();
        option = InputOption();
        GetMessage(option);
    } while (option != 0);
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

static int InputOption()
{
    try
    {

        int option = Convert.ToInt32(Console.ReadLine());
        return option;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        return -1;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        return -1;
    }
  
}

static void GetMessage(int option)
{
    string optionName = "";

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

static void Task5()
{
    Console.WriteLine("Enter a string");
    string str = Console.ReadLine();

    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
    string titleCase = textInfo.ToTitleCase(str);

    Console.WriteLine(titleCase);

    string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    int wordCount = words.Length;

    Console.WriteLine($"Number of words = {wordCount}");

}

static void Encrypt()
{

}