// using System;
// using System.Diagnostics;
// using System.Runtime;
// using System.Runtime.InteropServices;
// using System.Security.AccessControl;
// class Computer
// {
//     public string Processor { get; set; }
//     public int RamSize { get; set; }
//     public int HardDiskSize { get; set; }
//     public int GraphicCard { get; set; }
// }
// class Desktop:Computer
// {
//     public int MonitorSize { get; set; }
//     public int PowerSupplyVolt { get; set; }

//     public double DesktopPriceCalculation()
//     {  
//         double processorCost=0;
//         if(Processor=="i3")
//         processorCost=1500;
//         if(Processor=="i5")
//         processorCost=3000;
//         if(Processor=="i7")
//         processorCost=4500;
//         double DesktopPrice=processorCost+(RamSize*200)+(HardDiskSize*1500)+(GraphicCard*2500)+(MonitorSize*250)+(PowerSupplyVolt*20);
//         return DesktopPrice;

//     }
// }
// class Laptop:Computer
// {
//     public int DisplaySize { get; set; }
//     public int BatteryVolt { get; set; }

//     public double LaptopPriceCalculation()
//     {
//         double processorCost=0;
//         if(Processor=="i3")
//         processorCost=2500;
//         if(Processor=="i5")
//         processorCost=5000;
//         if(Processor=="i7")
//         processorCost=6500;
//         double LaptopPrice=processorCost+(RamSize*200)+(HardDiskSize*1500)+(GraphicCard*2500)+(DisplaySize*250)+(BatteryVolt*20);
//         return LaptopPrice;
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("1.Desktop");
//         Console.WriteLine("2.Laptop");
//         Console.WriteLine("Chooese the option");
//         int option=Convert.ToInt32(Console.ReadLine());
//         if(option==1){
//         Desktop c1=new Desktop();
//         Console.WriteLine("Enter the processor");
//         c1.Processor=Console.ReadLine();
//         Console.WriteLine("Enter ram size");
//         c1.RamSize=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the hard disk size");
//         c1.HardDiskSize=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the graphic card size");
//         c1.GraphicCard=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the monitor size");
//         c1.MonitorSize=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the power supply voltage");
//         c1.PowerSupplyVolt=int.Parse(Console.ReadLine());
//         Console.WriteLine("Desktop price is "+c1.DesktopPriceCalculation());
//         }
//         if(option==2){
//         Laptop c1=new Laptop();
//         Console.WriteLine("Enter the processor");
//         c1.Processor=Console.ReadLine();
//         Console.WriteLine("Enter ram size");
//         c1.RamSize=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the hard disk size");
//         c1.HardDiskSize=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the graphic card size");
//         c1.GraphicCard=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the display size");
//         c1.DisplaySize=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the battery volte");
//         c1.BatteryVolt=int.Parse(Console.ReadLine());
//         Console.WriteLine("Laptop price is "+c1.LaptopPriceCalculation());
//         }
//     }
// }

//==============================================================================
// Meeting Question
// using System;
// public class Student
// {
//     public string Id { get; set; }
//     public string Name { get; set; }
//     public string Course { get; set; }
//     public int Marks { get; set; }
// }
// public class StudentUtility
// {
//     public Dictionary<string, string> GetStudentDetails(string id)
//     {
//         Dictionary<string, string> result = new Dictionary<string, string>();

//         foreach (var student in Program.studentDetails.Values)
//         {
//             if (student.Id == id)
//             {
//                 result.Add(student.Id, student.Name + "_" + student.Course);
//                 return result;
//             }
//         }

//         return result;
//     }
//  public Dictionary<string, Student> UpdateStudentMarks(string id, int marks)
//     {
//         Dictionary<string, Student> result = new Dictionary<string, Student>();

//         foreach (var student in Program.studentDetails.Values)
//         {
//             if (student.Id == id)
//             {
//                 student.Marks = marks;
//                 result.Add(student.Id, student);
//                 return result;
//             }
//         }

//         return result;
//     }
// }
// public class Program
// {
//     public static Dictionary<int, Student> studentDetails;

