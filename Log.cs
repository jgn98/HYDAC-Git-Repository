using System.Security.Principal;

namespace HYDAC_Projekt;

public class Log
{
    //File path for the log file
    string CheckIn = "C:/Users/Simon/source/repos/HYDAC-Git-Repository/HydacGuestsCheckIn.txt";
    string CheckOut = "C:/Users/Simon/source/repos/HYDAC-Git-Repository/HydacGuestsCheckOut.txt";


    public void GuestCheckIn(Guest GuestCheckIn)
    {
        //System reads the current time and date
        string Time = DateTime.Now.ToString();
        
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
        
        //Writes employee check-in info to the log file
        using (StreamWriter writer = new StreamWriter(CheckIn, true))
        {
            writer.WriteLine($"{EmployeeCheckIn.LogInfo()}, {Time}");
        }
    }
}

