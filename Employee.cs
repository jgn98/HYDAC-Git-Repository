namespace HYDAC_Projekt;

public class Employee
{
    private string EmployeeName = "";
    private string EmployeeEmail = "";
    private string EmployeeDepartment = "";
    
    public void EmployeeInfo()
    {
        Console.WriteLine("Please enter your email adress: ");
        EmployeeEmail = Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"Hello {EmployeeName}");
    }

    public string Contact()
    {
        return EmployeeName + " from " + EmployeeDepartment;
    }
}