//     public static void Main(string[] args)
//     {
//         studentDetails = new Dictionary<int, Student>()
//         {
//             {1, new Student { Id = "A321", Name = "Harsh", Course = "DataScience", Marks = 85 }},
//             {2, new Student { Id = "A124", Name = "Abhi", Course = "AI", Marks = 78 }},
//             {3, new Student { Id = "A765", Name = "Ankit", Course = "ML", Marks = 88 }}
//         };

//         StudentUtility utility = new StudentUtility();
//         bool run = true;

//         while (run)
//         {
//             Console.WriteLine("1. Get Student Details");
//             Console.WriteLine("2. Update Marks");
//             Console.WriteLine("3. Exit");
//             Console.WriteLine("Enter your choice");

//             int choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Console.WriteLine("Enter the student id");
//                     string id = Console.ReadLine();

//                     var details = utility.GetStudentDetails(id);
//                     if (details.Count == 0)
//                     {
//                         Console.WriteLine("Student id not found");
//                     }
//                     else
//                     {
//                         foreach (var item in details)
//                         {
//                             Console.WriteLine(item.Key + "   " + item.Value);
//                         }
//                     }
//                     break;

//                 case 2:
//                     Console.WriteLine("Enter the student id");
//                     string updateId = Console.ReadLine();

//                     Console.WriteLine("Enter the marks");
//                     int marks = Convert.ToInt32(Console.ReadLine());

//                     var updated = utility.UpdateStudentMarks(updateId, marks);
//                     if (updated.Count == 0)
//                     {
//                         Console.WriteLine("Student id not found");
//                     }
//                     else
//                     {
//                         foreach (var item in updated)
//                         {
//                             Console.WriteLine(item.Key + "   " + item.Value.Marks);
//                         }
//                     }
//                     break;

//                 case 3:
//                     Console.WriteLine("Thank you");
//                     run = false;
//                     break;
//             }
//         }
//     }
// }

//=========================================================================================
//Ques2
// using System;
// class Product
// {
//     public decimal CalculateTotalPrice(decimal price, int quantity)
//     {
//         return price*quantity;
//     }
//     public decimal CalculateTotalPrice(decimal price, int quantity, int discountPercentage)
//     {
//         return (price*quantity)-(price*quantity*discountPercentage/100);
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Product p=new Product();
//         Console.WriteLine("1.Price Without Discount");
//         Console.WriteLine("2.Price With Discount");
//         Console.WriteLine("Enter the choice");
//         int choice=int.Parse(Console.ReadLine());
//         if(choice==1){
//         Console.WriteLine("Enter the price");
//         int price=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the quantity");
//         int quantity=int.Parse(Console.ReadLine());
//         Console.WriteLine("Total price without discount "+p.CalculateTotalPrice(price,quantity));
//         }
//         if(choice==2){
//         Console.WriteLine("Enter the price");
//         int price=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the quantity");
//         int quantity=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the discount percentage");
//         int discountPerc=int.Parse(Console.ReadLine());
//         Console.WriteLine("Total Price with discount "+p.CalculateTotalPrice(price,quantity,discountPerc));
//         }
//     }
// }

//================================================================
//Question3
// using System;
//  public class Car
// {
//     public string Make { get; set; }
//     public string Model{get; set;}
//     public int Year{get; set;}
//     public virtual double CalculatorCost(double basePrice,int currentYear)
//     {
//         return basePrice;
//     }
// }
// public class SportsCar : Car
// {
//     public override double CalculatorCost(double basePrice, int currentYear)
//     {
//         return basePrice+(basePrice*0.1*(currentYear-Year));
//     }
// }
// public class Xuv : Car
// {
//     public override double CalculatorCost(double basePrice,int currentYear)
//     {
//         return basePrice+(basePrice*0.05*(currentYear-Year));
//     }
// }
// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("1.Sports Car");
//         Console.WriteLine("2.SUV car");
//         Console.WriteLine("3.None of the above");
//         Console.WriteLine("Choose the option");
//         int option=int.Parse(Console.ReadLine());

