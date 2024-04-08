namespace P0;

class Program
{
    static void Main(string[] args)
    {
        List<Gunpla>? gunplaList = Data.LoadGunpla();
        
        //Gunpla ayame = new("Petit'G Guy Chara'G Guy Ayame", "Purple Ayame", "HG", "Petit'G Guy", "Unworked");

        Choice choice = new( gunplaList);

        int userInput = 0;
        do
        {
            Menu.MainMenu();
            userInput = Menu.UserIntInput();

            gunplaList = choice.MainChoice(userInput);
            

        }while(userInput != 9);

        Data.SaveGunpla(gunplaList);
    }
}
