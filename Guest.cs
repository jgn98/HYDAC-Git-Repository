namespace HYDAC_Projekt;

public class Guest

{
    public string guestname = "";
    
    private string guestemail = "";

    private string guestcompany = "";

    private string guestcontact = "";
    
    
        //statisk variable , der holder styr på nummeret
        private static int Guestcount = 0;


        public void NewGuest()
        {
            Console.WriteLine("Please enter your name: ");
            guestname = Console.ReadLine();

            Console.WriteLine("Please enter your company: ");
            guestcompany = Console.ReadLine();

            Console.WriteLine("Please enter your e-mail address: ");
            guestemail = Console.ReadLine();

            Console.WriteLine("Please enter your contact person: ");
            guestcontact = Console.ReadLine();
            
            Console.WriteLine("Please confirm that you have recieved and read the safety folder:\n" +
                              "1. Yes\n" +
                              "2. No");
            int safety = int.Parse(Console.ReadLine());
            bool folder = false;

            switch (safety)
            {
                case 1:
                    folder = true;
                    break;
                case 2:
                    folder = false;
                    break;
            }

            string message = "";
            if (folder == true)
            {
                message = $"Hello {guestname}, please proceed to the waiting area\n";
                Console.Clear();
                Console.WriteLine(message);
            }
            else if (folder == false)
            {
                message =
                    $"Hello {guestname}, please ask front desk for a safety folder, and proceed to the waiting area\n";
                Console.Clear();
                Console.WriteLine(message);
                folder = true;
            }
        }

        public void previousguest()
        {
            Console.WriteLine("Please enter your email address: ");
            guestemail = Console.ReadLine();
            Console.WriteLine($"Welcome {guestname} ");
        }
}