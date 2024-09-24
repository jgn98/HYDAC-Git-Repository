namespace HYDAC_Projekt;

public class Menu
{
    public int Choice = 0;
    public void MainMenu()
    {
        //Writes main menu to console and asks for user input
        Console.WriteLine("Welcome to HYDAC \n\n" +
                          "Are you an employee or a guest?\n" +
                          "1. Employee Check-In\n" +
                          "2. Guest Check-In\n" +
                          "3. Check-Out\n\n" +
                          "0. Exit");
         Choice = int.Parse(Console.ReadLine());
    }

    public void GuestMenu()
    {
        //Writes guest menu to console
        Console.Clear();
        Console.WriteLine("Have you signed in to HYDAC on a previous visit?: \n" +
                          "1. Yes\n" +
                          "2. No\n");
    }

    public void CheckOut()
    {
        //Writes check-out menu to console
        Console.Clear();
        Console.WriteLine("Please enter your email address to check-out: ");
        string CheckOut = Console.ReadLine();
        Console.WriteLine("You have now been checked out");
    }

    public void Error()
    {
        //Writes error message to console
        Console.Clear();
        Console.WriteLine("Error: Invalid input, please try again.");
    }
}