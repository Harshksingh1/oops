using System;
class Employee:IComparable
{
    public int ID { get; set; }
    public string Name { get; set; }

    
    public override string ToString()
    {
        return "Your EmployeeID: "+ID+" and Name is: "+Name;
    }
}