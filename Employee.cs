namespace HYDAC_Projekt;

public class Employee
{
    private int ID = 0;
    private string Dept = "";
        
    public int EmployeeID (string name)
    {
        switch (name)
        {
            case "Rene Hansen":
                ID = 1234;
                Dept = "R&D";
                break;
            case "Kasper Moller":
                ID = 2345;
                Dept = "External Sales";
                break;
            case "Soren Madsen":
                ID = 3456;
                Dept = "Front Office";
                break;
            case "Daniel Riisager":
                ID = 4567;
                Dept = "COO";
                break;
            case "Jens Haugaard":
                ID = 5678;
                Dept = "CEO";
                break;
        }

        return ID;


    }
    
}