//         Car c=new Car();
//         Console.WriteLine("Enter the make");
//         c.Make=Console.ReadLine();
//         Console.WriteLine("Enter the model");
//         c.Model=Console.ReadLine();
//         Console.WriteLine("Enter the year the car was made");
//         c.Year=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the basic price");
//         int basicPrice=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the current year");
//         int currYear=int.Parse(Console.ReadLine());
//         SportsCar sportsCar=new SportsCar();
//         if (option == 1)
//         {
//             Console.WriteLine("Sports car cost is "+sportsCar.CalculatorCost(basicPrice,currYear));
//         }
//         Xuv xuv=new Xuv();
//         if (option == 2)
//         {
//             Console.WriteLine("XUV car cost is "+xuv.CalculatorCost(basicPrice,currYear));
//         }
//         if (option == 3)
//         {
//             Console.WriteLine("The cost is "+c.CalculatorCost(basicPrice,currYear));
//         }

//     }
// }

//===============================================================
//Ques 4
// using System;
// using System.Runtime.Intrinsics.X86;
// class Shapes
// {
//     public int CalculateArea(int length,int breadth)
//     {
//         return length*breadth;
//     }
//     public double CalculateArea(double length)
//     {
//         return length*length;
//     }
//     public float CalculateArea(float breadth,float height)
//     {
//         return (breadth*height)/2;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("1.Calculate area of rectangle");
//         Console.WriteLine("2.Calculate area of square");
//         Console.WriteLine("3.Calculate area of triangle");
//         Console.WriteLine("Enter your Choice");
//         int choice=int.Parse(Console.ReadLine());
//         Shapes s=new Shapes();
//         if (choice == 1)
//         {
//             Console.WriteLine("Enter the length");
//             int l=int.Parse(Console.ReadLine());
//             Console.WriteLine("Enter the breadth");
//             int b=int.Parse(Console.ReadLine());
//             Console.WriteLine(s.CalculateArea(l,b));
//         }
//         if (choice == 2)
//         {
//             Console.WriteLine("Enter the length");
//             double l=double.Parse(Console.ReadLine());
//             Console.WriteLine(s.CalculateArea(l));
//         }
//         if (choice == 3)
//         {
//             Console.WriteLine("Enter the length");
//             float l=float.Parse(Console.ReadLine());
//             Console.WriteLine("Enter the breadth");
//             float b=float.Parse(Console.ReadLine());
//             Console.WriteLine(s.CalculateArea(l,b));
//         }
//     }
// }


//============================================================================
// using System;
// class Parameters
// {
//     public double Parameter1 {get; set;}
//     public double Parameter2 {get; set;}

// }
// class Triangle : Parameters
// {
//     public double AreaOfTriangle()
//     {
//         return 0.5*Parameter1*Parameter2;
//     }
//     public double AreaOfRectangle()
//     {
//         return Parameter1*Parameter2;
//     }
// }
// class Program
// {
//     static void Main(){
//     Triangle t=new Triangle();    
//     Console.WriteLine("Enter the Parameter1");
//     t.Parameter1=double.Parse(Console.ReadLine());
//     Console.WriteLine("Enter the Parameter2");
//     t.Parameter2=double.Parse(Console.ReadLine());

//     Console.WriteLine("Area of triangle: "+t.AreaOfTriangle());
//     Console.WriteLine("Area of rectangle: "+t.AreaOfRectangle());
//     }
// }
///============================================================
// using System;
// class Loan
// {
//     private string loanNumber;
//     private string loanProviderName;
//     private double loanAmount;

//     public string LoanNumber{get;set;}
//     public string LoanProviderName{get; set;}
//     public double LoanAmount{get;set;}
// }
// class PersonalLoan : Loan
// {
//     private int numberOfYears;
//     private float interestRate;

//     public int NumberOfYears{get;set;}
//     public float InterestRate{get;set;}
//     public double CalculateEMI()
//     {
//         return (LoanAmount+(LoanAmount*NumberOfYears*InterestRate*0.01))/(NumberOfYears*12);
//     }
// }
// class HomeLoan : Loan
// {
//     private int houseAge;
//     private float interestRate;

