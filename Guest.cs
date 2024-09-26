namespace HYDAC_Projekt;

public class Guest

{
    private string GuestName = "";
    
    private string GuestEmail = "";

    private string GuestCompany = "";

    private string GuestContact = "";

    
    
    Employee ContactInfo = new Employee();
    //statisk variable , der holder styr på nummeret
    private static int Guestcount = 0;
    //Reads the check in file and counts the lines and saves in Guestcount
    //private static int GuestcountCheckIn = File.ReadAllLines(@"C:/Users/Simon/source/repos/HYDAC-Git-Repository/HydacGuestsCheckIn.txt").Length;
    //private static int GuestcountCheckOut = File.ReadAllLines(@"C:/Users/Simon/source/repos/HYDAC-Git-Repository/HydacGuestsCheckOut.txt").Length;


    //Asks the new guest for several inputs
    public void NewGuest()
    {
        Console.WriteLine("Please enter your name: ");
        GuestName = Console.ReadLine();

        Console.WriteLine("Please enter your company: ");
        GuestCompany = Console.ReadLine();

        Console.WriteLine("Please enter your e-mail address: ");
        GuestEmail = Console.ReadLine();

        Console.WriteLine("Please enter your contact person: ");
        GuestContact = Console.ReadLine();
        
        Console.WriteLine("Please confirm that you have received and read the safety folder:\n" +
                          "1. Yes\n" +
                          "2. No");
        int Safety = int.Parse(Console.ReadLine());
        bool Folder = false;

        switch (Safety)
        {
            case 1:
                Folder = true;
                break;
            case 2:
                Folder = false;
                break;
        }

        string Message = "";
        if (Folder == true)
        {
            Message = $"Hello {GuestName}, please proceed to the waiting area. Your contact will be with you shortly\n";
            Console.Clear();
            Console.WriteLine(Message);
            
        }
        else if (Folder == false)
        {
            Message =
                $"Hello {GuestName}, please ask front desk for a safety folder, and proceed to the waiting area. Your contact will be with you shortly \n";
            Console.Clear();
            Console.WriteLine(Message);
            Folder = true;
            
        }
    }
    
    //Asks the guest for their email and contact person if they have been here before, so they don't have to input everything again
    public void PreviousGuest()
    {
        Console.WriteLine("Please enter your email address: ");
        GuestEmail = Console.ReadLine();
        Console.WriteLine("Please enter your contact person: ");
        GuestContact = Console.ReadLine();
        Console.WriteLine($"Hello {GuestName}, please proceed to the waiting area. Your contact will be with you shortly\n ");
    }
    
    //Returns assigned values to the log file when called
    public string LogInfo()
    {
        string Message = ($"Name: {GuestName}, Company: {GuestCompany}, Email: {GuestEmail}, Contact: {GuestContact}");
        return Message;
    }

    //Returns the number of people that are left in the building.
    //Needs to account for employees also!!!


    //Use this to store and update the counted lines in logs
   /* private int GuestcountCheckIn = 0;
    private int GuestcountCheckOut = 0;
    private int GuestCount = 0;

    public void UpdateGuestCount()
    {
        GuestCount = GuestcountCheckIn - GuestcountCheckOut;
        Console.WriteLine($"\nThe number of people on the premises is: {GuestCount}\n");
    }

    public void CheckedIn(int guests)
    {
        GuestcountCheckIn += guests;
        UpdateGuestCount();
    }

    public void CheckedOut(int guests)
    {
        GuestcountCheckOut += guests;
        UpdateGuestCount();
    }

    public int PeopleCheckedIn()
    {
        return GuestCount;
    }*/

}