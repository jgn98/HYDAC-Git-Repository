namespace HYDAC_Projekt;

public class Guest


{
    public string guestname = "";
        //statisk variable , der holder styr på nummeret
        private static int Guestcount = 0;

        // Unikt ID for hver person
        public void GuestName ()
        { //alt omkring guest fra main skal flyttes herind
                guestname = Console.ReadLine();
        }

}