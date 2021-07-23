using System;
class HolidaysBetweenTwoDates
{
    static void Main()
    {

        string userName = Console.ReadLine();
        string password = "";
        for (int i = userName.Length - 1; i >= 0; i--)
        {
            password += userName[i];
        }
        bool loggin = false;
        int counter = 0;
        while (!loggin)
        {
            string inputPassword = Console.ReadLine();
            if (inputPassword == password)
            {
                Console.WriteLine($"User {userName} logged in.");
                loggin = true;
            }
            else
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    loggin = true;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }
        }



    }
}