//     public int HouseAge{get;set;}
//     public float InterestRate{get;set;}
//     public double CalculateEMI()
//     {
//          return (LoanAmount+(LoanAmount*InterestRate*0.01))/(HouseAge*12);
//     }
// }
// class Program
// {
//     public static double AddLoan(Loan loan,int opt)
//     {
//         if (opt == 1)
//         {
//             PersonalLoan personalLoan=(PersonalLoan)loan;
//             return personalLoan.CalculateEMI();
//         }
//          else
//         {
//             HomeLoan homeLoan=(HomeLoan)loan;
//             return homeLoan.CalculateEMI();
//         }
//     }
//         public static void Main(string[] args)
//     {
//         Loan l=new Loan();
//         Console.WriteLine("Loan Number: ");
//         l.LoanNumber=Console.ReadLine();
//         Console.WriteLine("Enter Provider Name: ");
//         l.LoanProviderName=Console.ReadLine();
//         Console.WriteLine("Loan Amount Covered: ");
//         double loanAmount=double.Parse(Console.ReadLine());

//         Console.WriteLine("Select");
//         Console.WriteLine("1.Personal Loan");
//         Console.WriteLine("2.Home Loan");

//         int option=int.Parse(Console.ReadLine());
//         if (option == 1)
//         {
//             PersonalLoan personalLoan=new PersonalLoan();
//             personalLoan.LoanAmount=loanAmount;
//             Console.WriteLine("Number of years ");
//             personalLoan.NumberOfYears=int.Parse(Console.ReadLine());
//             Console.WriteLine("Interest Rate: ");
//             personalLoan.InterestRate=float.Parse(Console.ReadLine());
//             Console.WriteLine("Calculated EMI: "+(int)AddLoan(personalLoan,option));
//         }
//         if (option == 2)
//         {
//             HomeLoan homeLoan=new HomeLoan();
//             homeLoan.LoanAmount=loanAmount;
//             Console.WriteLine("House Age: ");
//             homeLoan.HouseAge=int.Parse(Console.ReadLine());
//             Console.WriteLine("Interest Rate: ");
//             homeLoan.InterestRate=float.Parse(Console.ReadLine());
//             Console.WriteLine("Calculated EMI: " +(int)AddLoan(homeLoan,option));

//         }
//     }
// }

//=========================================================
//Abstract class and interface 
// using System;
// abstract class Employee
// {
//     public string Id{get; set;}
//     public string Name{get;set;}
//     public double Salary{get;set;}
//     public bool ValidateEmployeeId()
//     {
//         if(Id.Length==5 && Id[0]=='E'&&Id[1]=='M' && char.IsDigit(Id[2]) &&char.IsDigit(Id[3])&&char.IsDigit(Id[4]))
//         return true;
//         else
//         return false;
//     }
//     public abstract Employee SalaryCalculation();
// }
// class Permanent : Employee
// {
//     public double BasicPay{get;set;}
//     public override Employee SalaryCalculation()
//     {
//         Salary=BasicPay+0.5*BasicPay+0.3*BasicPay;
//         return this;

//     }
// }
// class Temporary : Employee
// {
//     public int HrsWorked{get;set;}
//     public int HrlyWages{get;set;}
//      public override Employee SalaryCalculation()
//     {
//         Salary=HrsWorked*HrlyWages;
//         return this;

//     }
// }
// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("1.Permanent");
//         Console.WriteLine("2.Temporary");
//         Console.WriteLine("Choose the employee type");
//         int option=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter employee id");

//         if(option==1){
//         Permanent p=new Permanent();
//         p.Id=Console.ReadLine();
//             if (!p.ValidateEmployeeId())
//             {
//                 Console.WriteLine("Invalid id");
//                 return;
//             }
//         Console.WriteLine("Enter the name");
//         p.Name=Console.ReadLine();
//         Console.WriteLine("Enter basic pay");
//         p.BasicPay=double.Parse(Console.ReadLine());
//         p.SalaryCalculation();
//         Console.WriteLine($"Employee Id: {p.Id} Name: {p.Name} Salary: {p.Salary}");
//         }
//         if(option==2){
//         Temporary t=new Temporary();
//         t.Id=Console.ReadLine();
//             if (!t.ValidateEmployeeId())
//             {
//                 Console.WriteLine("Invalid id");
//                 return;
//             }
//         Console.WriteLine("Enter the name");
//         t.Name=Console.ReadLine();
//         Console.WriteLine("Enter hours worked");
//         t.HrsWorked=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter hourly wages");
//         t.HrlyWages=int.Parse(Console.ReadLine());
//         t.SalaryCalculation();
//         Console.WriteLine($"Employee Id: {t.Id} Name: {t.Name} Salary: {t.Salary}");
//         }
//     }
// }

