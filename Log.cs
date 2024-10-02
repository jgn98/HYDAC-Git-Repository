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
<<<<<<< Updated upstream
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
=======
            //System reads the current time and date
            string Time = DateTime.Now.ToString();

            //Checks if PeolpeCount is 0, if not substracts one
            if (PeopleCount <= 0)
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        }
=======
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        {
            Console.WriteLine("Congratulations! You are the first to arrive today! Have a great day!");
=======
        {
            Console.WriteLine("Congratulations! You have the place to yourself! Have a great day!");
        }
        else
        {
            Console.WriteLine($"\nThe number of people on the premises is: {PeopleCount}\n");
        }
    }

    private string Line;

    public void PreviousGuestCheckIn(Guest GuestCheckIn)
    {
        try
        {
            foreach (string line in File.ReadLines(CheckIn))
            {
            
                // Regular expression to ensure exact match of the email address
            
                if (Regex.IsMatch(line, @"\b" + Regex.Escape(GuestCheckIn.GuestEmail) + @"\b"))
                {
                    string[] parts = Regex.Split(line, @"\W+");
                    // If the line contains the email, output the line
                    GuestCheckIn.GuestName = parts[0];
                    GuestCheckIn.GuestCompany = parts[1];                   
                }
            }
            Console.WriteLine($"Hello {GuestCheckIn.GuestName}, please proceed to the waiting area. Your contact will be with you shortly\n ");
>>>>>>> Stashed changes
        }
        else
        {
<<<<<<< Updated upstream
            Console.WriteLine($"\nThe number of people on the premises is: {PeopleCount}\n");
=======
            Console.WriteLine(e);
            throw;
        }
        
    }
    
    public void GuestCheckOut(Guest GuestCheckIn)
    {
        try
        {
            foreach (string line in File.ReadLines(CheckIn))
            {
            
                // Regular expression to ensure exact match of the email address
            
                if (Regex.IsMatch(line, @"\b" + Regex.Escape(GuestCheckIn.GuestEmail) + @"\b"))
                {
                    string[] parts = Regex.Split(line, @"\W+");
                    // If the line contains the email, output the line
                    GuestCheckIn.GuestName = parts[0];
                    GuestCheckIn.GuestCompany = parts[1];
                    GuestCheckIn.GuestEmail = parts[2];
                    GuestCheckIn.GuestContact = parts[3];                
                }
            }
            Console.WriteLine($"{GuestCheckIn.GuestName} has successfully been checked out\n ");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
>>>>>>> Stashed changes
        }
    }
}

