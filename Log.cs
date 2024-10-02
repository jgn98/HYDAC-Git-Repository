using System.Security.Cryptography;
using System.Security.Principal;

namespace HYDAC_Projekt;

public class Log
{
    //File path for the log file
    string CheckIn = "C:/Users/Simon/source/repos/HYDAC-Git-Repository/HydacGuestsCheckIn.txt";
    
    string CheckOut = "C:/Users/Simon/source/repos/HYDAC-Git-Repository/HydacGuestsCheckOut.txt";

    //Keeps track of people on the premises
    private static int PeopleCount;


    public void GuestCheckIn(Guest GuestCheckIn)
    {
        //System reads the current time and date
        string Time = DateTime.Now.ToString();
        //Adds to PeopleCount
        PeopleCount++;
        //Writes guest check-in info to the log file
        using (StreamWriter writer = new StreamWriter(CheckIn, true))
        {
            writer.WriteLine($"{GuestCheckIn.LogInfo()}, {Time}");
        }
    }

    public void GuestCheckOut(Guest GuestCheckOut)
    {
        //System reads the current time and date
        string Time = DateTime.Now.ToString();
        
        //Checks if PeolpeCount is 0, if not substracts one
        if (PeopleCount <= 0)
        {
            PeopleCount = 0;
        }
        else
        {
            PeopleCount--;
            //Writes guest check-out info to the log file
            using (StreamWriter writer = new StreamWriter(CheckOut, true))
            {
                writer.WriteLine($"{GuestCheckOut.LogInfo()}, {Time}");
            }
        }
    }
    public void EmployeeCheckIn(Employee EmployeeCheckIn)
    {
        //System reads the current time and date
        string Time = DateTime.Now.ToString();
        //Adds to PeopleCount
        PeopleCount++;
        //Writes employee check-in info to the log file
        using (StreamWriter writer = new StreamWriter(CheckIn, true))
        {
            writer.WriteLine($"{EmployeeCheckIn.LogInfo()}, {Time}");
        }

    }

    //Returns and prints the number of people that are left in the building.
    public void PeopleCheckedIn()
    {
        //Checks if theres any occupants on the premises
        if (PeopleCount <= 0)
        {
            Console.WriteLine("Congratulations! You are the first to arrive today! Have a great day!");
        }
        else
        {
            Console.WriteLine($"\nThe number of people on the premises is: {PeopleCount}\n");
        }
    }
}

