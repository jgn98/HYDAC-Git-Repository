namespace HYDAC_Projekt;

public class Guest
{
    
        //statisk variable , der holder styr på nummeret
        private static int Guestcount = 0;

        // Unikt ID for hver person
        public int GuestID()
        {
                int GuestID = Guestcount++;
                
                return GuestID;
        }

}