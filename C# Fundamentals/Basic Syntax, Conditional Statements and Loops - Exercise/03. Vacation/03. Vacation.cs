using System;
class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int numberOfPeople = int.Parse(Console.ReadLine());
        string typeOfPeople = Console.ReadLine();
        string day = Console.ReadLine();
        double sum;

        switch (typeOfPeople)
        {
            case "Students":
                switch (day)
                {
                    case "Friday":
                        sum = numberOfPeople * 8.45;
                        break;
                    case "Saturday":
                        sum = numberOfPeople * 9.80;
                        break;
                    case "Sunday":
                        sum = numberOfPeople * 10.46;
                        break;
                    default:
                        return;
                }
                if (numberOfPeople >= 30)
                {
                    sum -= sum * 0.15;
                }
                break;

            case "Business":
                if (numberOfPeople >= 100)
                {
                    numberOfPeople -= 10;
                }
                switch (day)
                {

                    case "Friday":
                        sum = numberOfPeople * 10.90;
                        break;
                    case "Saturday":
                        sum = numberOfPeople * 15.60;
                        break;
                    case "Sunday":
                        sum = numberOfPeople * 16;
                        break;
                    default:
                        return;
                }
                break;
            case "Regular":
                switch (day)
                {
                    case "Friday":
                        sum = numberOfPeople * 15;
                        break;
                    case "Saturday":
                        sum = numberOfPeople * 20;
                        break;
                    case "Sunday":
                        sum = numberOfPeople * 22.50;
                        break;
                    default:
                        return;
                }
                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    sum -= sum * 0.05;
                }
                break;
            default:
                return;
        }
        Console.WriteLine("Total price: {0:f2}", sum);

    }
}