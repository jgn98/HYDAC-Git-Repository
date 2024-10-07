using System.Diagnostics;

namespace HYDAC_Projekt;

class Program
{
    static void Main(string[] args)
    {
        bool MenuHold = true;

        do
        {
            //Calling the menu class in order to run the menu methods
            Menu MenuStart = new Menu();
            MenuStart.MainMenu();
            

            switch (MenuStart.Choice)
            {
                case 1:
                    //Calling the log and employee classes in order to run check-in methods from the classes
                    Log ECheckIn = new Log();
                    Employee EmployeeCheckIn = new Employee();
                    EmployeeCheckIn.EmployeeInfo();
                    //Running the employee check-in method from log class, using the variable from employee class in order to save the inputted data
                    ECheckIn.EmployeeCheckIn(EmployeeCheckIn);
                    
                    break;

                case 2:
                    //Calling the log and guest classes in order to run check-in methods from the classes
                    MenuStart.GuestMenu();
                    int PreviousVisit = int.Parse(Console.ReadLine());
                    Log GCheckIn = new Log();
                    Guest GuestCheckIn = new Guest();
                    switch (PreviousVisit)
                    {
                        //Switch cases in order to determine whether the guest has previously filled in all information
                        case 1:
                            GuestCheckIn.PreviousGuest(GCheckIn);
                            GCheckIn.PreviousGuestCheckIn(GuestCheckIn);
                            //Running the guest check-in method from log class, using the variable from guest class in order to save the inputted data
                            GCheckIn.GuestCheckIn(GuestCheckIn);

                            break;
                        case 2:
                            GuestCheckIn.NewGuest();
                            //Running the guest check-in method from log class, using the variable from guest class in order to save the inputted data
                            GCheckIn.GuestCheckIn(GuestCheckIn);
                            break;
                    }
                    break;

                case 3:
                    //Calls checkout method
                    MenuStart.CheckOut();
                    Log GCheckOut = new Log();
                    Guest GuestCheckOut = new Guest();
                    GCheckOut.GuestCheckOut(GuestCheckOut);
                    break;

                case 4:
                    //Shows how many people are checked in
                    Log PeopleInBuilding = new Log();
                    PeopleInBuilding.PeopleCheckedIn();
                    break;

                case 0:
                    //Stops the menu loop if 0 is inputted within the menu
                    MenuStart.ConfirmClose();
                    if (MenuStart.Choice == 1)
                    {
                        MenuHold = false;
                    }

                    if (MenuStart.Choice == 2)
                    {
                    }

                    break;

                default:
                    MenuStart.Error();
                    break;
            }
            
        } while (MenuHold == true);
    }
}