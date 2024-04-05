namespace P0;

class Choice
{
    public List<Gunpla> gunplaList {get; set;}

    public Choice(List<Gunpla> gunplaList)
    {
        this.gunplaList = gunplaList;
    }

    public void MainChoice(int input)
    {
        switch(input)
        {
            //Print
            case 1:
                Menu.PrintMenu();
                PrintChoice(Menu.UserIntInput());
                break;
            //Add
            case 2:
                Gunpla gunplaAdd = new();
                gunplaList.Add(AddGunpla(gunplaAdd));
                break;
            //Edit
            case 3:
                Gunpla gunplaEdit = EditDeleteGunpla();
                Console.WriteLine($"Are you sure you want to edit {gunplaEdit.name}");
                gunplaList.Add(EditGunpla(gunplaEdit, Menu.UserYNInput()));
                break;
            //Delete
            case 4:
                Gunpla gunplaDelete = EditDeleteGunpla();
                Console.WriteLine($"Are you sure you want to delete {gunplaDelete.name}");
                DeleteGunpla(gunplaDelete, Menu.UserYNInput());
                break;
            //Search--may not implement
            case 5:
                break;
            //Exit
            case 6:
                Console.WriteLine("Exiting now...");
                break;
            default:
                Console.WriteLine("Incorrect option!");
                break;
        }
    }

    public void PrintChoice(int input)
    {
        switch(input)
        {
            //Print All
            case 1:
                PrintGunpla(gunplaList);
                break;
            //Print all in series-- may not implement
            case 2:
                break;
            //Exit
            case 3:
                Console.WriteLine("Exiting to main menu.");
                break;
            default:
                Console.WriteLine("Incorrect option! Exiting to main menu.");
                break;
        }

    }

        public void StatusChoice(int input)
    {
        switch(input)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Incorrect option! Exiting to main menu.");
                break;
        }

    }

    public static Gunpla AddGunpla(Gunpla model)
    {
        Console.WriteLine("What is the gunpla model name?");
        model.name = Console.ReadLine();
        Console.WriteLine("What is the gunpla model grade? ");
        model.grade = Console.ReadLine();
        Console.WriteLine("What is the gunpla model series/type?");
        model.type = Console.ReadLine();
        Console.WriteLine("What is the description of the gunpla model?");
        model.desc = Console.ReadLine();
        Console.WriteLine("What is the status of the gunpla model?");
        model.status = Console.ReadLine();

        Console.WriteLine(model.ToString());


        return model;
    }

    public static void PrintGunpla(List<Gunpla> gunplaList)
    {
        int count = 1;

        foreach(Gunpla gunpla in gunplaList)
        {
            Console.WriteLine($"{count}. {gunpla.ToString()}");
            count++;
        }
    }

        public Gunpla EditGunpla(Gunpla model, string input)
    {
        
        if(input == "Y")
        {
            Console.WriteLine($"Would you like to edit the gunpla model name: {model.name}?");
            if(Menu.UserYNInput() == "Y" )
            {
                Console.WriteLine("Please enter new name:");
                model.name = Console.ReadLine();
            }

            Console.WriteLine($"Would you like to edit the gunpla model grade: {model.grade}? ");
            if(Menu.UserYNInput() == "Y" )
            {
                Console.WriteLine("Please enter new grade:");
                model.grade = Console.ReadLine();
            }

            Console.WriteLine($"Would you like to edit the gunpla model series/type: {model.type}?");
            if(Menu.UserYNInput() == "Y" )
            {
                Console.WriteLine("Please enter new series/type:");
                model.type = Console.ReadLine();
            }

            Console.WriteLine($"Would you like to edit the description of the gunpla model: {model.desc}?");
            if(Menu.UserYNInput() == "Y")
            {
                Console.WriteLine("Please enter new description:");
                model.desc = Console.ReadLine();
            }
                
            Console.WriteLine($"Would you like to edit the status of the gunpla model: {model.status}?");
            if(Menu.UserYNInput() == "Y")
            {
                Console.WriteLine("Please enter new status:");
                model.status = Console.ReadLine();
            }

            Console.WriteLine(model.ToString());
        }

        return model;
    }

    public void DeleteGunpla(Gunpla gunpla, string input)
    {
        if(input == "Y" || input == "y")
            gunplaList.Remove(gunpla);
    }

    public Gunpla EditDeleteGunpla()
    {
        Gunpla gunpla = new();
        PrintGunpla(gunplaList);
        Console.WriteLine("Select number of gunpla model you would like to choose:");
        int count = Menu.UserIntInput();
        for(int i = 0; i < gunplaList.Count; i++)
        {
            if(i + 1 == count)
            {
                gunpla = gunplaList.ElementAt(i);
                break;
            }
        }

        return gunpla;
    }



}