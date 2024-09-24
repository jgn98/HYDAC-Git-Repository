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

        public void PreviousGuest()
        {
            Console.WriteLine("Please enter your email address: ");
            GuestEmail = Console.ReadLine();
            Console.WriteLine("Please enter your contact person: ");
            GuestContact = Console.ReadLine();
            Console.WriteLine($"Hello {GuestName}, please proceed to the waiting area. Your contact will be with you shortly\n ");
        }

        public string LogInfo()
        {
            string Message = ($"Name: {GuestName}, Company: {GuestCompany}, Email: {GuestEmail}, Contact: {GuestContact}");
            return Message;
        }
}