namespace HYDAC_Projekt;

class Program
{
    static void Main(string[] args)
    {
        bool hold = true;

        do
        {
            Console.WriteLine("Welcome to HYDAC \n\n" +
                              "Are you an employee or a guest?\n" +
                              "1. Employee\n" +
                              "2. Guest\n\n" +
                              "0. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine();
                
                Console.Clear();
                Console.WriteLine($"Hello {name}");
                
            }
            else if (choice == 2)
            {
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine();
                
                Console.WriteLine("Please enter your company: ");
                string company = Console.ReadLine();
                
                Console.WriteLine("Please enter your contact person: ");
                string contact = Console.ReadLine();

                Console.WriteLine("Have you recieved a safety folder?:\n" +
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
                    message = $"Hello {name}, please proceed to the waiting area\n";
                    Console.Clear();
                    Console.WriteLine(message);
                }
                else if (folder == false)
                {
                    message = $"Hello {name}, please ask front desk for a safety folder, and proceed to the waiting area\n";
                    Console.Clear();
                    Console.WriteLine(message);
                }

                Guest GID = new Guest();
                
            }
            else if (choice == 0)
            {
                hold = false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error: Invalid input. Try again.\n");
            }

        } while (hold == true);
    }
}