//===============================================================
//Interface
// using System;
// interface IAccount
// {
//     public string AccountNumber { get; set; }
//     public double Balance { get; set; }
//     public double InterestRate { get; set; }
//     double CalculateInterest();
// }
// class SavingAccount : IAccount
// {
//     public string AccountNumber { get; set; }
//     public double Balance { get; set; }
//     public double InterestRate { get; set; }
//     public double CalculateInterest()
//     {
//         double interest=Balance*InterestRate/100;
//         if (Balance < 1000)
//         {
//             interest-=Balance*0.1/100;
//         }
//         return interest;

//     }
// }
// class CheckingAccount: IAccount
// {
//     public string AccountNumber { get; set; }
//     public double Balance { get; set; }
//     public double InterestRate { get; set; }
//     public double CalculateInterest()
//     {
//         double interest=Balance*InterestRate/100;
//         if (Balance < 5000)
//         {
//             interest-=Balance*0.5/100;
//         }
//         return interest;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("1.Saving account");
//         Console.WriteLine("2.Checking account");
//         Console.WriteLine("Choose the option");
//         int option=int.Parse(Console.ReadLine());
//         if(option==1){
//         IAccount account=new SavingAccount();
//         Console.WriteLine("Enter account number");
//         account.AccountNumber=Console.ReadLine();
//         Console.WriteLine("Enter balance amount");
//         account.Balance=double.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the interest rate");
//         account.InterestRate=double.Parse(Console.ReadLine());
//         Console.WriteLine("Interest amount is "+account.CalculateInterest());
//         }
//          if(option==2){
//         IAccount account1=new CheckingAccount();
//         Console.WriteLine("Enter account number");
//         account1.AccountNumber=Console.ReadLine();
//         Console.WriteLine("Enter balance amount");
//         account1.Balance=double.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the interest rate");
//         account1.InterestRate=double.Parse(Console.ReadLine());
//         Console.WriteLine("Interest amount is "+account1.CalculateInterest());
//         }
//     }
// }

//===========================================================
//Generic class  //most important
// using System;
// using System.Reflection.Metadata;
// class Employee<Y> where Y:class
// {
//     public int Id { get; set; }
//     public string  Name { get; set; }
//     public string DOB { get; set; }

//     static List<Employee<string>> empList=new List<Employee<string>>()
//     {
//         new Employee<string>{ Id = 180315, Name = "Rosy", DOB = "10/07/1999"},
//         new Employee<string>{ Id = 180316, Name = "David", DOB = "05/03/1998"},
//         new Employee<string>{ Id = 180317, Name = "Peter", DOB = "12/12/2000"}
//     };
//     public bool UsernamePasswordChecking<T>(T empId,Y empDOB)
//     {
//         foreach(var item in empList)
//         {

//             if(item.Id.Equals(empId) && item.DOB.Equals(empDOB))  //important
//             return true;
//         }
//         return false;
//     }
//     public double SalaryCalculation(double basicPay)
//     {

//         return basicPay+basicPay*40/100+basicPay*20/100;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Employee<string> employee=new Employee<string>();

//         Console.WriteLine("Enter the user name");
//         int username=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the password");
//         string pass=Console.ReadLine();

//         bool valid=employee.UsernamePasswordChecking<int>(username,pass);
//         if (!valid)
//         {
//             Console.WriteLine("Invalid user name or password");
//         }
//         else
//         {
//              Console.WriteLine("Enter the basic pay");
//              int bPay=int.Parse(Console.ReadLine());
//              Console.WriteLine("The employee's total salary is "+employee.SalaryCalculation(bPay));
//         }

//     }
// }

//==============================================================
//indexer
// using System;
// class UserInput
// {
//     private int[] arr=new int[5];
//     public int this[int index]
//     {
//         get{return arr[index];}
//         set{arr[index]=value;}

