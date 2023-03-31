using System;

class Program
{ 
    static void Main(string[] args)
    { Console.WriteLine("Hello! Let's do a quick survey to get to know you!Just Press Enter to start.");
        Console.ReadKey();
        EnterUser();          //Launching EnterUser Program to collect all data from User

        Console.WriteLine("Thank you for your time!");
        Console.WriteLine("Goodbye for now!");
        Console.ReadKey();
                      
    }

    static (string Name, string LastName, int Age, int SumPet, string[] NamePet, string[] FavColors) EnterUser()  //First Method
    {
        (string Name, string LastName, int Age, int SumPet, string[] NamePet, string[] FavColors) User;

        string NameInput;

        do
        {
            Console.WriteLine("What is your First Name?");
            NameInput = Console.ReadLine();
        }
        while (CheckName(NameInput));
        User.Name = NameInput;

        string LastNameInput;

        do
        {
            Console.WriteLine("What is your Last Name?");
            LastNameInput = Console.ReadLine();
        }
        while (CheckName(LastNameInput));
        User.LastName = LastNameInput;

        string age;                                            //Age Data Collection
        int intage;

        do
        {
            Console.WriteLine("Enter your age as a number:");
            age = Console.ReadLine();
        } while (CheckNum(age, out intage));

        User.Age = intage;

        string Pets;                                           //Pets Number Data Collection
        int numpet;
        do
        {
            Console.WriteLine("How many pets do you have?");
            Pets = Console.ReadLine();
        }
        while (CheckNum(Pets, out numpet));
        User.SumPet = numpet;

        User.NamePet = NamePets(User.SumPet);

        static string[] NamePets(int SumPet)       //Pet Names Data Collection
        {
            string[] PetList = new string[SumPet];
            string check;

            for (int i = 0; i < PetList.Length; i++)
            {
                do
                {
                    Console.WriteLine("Type your pet #{0} name below:", i + 1);
                    check = Console.ReadLine();
                } while (CheckName(check));
                PetList[i] = check;
            }
                return PetList;
            
        }

        User.FavColors = ColorList();

        static string[] ColorList()                            //Color Data Collection
        {
            string[] favcolor = new string[3];
            for (int k = 0; k < favcolor.Length; k++)
            {
                Console.WriteLine("Enter your favourite color #{0} (lower case):", k + 1);
                favcolor[k] = Console.ReadLine();
                switch(favcolor[k])
                { case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Noted! Your #{0} color is red!", k + 1);
                        break;
                  case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Noted! Your #{0} color is yellow!", k + 1);
                        break;
                  case "white":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Noted! Your #{0} color is white!", k + 1);
                        break;
                  case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Noted! Your #{0} color is green!", k + 1);
                        break;
                  case "blue":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Noted! Your #{0} color is blue!", k + 1);
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Sorry, this color not available.");
                        break;
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            return favcolor;
        }


        return User;


        static bool CheckNum(string number, out int corrnumber)   //Input Number Correctness Check Method
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            {
                corrnumber = 0;
                return true;
            }
        }

        static bool CheckName(string value)     //Input Text Check Method
        {
            foreach (char c in value)
            {
                if (char.IsLetter(c))
                    return false;
            }
            return true;
            
        }
    
    }
  
}



