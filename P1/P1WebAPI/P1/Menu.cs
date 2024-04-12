namespace P1;

public class Menu
{
    public Menu(){}

    public static void MainMenu()
    {
        Console.WriteLine("1. Print");
        Console.WriteLine("2. Add");
        Console.WriteLine("3. Edit");
        Console.WriteLine("4. Delete");
        Console.WriteLine("5. Search");
        Console.WriteLine("9. Exit");
    }

    public static void PrintMenu()
    {
        Console.WriteLine("1. All");
        Console.WriteLine("2. Name");
        Console.WriteLine("3. Exit to Main Menu");
    }

        public static void StatusMenu()
    {
        Console.WriteLine("1. Unbuilt");
        Console.WriteLine("2. Incomplete");
        Console.WriteLine("3. Finished");
        Console.WriteLine("4. Broken");
        Console.WriteLine("5. None");
    }

    public static void GradeMenu()
    {
        Console.WriteLine("1. HG");
        Console.WriteLine("2. RG");
        Console.WriteLine("3. MG");
        Console.WriteLine("4. PG");
        Console.WriteLine("5. None");
    }
    public static int UserIntInput()
    {
        try
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message + "Invalid option! Must be a number. Try again.");
            return -1;
        }
    }

        public static string UserYNInput()
    {
        string input = Console.ReadLine();
        
        while(!input.ToUpper().Trim().Equals("Y") && !input.ToUpper().Trim().Equals("N"))
        {
            Console.WriteLine("Invalid option! Must be Y or N");
            input = Console.ReadLine();
        }

        return input.ToUpper().Trim(); 
    }

    public static string UserStringInput()
    {
        string? input = Console.ReadLine();

        while(string.IsNullOrEmpty(input.Trim()))
        {
            Console.WriteLine("Invalid option! Entry must not be empty");
            input = Console.ReadLine();
        }

        return input;
    }



}