//     }
//     public int Sum()
//     {
//        int sum=0;
//        for(int i = 0; i < arr.Length; i++)
//         {
//             sum+=arr[i];
//         }
//         return sum;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//          Console.WriteLine("Enter the Values");
//          UserInput userInput=new UserInput();
//          for(int i = 0; i < 5; i++)
//         {
//             userInput[i]=int.Parse(Console.ReadLine());
//         }
//         Console.WriteLine("Sum of values: "+userInput.Sum());
//     }
// }

//===========================================================
//sealed class
// sealed class Account
// {
//     public string  AccountNumber { get; set; }
//     public double Balance { get; set; }
//     public double InterestRate { get; set; }
// }
// class AccountUtility
// {
//     public double CalculateInterest(Account ac)
//     {
//         return ac.Balance*ac.InterestRate/100;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Account accountObj=new Account();

//         Console.WriteLine("Enter account Number");
//         accountObj.AccountNumber=Console.ReadLine();

//         Console.WriteLine("Enter the balance amount");
//         accountObj.Balance = double.Parse(Console.ReadLine());

//         Console.WriteLine("Enter the interest rate");
//         accountObj.InterestRate = double.Parse(Console.ReadLine());

//         AccountUtility accountUtility=new AccountUtility();
//         Console.WriteLine("Interset amount is "+accountUtility.CalculateInterest(accountObj));
//     }
// }

//=============================================================
//enum
// using System;

// // Enum
// public enum CardType
// {
//     Gold,
//     Silver,
//     Bronze,
//     Null
// }

// Struct
// public struct Purchase
// {
//     public CardType MemberCardType { get; set; }

//     public double CaluclateNetPayableAmount(CardType type, double purchaseAmount)
//     {
//         double amountReduced = 0;

//         switch (type)
//         {
//             case CardType.Gold:
//                 amountReduced = 1000;
//                 break;

//             case CardType.Silver:
//                 amountReduced = 500;
//                 break;

//             case CardType.Bronze:
//                 amountReduced = 200;
//                 break;

//             case CardType.Null:
//                 amountReduced = 0;
//                 break;
//         }

//         return purchaseAmount - amountReduced;
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Enter purchase amount");
//         double purchaseAmount = double.Parse(Console.ReadLine());

//         Console.WriteLine("Enter card type");
//         string input = Console.ReadLine();

//         // Convert string to enum (case-sensitive)
//         CardType type = (CardType)Enum.Parse(typeof(CardType), input);

//         Purchase purchase = new Purchase();
//         double result = purchase.CaluclateNetPayableAmount(type, purchaseAmount);

//         if (result < 0)
//         {
//             Console.WriteLine("You need not pay any amount");
//         }
//         else
//         {
//             Console.WriteLine("Net payable amount : " + result);
//         }
//     }
// }


//=========================================================
// using System;

// public class Program
// {
//     // Method 1: Generate 3 random numbers within range
//     public int[] GetRandomNumbersByRange(int minRange, int maxRange)
//     {
//         int[] numbers = new int[3];

//         Random random = new Random();

//         for (int i = 0; i < 3; i++)
//         {
//             numbers[i] = random.Next(minRange, maxRange);
//         }

//         return numbers;
//     }

//     // Method 2: Generate random number using seed
//     public int GenerateRandomNumberBySeedValue(int seed)
//     {
//         Random random = new Random(seed);
//         return random.Next();
//     }

//     public static void Main()
//     {
//         Program obj = new Program();

//         Console.WriteLine("Enter the minimum range value");
//         int min = int.Parse(Console.ReadLine());

//         Console.WriteLine("Enter the maximum range value");
//         int max = int.Parse(Console.ReadLine());

//         Console.WriteLine("Enter the seed value");
//         int seed = int.Parse(Console.ReadLine());

//         int[] result = obj.GetRandomNumbersByRange(min, max);

//         foreach (int num in result)
//         {
//             Console.WriteLine(num);
//         }

//         int seedResult = obj.GenerateRandomNumberBySeedValue(seed);

//         Console.WriteLine("Random number for seed value " + seed + " is  " + seedResult);
//     }
// }

//=================================================================
//Exception handling
// class Account
// {
//     public string  AccountNumber { get; set; }
//     public decimal Balance { get; set; }

