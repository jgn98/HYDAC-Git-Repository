using System.Security.Principal;

namespace HYDAC_Projekt;

public class Log
{
    //File path for the log file
    string FilePath = "/Users/jonasg.nielsen/RiderProjects/HYDAC/HYDAC-Git-Repository/HydacGuests.txt";
    
    
    public void GuestCheckIn(Guest GuestCheckIn)
    {
        //System reads the current time and date
        string Time = DateTime.Now.ToString();
        
        //Writes guest check-in info to the log file
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"{GuestCheckIn.LogInfo()}, {Time}");
            }
    }
    public void EmployeeCheckIn(Employee EmployeeCheckIn)
    {
        //System reads the current time and date
        string Time = DateTime.Now.ToString();
        
        //Writes employee check-in info to the log file
        using (StreamWriter writer = new StreamWriter(FilePath, true))
        {
            writer.WriteLine($"{EmployeeCheckIn.LogInfo()}, {Time}");
        }
    }
}

