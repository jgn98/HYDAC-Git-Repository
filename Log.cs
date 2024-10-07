using System.Security.Cryptography;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.IO;

namespace HYDAC_Projekt;

public class Log
{
    //File path for the log file
    static string CheckInPath = Path.GetFullPath(@"HydacGuestCheckIn.txt");
    string CheckIn = CheckInPath;
    static string CheckOutPath = Path.GetFullPath(@"HydacGuestCheckOut.txt");
    string CheckOut = CheckOutPath;

    //Keeps track of people on the premises
    private static int PeopleCount;


    public void GuestCheckIn(Guest GuestCheckIn)
    {
        
        try
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
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public void EmployeeCheckIn(Employee EmployeeCheckIn)
    {
        try
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
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    //Returns and prints the number of people that are left in the building.
    public void PeopleCheckedIn()
    {
        if (PeopleCount <= 0)
        {
            Console.WriteLine("Congratulations! You have the place to yourself. Have a great day!");
        }
        else
        {
            Console.WriteLine($"\nThe number of people on the premises is: {PeopleCount}\n");
        } 
    }


    

    public void PreviousGuestCheckIn(Guest GuestCheckIn)
    {
        try
        {
            foreach (string line in File.ReadLines(CheckIn))
            {
            
                // Regular expression to ensure exact match of the email address
            
                if (Regex.IsMatch(line, @"\b" + Regex.Escape(GuestCheckIn.GuestEmail) + @"\b"))
                {
                    string[] parts = Regex.Split(line, ",");
                    // If the line contains the email, output the line
                    GuestCheckIn.GuestName = parts[0];
                    GuestCheckIn.GuestCompany = parts[1];
                }
            }
            Console.WriteLine($"Hello {GuestCheckIn.GuestName}, please proceed to the waiting area. Your contact will be with you shortly\n ");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
    
    public void GuestCheckOut(Guest GuestCheckIn)
    {
        try
        {
            GuestCheckIn.GuestEmail = Console.ReadLine();
            
            foreach (string line in File.ReadLines(CheckIn))
            {
            
                // Regular expression to ensure exact match of the email address
            
                if (Regex.IsMatch(line, @"\b" + Regex.Escape(GuestCheckIn.GuestEmail) + @"\b"))
                {
                    string[] parts = Regex.Split(line, ",");
                    // If the line contains the email, output the line
                    GuestCheckIn.GuestName = parts[0];
                    GuestCheckIn.GuestCompany = parts[1];
                    GuestCheckIn.GuestEmail = parts[2];
                    GuestCheckIn.GuestContact = parts[3];
                }
            }

            //System reads the current time and date
            string Time = DateTime.Now.ToString();
            
            PeopleCount--;
            //Writes guest check-out info to the log file
            using (StreamWriter writer = new StreamWriter(CheckOut, true))
            {
                writer.WriteLine($"{GuestCheckIn.LogInfo()}, {Time}");
            }
            Console.WriteLine($"{GuestCheckIn.GuestName} has successfully been checked out\n ");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
