using System;


class Program
{ static (string Name, string LastName, int Age, int SumPet, string[] NamePet, string[] FavColors) EnterUser()  //First Method
    {
        (string Name, string LastName, int Age, int SumPet, string[] NamePet, string[] FavColors) User;

        var NameInput;                                           //Name Data Collection
        string NameOutput;
        do
        {
            Console.WriteLine("What is your First Name?");
            NameInput = Console.ReadLine();
        } while (CheckNum(NameInput, out NameOutput));
        
        User.Name = NameOutput;

        var LastNameInput;                                      //Last Name Data Collection
        string LastNameOutput;
        do
        {
            Console.WriteLine("What is your Last Name?");
            LastNameInput = Console.ReadLine();
        } while (CheckNum(LastNameInput, out LastNameOutput));

        User.LastName = LastNameOutput;

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

        private static string NamePets(string[] PetList)       //Pet Names Data Collection
        {
            string[] PetList = new string[User.SumPet];

            for (int i = 0; i < PetList.Length; i++)
            {
                Console.WriteLine("Type your pet #{0} name below:", i + 1);
                PetList[i] = Console.ReadLine();
            }
            Console.ReadKey();
        }

        User.FavColors = ColorList();

        static string[] ColorList()                            //Color Data Collection
        {
            string[] favcolor = new string[3];
            for (int k = 0; k < favcolor.Length; k++)
            {
                Console.WriteLine("Enter your favourite color #{0}", k + 1);
                favcolor[k] = Console.ReadLine();
            }
        }


        return User;
    }
        
    static bool CheckNum(string number, out int corrnumber)   //Input Correctness Check Method
    { if (int.TryParse(number, out int intnum))
        { if (intnum > 0)
                { corrnumber = intnum;
                    return false;
                }
        }
        { corrnumber = 0;
            return true;
        }
    }

    public string Main()                                     //Method for displaying all the results
    { Console.WriteLine("Hello," EnterUser( ))
   }

