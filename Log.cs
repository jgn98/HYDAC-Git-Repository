using System.Security.Principal;

namespace HYDAC_Projekt;

public class Log
{
    //sti til tekstfilen.
    string filePath = "/Users/jonasg.nielsen/RiderProjects/HYDAC/HYDAC-Git-Repository/HydacGuests.txt";
    
    
    public void GuestCheckIn(Guest GuestCheckIn)
    {
  
        DateTime Now = DateTime.Now;
        string Time = DateTime.Now.ToString();
        
        //skriver til tekstfilen
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{GuestCheckIn.LogInfo()}, {Time}");
            }
    }
    public void EmployeeCheckIn(Employee EmployeeCheckIn)
    {
  
        DateTime Now = DateTime.Now;
        string Time = DateTime.Now.ToString();
        
        //skriver til tekstfilen
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"{EmployeeCheckIn.LogInfo()}, {Time}");
        }
    }
}

