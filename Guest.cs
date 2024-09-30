namespace HYDAC_Projekt;

public class Guest

{
    private string guestName = "";
    
    private string guestEmail = "";

    private string guestCompany = "";

    private string guestContact = "";

    Employee ContactInfo = new Employee();
    

    //Asks the new guest for several inputs
    public void NewGuest()
    {
        Console.WriteLine("Please enter your name: ");
        guestName = Console.ReadLine();

        Console.WriteLine("Please enter your company: ");
        guestCompany = Console.ReadLine();

        Console.WriteLine("Please enter your e-mail address: ");
        guestName = Console.ReadLine();

        Console.WriteLine("Please enter your contact person: ");
        guestContact = Console.ReadLine();
        
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
            Message = $"Hello {guestName}, please proceed to the waiting area. Your contact will be with you shortly\n";
            Console.Clear();
            Console.WriteLine(Message);     
        }
        else if (Folder == false)
        {
            Message =
                $"Hello {guestName}, please ask front desk for a safety folder, and proceed to the waiting area. Your contact will be with you shortly \n";
            Console.Clear();
            Console.WriteLine(Message);
            Folder = true;
        }
        
    }
    
    //Asks the guest for their email and contact person if they have been here before, so they don't have to input everything again
    public void PreviousGuest()
    {
        Console.WriteLine("Please enter your email address: ");
        guestName = Console.ReadLine();
        Console.WriteLine("Please enter your contact person: ");
        guestContact = Console.ReadLine();
        Console.WriteLine($"Hello {guestName}, please proceed to the waiting area. Your contact will be with you shortly\n ");
        
    }
    
    //Returns assigned values to the log file when called
    public string LogInfo()
    {
        string Message = ($"Name: {guestName}, Company: {guestCompany}, Email: {guestName}, Contact: {guestContact}");
        return Message;
    }

    
    //Needs to account for employees also!!!
 
    //Reads the check in file and counts the lines and saves in Guestcount
    private static int GuestcountCheckIn = File.ReadAllLines(@"C:/Users/simon/Desktop/Hydac Projekt/HYDAC-Git-Repository/HydacGuestsCheckIn.txt").Length;
    private static int GuestcountCheckOut = File.ReadAllLines(@"C:/Users/simon/Desktop/Hydac Projekt/HYDAC-Git-Repository/HydacGuestsCheckOut.txt").Length;
    
}