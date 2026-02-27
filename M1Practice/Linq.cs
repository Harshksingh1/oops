// class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public double Salary { get; set; }
//     public string Department { get; set; }
// }
// class Program
// {
//    public static Dictionary<int, Employee> employees = new Dictionary<int, Employee>()
// {
//     { 1, new Employee{ Id=101, Name="Harsh", Salary=50000, Department="IT"} },
//     { 2, new Employee{ Id=102, Name="Amit", Salary=75000, Department="HR"} },
//     { 3, new Employee{ Id=103, Name="Ravi", Salary=60000, Department="Finance"} }
// };
//     public static void Main()
//     {

//         //Descending by salary in dict
//         // var sorted=employees
//         //            .OrderByDescending(e=>e.Value.Salary);

//         // foreach(var it in sorted)
//         // {
//         //     Console.WriteLine($"{it.Key} {it.Value.Id} {it.Value.Name} {it.Value.Salary} {it.Value.Department}");
//         // }   
           
//     }
// }


//====================================================LINQ On List================================================

// class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public double Salary { get; set; }
//     public string Department { get; set; }
// }
// class Program
// {
//     public static List<Employee> employees = new List<Employee>()
// {
//     new Employee{ Id=1, Name="Harsh", Salary=50000, Department="IT"},
//     new Employee{ Id=2, Name="Amit", Salary=75000, Department="HR"},
//     new Employee{ Id=3, Name="Ravi", Salary=60000, Department="IT"},
//     new Employee{ Id=4, Name="Neha", Salary=80000, Department="Finance"},
//     new Employee{ Id=5, Name="Priya", Salary=55000, Department="HR"}
// };
//    public static void Main()
//     {
        //===============salary>60000=================
        // var result=employees
        //            .Where(e=>e.Salary>60000);

        // foreach (var item in result)
        // {
        //     Console.WriteLine($"{item.Name} {item.Salary}");
        // }

        //================sort ascending to salary==============
        // var sorted=employees
        //            .OrderBy(e=>e.Salary);

        // foreach(var item in sorted)
        // {
        //     Console.WriteLine($"{item.Name} {item.Salary}");
        // }

        //==========4️⃣ Sort by Salary Descending, Then Name Ascending===========if salary same then name
        // var result=employees
        //            .OrderByDescending(e=>e.Salary)
        //            .ThenBy(e=>e.Name);

        // foreach(var item in result)
        // {
        //     Console.WriteLine($"{item.Name} {item.Salary}");
        // }

        //==========================5️⃣ Find Highest Paid Employee===============================
        // var result = employees
        //            .OrderByDescending(e => e.Salary).First();
        //     Console.WriteLine($"{result.Name} {result.Salary}");

        //======================6️⃣ Find Lowest Paid Employee==================================
        // var result=employees
        //            .OrderBy(e=>e.Salary).First();

        // Console.WriteLine($"{result.Name} {result.Salary}");


        //=========================7️⃣ Find Total Salary of All Employees===============
        // var result=employees
        //            .Sum(e=>e.Salary);
        // Console.WriteLine(result);

        // var avg=employees
        //         .Average(e=>e.Salary);
        // Console.WriteLine(avg);

        //=========================9️⃣ Count Employees in Each Department========================
        // var result=employees
        //           .GroupBy(e=>e.Department)
        //           .Select(g=> new {Dept=g.Key, count=g.Count()});
        // foreach(var it in result)
        // {
        //     Console.WriteLine($"{it.Dept} {it.count}");
        // }
        //=================1️⃣2️⃣ Max Salary in Each Department========================
        // var result=employees
        //            .GroupBy(e=>e.Department)
        //            .Select(g=>new {
        //             Dept=g.Key,
        //             salary=g.Max(x=>x.Salary)
        //            });
        //  foreach(var it in result)
        // {
        //     Console.WriteLine($"{it.Dept} {it.salary}");
        // }

        //========================1️⃣1️⃣ Find Employees Belonging to IT Department==================
        // var result=employees
        //            .Where(e=>e.Department=="IT");
        //  foreach(var it in result)
        // {
        //     Console.WriteLine($"{it.Name}");
        // }

        //============================1️⃣2️⃣ Select Only Employee Names======================
        // var result=employees
        //            .Select(x=>x.Name);
        // foreach(var it in result)
        // {
        //     Console.WriteLine(it);
        // }

        //=============================1️⃣3️⃣ Check If Any Employee Salary > 90000======================
        // bool result=employees.Any(e=>e.Salary>56000);
        // Console.WriteLine(result);
        //=============================1️⃣4️⃣ Check If All Employees Salary > 30000=================
        // bool result=employees.All(e=>e.Salary>30000);
        // Console.WriteLine(result);

        // var result = employees.Skip(2);

        //=============================1️⃣6️⃣ Take Top 3 Highest Paid Employees========================
        // var result=employees
        //            .OrderByDescending(e=>e.Salary).Take(3);
        // foreach(var it in result)
        // {
        //     Console.WriteLine($"{it.Name} {it.Salary}");
        // }

        //=============================1️⃣8️⃣ Get Distinct Departments==================
        // var result=employees
        //            .Select(e=>e.Department)
        //            .Distinct();
        // foreach(var it in result)
        // {
        //     Console.WriteLine(it);
        // }

        ///==========================1️⃣9️⃣ Find Second Highest Salary========================
        //      var result=employees
        //                 .OrderByDescending(e=>e.Salary)
        //                 .Skip(1)
        //                 .First();
        //   Console.WriteLine(result.Salary);

       //===========================2️⃣0️⃣ Group Employees by Department and Print Names===============
    //    var result=employees
    //              .GroupBy(e=>e.Department);
    //     foreach(var it in result)
    //     {
    //         Console.WriteLine(it.Key);
    //         foreach(var k in it){
    //         Console.WriteLine(k.Name);
    //         }
    //     }         

    //================================2️⃣3️⃣ Find Employee With Minimum Salary in IT Dept=====================
    // var result=employees
    //            .Where(e=>e.Department=="IT")
    //            .OrderBy(e=>e.Salary)
    //            .First();
   
    //         Console.WriteLine(result.Salary);

    //=================================2️⃣5️⃣ Remove Duplicate Employees by Department (First Only)===========
    // var result=employees
    //         .GroupBy(e=>e.Department)
    //         .Select(g=>g.First());
    // foreach(var it in result)
    //     {
    //         Console.WriteLine(it.Name);
    //     }
        
