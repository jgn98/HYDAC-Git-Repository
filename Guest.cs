namespace HYDAC_Projekt;

public class Guest

{
    private string guestName = "";

    public string GuestName { get => guestName; set => guestName = value; }
    
    private string guestEmail = "";
    
    public string GuestEmail { get => guestEmail; set => guestEmail = value; }

    private string guestCompany = "";
    
    public string GuestCompany { get => guestCompany; set => guestCompany = value; }

    private string guestContact = "";
    
    public string GuestContact { get => guestContact; set => guestContact = value; }

    Employee ContactInfo = new Employee();
    

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
        GuestName = Console.ReadLine();
        Console.WriteLine("Please enter your contact person: ");
        GuestContact = Console.ReadLine();
        Console.WriteLine($"Hello {GuestName}, please proceed to the waiting area. Your contact will be with you shortly\n ");
        
    }
    
    //Returns assigned values to the log file when called
    public string LogInfo()
    {
        string Message = ($"Name: {GuestName}, Company: {GuestCompany}, Email: {GuestName}, Contact: {GuestContact}");
        return Message;
    }

    
    //Needs to account for employees also!!!
 
    //Reads the check in file and counts the lines and saves in Guestcount
    private static int GuestcountCheckIn = File.ReadAllLines(@"C:/Users/simon/Desktop/Hydac Projekt/HYDAC-Git-Repository/HydacGuestsCheckIn.txt").Length;
    private static int GuestcountCheckOut = File.ReadAllLines(@"C:/Users/simon/Desktop/Hydac Projekt/HYDAC-Git-Repository/HydacGuestsCheckOut.txt").Length;
    
}