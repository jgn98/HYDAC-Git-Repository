using System.Diagnostics;

namespace HYDAC_Projekt;

class Program
{
    static void Main(string[] args)
    {
        bool MenuHold = true;
        string Email = "";

        do
        {
            Console.WriteLine("Welcome to HYDAC \n\n" +
                              "Are you an employee or a guest?\n" +
                              "1. Employee Check-In\n" +
                              "2. Guest Check-In\n" +
                              "3. Check-Out\n\n" +
                              "0. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter your name: ");
                    string EmployeeName = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine($"Hello {EmployeeName}");
                    break;

                case 2:
                    Console.WriteLine("Have you signed in to HYDAC on a previous visit?: \n" +
                                      "1. Yes\n" +
                                      "2. No\n");
                    int PreviousVisit = int.Parse(Console.ReadLine());

                    Guest guest = new Guest();
                    switch (PreviousVisit)
                    {
                        case 1:
                           guest.previousguest();
                            break;
                        case 2:
                            guest.NewGuest();

                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Please enter your email address to check-out: ");
                    string CheckOut = Console.ReadLine();
                    Console.WriteLine("You have now been checked out");
                    break;

                case 0:

                    MenuHold = false;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Error: Invalid input. Try again.\n");
                    break;
            }
        } while (MenuHold == true);
    }
}