//     }
// }

////////////////=========JOIN==========/////////////////////
// class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public double Salary { get; set; }
//     public int DeptId { get; set; }
// }
// class Department
// {
//     public int DeptId { get; set; }
//     public string DeptName { get; set; }
// }
// class Program
// {
//    public static Dictionary<int, Employee> employees = new Dictionary<int, Employee>()
// {
//     { 1, new Employee{ Id=101, Name="Harsh", Salary=50000, DeptId=1 } },
//     { 2, new Employee{ Id=102, Name="Amit", Salary=75000, DeptId=2 } },
//     { 3, new Employee{ Id=103, Name="Ravi", Salary=60000, DeptId=1 } },
//     { 4, new Employee{ Id=104, Name="Neha", Salary=80000, DeptId=3 } }
// };
// public static List<Department> departments = new List<Department>()
// {
//     new Department{ DeptId=1, DeptName="IT"},
//     new Department{ DeptId=2, DeptName="HR"},
//     new Department{ DeptId=3, DeptName="Finance"}
// };
// static void Main()
//     {
//      var result=employees.Join(departments,
//                      e=>e.Value.DeptId,
//                      d=>d.DeptId,
//                      (e,d)=>new
//                      {
//                          e.Value.Name,
//                          e.Value.Salary,
//                          e.Value.Id,
//                          Department=d.DeptId
//                      });

//     foreach(var it in result)
//         {
//             Console.WriteLine($"{it.Id} {it.Name} {it.Salary} {it.Department}");
//         }
//     }
// }