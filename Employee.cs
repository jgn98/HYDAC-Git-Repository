namespace HYDAC_Projekt;

public class Employee
{
    private string EmployeeName = "";
    private string EmployeeEmail = "";
    private string EmployeeDepartment = "";
    
    public void EmployeeInfo()
    {
        Console.WriteLine("Please enter your email address: ");
        EmployeeEmail = Console.ReadLine();
        
        switch (EmployeeEmail)
        {
            case "jh@hydac.com":
                EmployeeName = "Jens Haugaard";
                EmployeeDepartment = "CEO";
                EmployeeEmail = "jh@hydac.com";
                break;
            
            case "sm@hydac.com":
                EmployeeName = "Søren Madsen";
                EmployeeDepartment = "Front Office";
                EmployeeEmail = "sm@hydac.com";
                break;
        }
        
        Console.Clear();
        Console.WriteLine($"Hello {EmployeeName}");
    }
    
    public string Contact()
    {
        return EmployeeName + " from " + EmployeeDepartment;
    }
    public string LogInfo()
    {
        string Message = ($"Name: {EmployeeName}, Email: {EmployeeEmail}, Department: {EmployeeDepartment}");
        return Message;
    }
}