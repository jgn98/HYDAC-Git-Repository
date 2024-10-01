using System.Security.Cryptography;
using System.Security.Principal;
using System.IO;

namespace HYDAC_Projekt;

public class Log
{
    //File path for the log file
    string CheckIn = "C:/Users/simon/Desktop/Hydac Projekt/HYDAC-Git-Repository/HydacGuestsCheckIn.txt";

    string CheckOut = "C:/Users/simon/Desktop/Hydac Projekt/HYDAC-Git-Repository/HydacGuestsCheckOut.txt";

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
        //Subtract from PeopleCount
        PeopleCount--;
        //Writes guest check-out info to the log file
        using (StreamWriter writer = new StreamWriter(CheckOut, true))
        {
            writer.WriteLine($"{GuestCheckOut.LogInfo()}, {Time}");
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
        Console.WriteLine($"\nThe number of people on the premises is: {PeopleCount}\n");
    }
    
    private string Line;
    public void PreviousGuestCheckIn(Guest GuestCheckIn)
    {

        StreamReader Reader = new StreamReader(CheckIn);
        Line = Reader.ReadLine();

        while (Line != null)
        {
            Console.WriteLine(Line);
            Line = Reader.ReadLine();
        }
        Reader.Close();

    }
}

