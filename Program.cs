using System.Diagnostics;

namespace HYDAC_Projekt;

class Program
{
    static void Main(string[] args)
    {
        bool MenuHold = true;

        do
        {
            Menu MenuStart = new Menu();
            MenuStart.MainMenu();
            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Log ECheckIn = new Log();
                    Employee EmployeeCheckIn = new Employee();
                    EmployeeCheckIn.EmployeeInfo();
                    ECheckIn.EmployeeCheckIn(EmployeeCheckIn);
                    break;

                case 2:
                    MenuStart.GuestMenu();
                    int PreviousVisit = int.Parse(Console.ReadLine());
                    Log GCheckIn = new Log();
                    Guest GuestCheckIn = new Guest();
                    switch (PreviousVisit)
                    {
                        case 1:
                            GuestCheckIn.PreviousGuest();
                            GCheckIn.GuestCheckIn(GuestCheckIn);
                            break;
                        case 2:
                            GuestCheckIn.NewGuest();
                            GCheckIn.GuestCheckIn(GuestCheckIn);
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
                    MenuStart.Error();
                    break;
            }
        } while (MenuHold == true);
    }
}