using System.Security.Principal;

namespace HYDAC_Projekt;

public class Log
{
    public void GuestCheckIn()
    {
        string HydacGuests = @"C:\Users\simon\Desktop\Hydac Projekt\HydacGuests.txt";
        string HydacLog = @"C:\Users\simon\Desktop\Hydac Projekt\HydacLog.txt";
        Guest GID = new Guest();

        DateTime Now = DateTime.Now;
        string Time = DateTime.Now.ToString();
        string[] GuestCheckIn = { Time };
        //string IdString = Convert.ToString(GID.GuestID());
        //File.AppendAllLines(HydacLog, new string[] { IdString, Time });
    }
}