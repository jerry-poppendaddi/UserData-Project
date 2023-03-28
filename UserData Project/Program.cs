using System;

class Program
{  static (string Name, string LastName, int Age) EnterUser()
    { (string Name, string LastName, int Age) User;

        Console.WriteLine("What is your First Name?");
        User.Name = Console.ReadLine();

        Console.WriteLine("What is your Last Name?");
        User.LastName = Console.ReadLine();

        string age;
        int intage;

        do
        {
            Console.WriteLine("Enter your age as a number:");
            age = Console.ReadLine();
        } while (CheckNum(age, out intage));

        User.Age = intage;
        return User;
    }
}

