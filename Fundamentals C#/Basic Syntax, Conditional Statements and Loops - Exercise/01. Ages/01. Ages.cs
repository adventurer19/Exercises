using System;
class HolidaysBetweenTwoDates
{
    static void Main()
    {
        //        0 - 2 – baby;
        //        3 - 13 – child;
        //        14 - 19 – teenager;
        //        20 - 65 – adult;
        //>= 66 – elder;
        string name = "";
        int age = int.Parse(Console.ReadLine());
        if (age >= 0 && age <= 2)
        {
            name = "baby";
        }
        else if (age >= 3 && age <= 13)
        {
            name = "child";
        }
        else if (age >= 14 && age <= 19)
        {
            name = "teenager";
        }
        else if (age >= 20 && age <= 65)
        {
            name = "adult";
        }
        else if (age > 65)
        {
            name = "elder";
        }
        Console.WriteLine($"{name}");


    }
}