//     public decimal Deposit(decimal amount)
//     {
//         try{
//         if (amount > 0)
//         {
//             Balance+=amount;
//         }
//             else
//             {
//                 throw new ArgumentException("Deposit amount must be positive.");
//             }
//         }
//         catch(ArgumentException ex)
//         {
//             Console.WriteLine(ex.Message);

//         }
//         return Balance;
//     }
//     public decimal Withdraw(decimal amount)
//     {
//         try{
//         if (amount <= 0)
//         {
//           throw new ArgumentException("Withdrawal amount must be positive.");
//         }
//             if (amount > Balance)
//             {
//                 throw new InvalidOperationException("Insufficient finds");
//             }
//             else
//             {
//                 Balance-=amount;
//             }
//         }
//         catch(ArgumentException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//         catch(InvalidOperationException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//         return Balance;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("1.Deposite");
//         Console.WriteLine("2.Withdraw");
//         Console.WriteLine("Enter the choice");
//         int choice=int.Parse(Console.ReadLine());

//          Account acc = new Account();

//         Console.WriteLine("Enter the account number");
//         acc.AccountNumber = Console.ReadLine();

//         Console.WriteLine("Enter the balance");
//         acc.Balance = Convert.ToDecimal(Console.ReadLine());

//         if (choice == 1)
//         {
//             Console.WriteLine("Enter the amount to be deposit");
//             decimal amount = Convert.ToDecimal(Console.ReadLine());

//             decimal result = acc.Deposit(amount);
//             Console.WriteLine("Balance amount " + result);
//         }
//         else if (choice == 2)
//         {
//             Console.WriteLine("Enter the amount to be withdraw");
//             decimal amount = Convert.ToDecimal(Console.ReadLine());

//             decimal result = acc.Withdraw(amount);
//             Console.WriteLine("Balance amount " + result);
//         }

//     }
// }
//==================================================================
//custom exception
// using System;

// // Custom Exception Class
// public class InvalidFlavourException : Exception
// {
//     public InvalidFlavourException(string message) :base(message)
//     {
//     }
// }

// public class Cake
// {
//     public string Flavour { get; set; }
//     public int QuantityInKg { get; set; }
//     public double PricePerKg { get; set; }

//     public bool CakeOrder()
//     {
//         if (Flavour != "Chocolate" && 
//             Flavour != "Red Velvet" && 
//             Flavour != "Vanilla")
//         {
//             throw new InvalidFlavourException(
//                 "Flavour not available. Please select the available flavour");
//         }


//         if (QuantityInKg <= 0)
//         {
//             throw new Exception("Quantity must be greater than zero");
//         }

//         return true;
//     }


//     public double CalculatePrice()
//     {
//         double totalPrice = QuantityInKg * PricePerKg;
//         double discount = 0;

//         if (Flavour == "Vanilla")
//             discount = 3;
//         else if (Flavour == "Chocolate")
//             discount = 5;
//         else if (Flavour == "Red Velvet")
//             discount = 10;

//         double discountedPrice = totalPrice - (totalPrice * discount / 100);
//         return discountedPrice;
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Cake cake = new Cake();

//         Console.WriteLine("Enter the flavour");
//         cake.Flavour = Console.ReadLine();

//         Console.WriteLine("Enter the quantity in kg");
//         cake.QuantityInKg = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter the price per kg");
//         cake.PricePerKg = Convert.ToDouble(Console.ReadLine());

//         try
//         {
//             if (cake.CakeOrder())
//             {
//                 Console.WriteLine("Cake order was successful");
//                 double price = cake.CalculatePrice();
//                 Console.WriteLine("Price after discount is " + price);
//             }
//         }
//         catch (InvalidFlavourException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }


//==================================================================
// class Program
// {
//     static void Main()
//     {
//         try{
//         Console.WriteLine("Enter the result");
//         float result=float.Parse(Console.ReadLine());
//         Console.WriteLine("Result: "+result.ToString("f2")+"%");
//         }
//        catch(Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }

//===================================================================================
// class VotingException : Exception
// {
//     public VotingException(string message) : base(message)
//     {

