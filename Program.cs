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
            Menu MenuStart = new Menu();
            MenuStart.MainMenu();
            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Employee EmployeeCheckIn = new Employee();
                    EmployeeCheckIn.EmployeeInfo();
                    break;

                case 2:
                    MenuStart.GuestMenu();
                    int PreviousVisit = int.Parse(Console.ReadLine());

                    Guest GuestCheckIn = new Guest();
                    switch (PreviousVisit)
                    {
                        case 1:
                           GuestCheckIn.PreviousGuest();
                            break;
                        case 2:
                            GuestCheckIn.NewGuest();
                            break;
                    }
                    break;

                case 3:
                   MenuStart.CheckOut();
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