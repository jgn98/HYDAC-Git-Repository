namespace HYDAC_Projekt;

public class Employee
{
    private string employeeName = "";
    private string employeeEmail = "";
    private string employeeDepartment = "";
    
    //Asks the employee for their email
    public void EmployeeInfo()
    {
        Console.WriteLine("Please enter your email address: ");
        try
        {
            employeeEmail = Console.ReadLine();
        
            switch (employeeEmail)
            {
                case "jh@hydac.com":
                    employeeName = "Jens Haugaard";
                    employeeDepartment = "CEO";
                    employeeEmail = "jh@hydac.com";
                    break;
            
                case "sm@hydac.com":
                    employeeName = "Søren Madsen";
                    employeeDepartment = "Front Office";
                    employeeEmail = "sm@hydac.com";
                    break;
                case "lp@hydac.com":
                    employeeName = "Lasse Petersen";
                    employeeDepartment = "External Sales";
                    employeeEmail = "lp@hydac.com";
                    break;

                case "rs@hydac.com":
                    employeeName = "Rasmus W. Sørensen";
                    employeeDepartment = "R&D";
                    employeeEmail = "ra@hydac.com";
                    break;

                case "bn@hydac.com":
                    employeeName = "Benjamin Nielsen";
                    employeeDepartment = "Planning, Projecting & Support";
                    employeeEmail = "bn@hydac.com";
                    break;
            }
        
            Console.Clear();
            Console.WriteLine($"Hello {employeeName}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
    
    //Returns the assigned values to the log file when called
    public string LogInfo()
    {
        string Message = ($"Name: {employeeName}, Email: {employeeEmail}, Department: {employeeDepartment}");
        return Message;
    }
}