//     }
// }
// class Program
// {
//     public String CheckVotersAge(int age)
//     {
//         try{
//         if (age >= 18)
//         {
//             return "Voting is eligible";
//         }
//         else
//         {
//             throw new VotingException("Voting is not eligible");
//         }
//         }
//         catch(VotingException ex)
//         {
//             return ex.Message;
//         }
//     }
//     static void Main()
//     {
//         Console.WriteLine("Enter the age:");
//         int age=int.Parse(Console.ReadLine());
//         Program p=new Program();
//        Console.WriteLine(p.CheckVotersAge(age));
//     }
// }

//============================M1Practice===========================
// class Fish
// {
//     public string Species { get; set; }
//     public double PricePerFish { get; set; }
// }
// class FishUtility:Fish
// {
//     public void AddFish(string species, double pricePerFish)
//     {
//         Species=species;
//         PricePerFish=pricePerFish;
//     }
//     public bool BuyFish()
//     {

//         if(Species=="Clownfish"||Species=="Goldfish")
//         return true;
//         else
//         return false;
//     }
//     public double CalculatePrice(int numberOfFishes)
//     {
//         double result=0;
//         if(Species=="Clownfish")
//         result=(numberOfFishes*PricePerFish)+100;
//         if(Species=="Goldfish")
//         result=(numberOfFishes*PricePerFish)+150;

//         return result;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the species to buy");
//         string spec=Console.ReadLine();
//         Console.WriteLine("Enter the price per fish");
//         double priceperfish=double.Parse(Console.ReadLine());

//         FishUtility fishUtility=new FishUtility();
//         fishUtility.AddFish(spec,priceperfish);
//         if (fishUtility.BuyFish())
//         {
//              Console.WriteLine("Enter the number of fishes you need to buy");
//         int number=int.Parse(Console.ReadLine());
//             Console.WriteLine("Total cost is: "+fishUtility.CalculatePrice(number));
//         }
//         if (!fishUtility.BuyFish())
//         {
//             Console.WriteLine($"{spec} species not found");
//         }

//     }
// }


//============================================================
// using System;
// using System.Collections.Generic;

// public class BabyDress
// {
//     public int Size { get; set; }
//     public string Color { get; set; }
//     public string Brand { get; set; }
//     public double Price { get; set; }
// }

// public class BabyDressUtility
// {
//     public void AddDressToCart(BabyDress dress)
//     {
//         Program.DressesCart.Add(dress);
//     }

//     public bool RemoveDressFromCart(string brand)
//     {
//         foreach (BabyDress dress in Program.DressesCart)
//         {
//             if (dress.Brand == brand)
//             {
//                 Program.DressesCart.Remove(dress);
//                 return true;
//             }
//         }
//         return false;
//     }
// }

// public class Program
// {
//     public static List<BabyDress> DressesCart { get; set; } = new List<BabyDress>();

//     public static void Main(string[] args)
//     {
//         BabyDressUtility utility = new BabyDressUtility();
//         bool exit = false;

//         while (!exit)
//         {
//             Console.WriteLine("1. Add dress to cart");
//             Console.WriteLine("2. Remove dress from cart");
//             Console.WriteLine("3. Exit");
//             Console.WriteLine("Enter your choice");

//             int choice = int.Parse(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     BabyDress dress = new BabyDress();

//                     Console.WriteLine("Enter the dress size");
//                     dress.Size = int.Parse(Console.ReadLine());

//                     Console.WriteLine("Enter the dress color");
//                     dress.Color = Console.ReadLine();

//                     Console.WriteLine("Enter the dress brand");
//                     dress.Brand = Console.ReadLine();

//                     Console.WriteLine("Enter the dress price");
//                     dress.Price = double.Parse(Console.ReadLine());

//                     utility.AddDressToCart(dress);
//                     Console.WriteLine("\nSuccessfully added to the dress cart\n");
//                     break;

//                 case 2:
//                     Console.WriteLine("Enter the dress brand to remove the dress from cart");
//                     string brand = Console.ReadLine();

//                     bool removed = utility.RemoveDressFromCart(brand);

//                     if (removed)
//                         Console.WriteLine("\nSuccessfully removed from the cart\n");
//                     else
//                         Console.WriteLine("\nDress not found in the cart\n");
//                     break;

//                 case 3:
//                     Console.WriteLine("\nThank you!");
//                     exit = true;
//                     break;
//             }
//         }
//     }
// }
