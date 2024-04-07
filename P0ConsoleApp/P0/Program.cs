namespace P0;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        List<Gunpla>? gunplaList = Data.LoadGunpla();
        
        //Gunpla ayame = new("Petit'G Guy Chara'G Guy Ayame", "Purple Ayame", "HG", "Petit'G Guy", "Unworked");
        //gunplaList.Add(ayame);
        
        Choice choice = new( gunplaList);

        //Console.WriteLine(ayame.ToString());

        int userInput = 0;
        do
        {
            Menu.MainMenu();
            userInput = Menu.UserIntInput();

            choice.MainChoice(userInput);
            

        }while(userInput != 6);
    }
}
