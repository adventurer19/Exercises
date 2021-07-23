using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            //: студентски(student), стандартен(standard) и детски(kid), за всички 
            //. Трябва да изчислите и колко процента от залата е запълнена за всяка една прожекция.
            // ⦁	На първия ред до получаване на командата "Finish" - име на филма – текст
            //⦁	На втори ред – свободните места в салона за всяка прожекция – цяло число [1 … 100]
            //⦁	За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "End":
            //⦁	Типа на закупения билет - текст ("student", "standard", "kid")
            string movieName = Console.ReadLine();
            int allStudentTickets = 0;
            int allStandardTickets = 0;
            int allKidTickets = 0;


            while (movieName != "Finish")
            {

                int ticketsStudents = 0;
                int ticketsStandarts = 0;
                int ticketKids = 0;
                int tickets = 0;
                int seats = int.Parse(Console.ReadLine());
                while (seats > tickets)
                {
                    string filmTypeTickets = Console.ReadLine();
                    if (filmTypeTickets == "End") break;

                    switch (filmTypeTickets)
                    {
                        case "student": ticketsStudents++; break;
                        case "standard": ticketsStandarts++; break;
                        case "kid": ticketKids++; break;

                    }
                    tickets = ticketsStandarts + ticketsStudents + ticketKids;


                }

                allStudentTickets += ticketsStudents;
                allStandardTickets += ticketsStandarts;
                allKidTickets += ticketKids;
                Console.WriteLine($"{movieName} - {1.0 * tickets / seats * 100:f2}% full.");
                movieName = Console.ReadLine();


            }
            int alltickets = allStudentTickets + allStandardTickets + allKidTickets;
            Console.WriteLine($"Total tickets: {alltickets}");
            Console.WriteLine($"{1.0 * allStudentTickets / alltickets * 100:f2}% student tickets.");
            Console.WriteLine($"{1.0 * allStandardTickets / alltickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{1.0 * allKidTickets / alltickets * 100:f2}% kids tickets.");




        }

    }
}
