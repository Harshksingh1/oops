// using System;
// using System.Collections;
// using System.Net.Mail;
// class Program
// {
//     public static ArrayList Attendence=new ArrayList();

//     public bool RemoveStudent(string name)
//     {
//         if(Attendence.Contains(name)){
//         Attendence.Remove(name);
//         return true;
//         }
//         else
//         {
//             return false;
//         }

//     }
//     public void SortTheAttendence()
//     {
//         Attendence.Sort();
//         foreach(var v in Attendence)
//         {
//             Console.WriteLine(v);
//         }
//     }
//     public static void Main(string[] args)
//     {
//         Attendence.Add("John");
//         Attendence.Add("Peter");
//         Attendence.Add("Jacob");
//         Attendence.Add("Archie");
//         Attendence.Add("Sophie");
//         Attendence.Add("Veronica");
//         Attendence.Add("Elizabeth");
//         Attendence.Add("Charles");
//         Console.WriteLine("1.Remove student");
//         Console.WriteLine("2.Sort attendence");
//         Console.WriteLine("Enter your choice");
//         int choice=int.Parse(Console.ReadLine());

//         Program program=new Program();
//         if(choice==1){
//         Console.WriteLine("Enter the student name");
//         string name=Console.ReadLine();
//          bool result=program.RemoveStudent(name);

//             if (result)
//             {
//                 Console.WriteLine("Student removed Succesfully");
//             }
//         }
//         if (choice == 2)
//         {
//             program.SortTheAttendence();
//         }

//     }
// }

//===============================================================
// using System.Collections;


// class Case
// {
//     public int CaseNo{get;set;}
//     public string CaseCode{get;set;}
//     public string CaseContent{get;set;}
//     public DateTime Date{get;set;}=new DateTime();
// }
// class Program
// {
//     public static List<Case> CaseFile=new List<Case>();
//     public bool AddToList(Case caseObj)
//     {
//        if (caseObj != null)
//         {
//             CaseFile.Add(caseObj);
//             return true;
//         }
//         return false;
//     } 
//     public bool DeleteFromList(int caseNo)
//     {
//        foreach(var v in CaseFile)
//         {
//             if (v.CaseNo == caseNo)
//             {
//                 CaseFile.Remove(v);
//                 return true;
//             }
//         }
//         return false;
//     }
//     static void Main()
//     {
//         while(true){
//         Console.WriteLine("1.Add to the list");
//         Console.WriteLine("2.Delete from the list");
//         Console.WriteLine("Enter your choice");
//         int choice=int.Parse(Console.ReadLine());
//         Program p=new Program();
//         if (choice == 1)
//         {
//         Case c=new Case();
//         Console.WriteLine("Enter the case no");
//         c.CaseNo=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the case code");
//         c.CaseCode=Console.ReadLine();
//         Console.WriteLine("Enter the case content");
//         c.CaseContent=Console.ReadLine();
//         Console.WriteLine("Enter the date");
//         c.Date=DateTime.Parse(Console.ReadLine());
//             bool result=p.AddToList(c);
//             if (result)
//             {
//                 Console.WriteLine("Added successfully");
//             }
//             else
//             {
//                 Console.WriteLine("Failed");
//             }
//         }
//         else if (choice == 2)
//         {
//             Console.WriteLine("Enter the case no");
//             int caseNumber=int.Parse(Console.ReadLine());
//             bool result1=p.DeleteFromList(caseNumber);
//             if (result1)
//             {
//                 Console.WriteLine("Deleted successfully");
//             }
//             else
//             {
//                 Console.WriteLine("Failed");
//             }
//         }
//             else
//             {
//                 break;
//             }
//         }
//     } 
// }

//===================================================================
//Dictionary
// using System.Linq;
// using Microsoft.VisualBasic;

// class Course
// {
//     public void AddCourseDetails(string name, int fee)
//     {
//         Program.CourseDetails.Add(name,fee);
//         Console.WriteLine("Course details added succesfully");
//     }
//     public void RemoveCourseDetails(string name)
//     {
//         foreach(var v in Program.CourseDetails)
//         {
//           ================================================
//             if(Program.CourseDetails.ContainsKey(name))
//             Program.CourseDetails.Remove(name);
//           ================================================
//         }
//         Console.WriteLine("Course details removed succesfully");
//     }
//     public Dictionary<string, int> SortCourseByFee()
//     {
//         return Program.CourseDetails
//                 .OrderBy(x=>x.Value)
//                 .ToDictionary(x=>x.Key,x=>x.Value);
//     }
// }
// public class Program
// {
//     public static Dictionary<string,int> CourseDetails=new Dictionary<string, int>();
//     static void Main()
//     {
//         while(true){
//         Console.WriteLine("1.Add Course Details");
//         Console.WriteLine("2.Remove Course Details");
//         Console.WriteLine("3.Sort Course By Fee");
//         Console.WriteLine("4.Exit");
//         Console.WriteLine("Enter your choice");
//         int choice=int.Parse(Console.ReadLine());


//         Course c=new Course();
//         if (choice == 1)
//         {
//         Console.WriteLine("Enter the course name");
//         string coursename=Console.ReadLine();

//         Console.WriteLine("Enter the course fee");
//         int coursefee=int.Parse(Console.ReadLine());
//         c.AddCourseDetails(coursename,coursefee);
//         }
//         if (choice == 2)
//         {
//             Console.WriteLine("Enter the course name");
//             string coursename1=Console.ReadLine();
//             c.RemoveCourseDetails(coursename1);
//         }
//         if (choice == 3)
//         {
//             c.SortCourseByFee();
//             foreach(var item in CourseDetails)
//             {
//                 Console.WriteLine($"{item.Key} {item.Value}");
//             }
//         }
//         if (choice == 4)
//         {
//             Console.WriteLine("Thank you");
//             break;
//         }
//     }
//     }
// }
//============================================================================================================================
//most important on Dict
// class Program
// {
//     public static Dictionary<int,Jewellery> jewelleryDetails=new Dictionary<int, Jewellery>()
//     {
//         {1,new Jewellery{Id="JW01",Type="Bracelet",Material="Silver",Price=120000}},
//         {2,new Jewellery{Id="JW02",Type="Necklace",Material="Gold",Price=220000}},
//         {3,new Jewellery{Id="JW03",Type="Ear rings",Material="Platinum",Price=320000}},
//     };
//     public static void Main()
//     {
//         while(true){
//         Console.WriteLine("1.Get Jewellery Details");
//         Console.WriteLine("2.Update Price");
//         Console.WriteLine("3.Exit");
//         Console.WriteLine("Enter your choice");
//         int choice=int.Parse(Console.ReadLine());


//             JewellerUtility jewellerUtility = new JewellerUtility();
//             if (choice == 1)
//             {
//                 Console.WriteLine("Enter the jewellery id");
//                 string jewelleryId = Console.ReadLine();
//                 var res = jewellerUtility.GetJewelleryDetails(jewelleryId);
//                 if (res.Count == 0)
//                 {
//                     Console.WriteLine("Jwellery id not found");
//                 }
//                 else
//                 {
//                     foreach (var item in res)
//                     {
//                         Console.WriteLine($"{item.Key} {item.Value}");
//                     }
//                 }
//             }
//             if (choice == 2)
//             {
//                 Console.WriteLine("Enter the jewellery id");
//                 string jewelleryId = Console.ReadLine();
//                 Console.WriteLine("Enter the price to be updated");
//                 int newprice = int.Parse(Console.ReadLine());
//                 var res1 = jewellerUtility.UpdateJewelleryPrice(jewelleryId, newprice);
//                 if (res1.Count == 0)
//                 {
//                     Console.WriteLine("Jwellery id not found");
//                 }
//                 else
//                 {
//                     foreach (var item in res1)
//                     {
//                         Console.WriteLine($"Id:{item.Key} Tpye:{item.Value.Type} Material:{item.Value.Material} Price:{item.Value.Price}");
//                     }
//                 }
//             }
//             if (choice == 3)
//         {
//             Console.WriteLine("Thank you ");
//             break;
//         }
//         }
//     }
// }
// class Jewellery
// {
//     public string Id { get; set; }
//     public string Type { get; set; }
//     public string Material { get; set; }
//     public int Price { get; set; }

// }
// class JewellerUtility
// {
//     public Dictionary<string, string> GetJewelleryDetails(string id)
//     {
//         Dictionary<string,string> result=new Dictionary<string, string>();
//         foreach(var item in Program.jewelleryDetails)
//         {
//             if (item.Value.Id == id)
//             {
//                 result.Add(item.Value.Id,item.Value.Type+"_"+item.Value.Material);
//                 return result;
//             }
//         }
//         return result;
//     }
//     public Dictionary<string, Jewellery> UpdateJewelleryPrice(string id, int price)
//     {
//         Dictionary<string,Jewellery> result1=new Dictionary<string, Jewellery>();
//         foreach(var item in Program.jewelleryDetails)
//         {
//             if (item.Value.Id == id)
//             {
//                 item.Value.Price=price;
//                 result1.Add(id,item.Value);
//                 return result1;
//             }
//         }
//         return result1;
//     }
// }
//=======================================================================================================


class Program
{
    public static SortedDictionary<int,Mobile> mobileDetails=new SortedDictionary<int, Mobile>(); 
    public static void Main()
    {
        while(true){
        Console.WriteLine("1.Add Mobile Details");
        Console.WriteLine("2.Group Mobiles By Brand");
        Console.WriteLine("3.Exit");
        Console.WriteLine("Enter the choice");

        int choice=int.Parse(Console.ReadLine());
        MobileUtility mobileUtility=new MobileUtility();
        if (choice == 1)
        {
            Console.WriteLine("Enter the mode");
            string model = Console.ReadLine();
            Console.WriteLine("Enter the brand");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter the price");
            int price =int.Parse(Console.ReadLine());

            
            mobileUtility.AddMobileDetails(model,brand,price);
            Console.WriteLine("Mobile details added successfully");
        }
        if (choice == 2)
        {
           var ans=mobileUtility.GroupMobilesByBrand();
           foreach(var i in ans)
            {
                Console.WriteLine(i.Key);
                foreach (var m in i.Value)
                {
                    Console.WriteLine(m.Model); 
                }
            }
            
        }
        if(choice == 3)
            {
                Console.WriteLine("Thank you");
                break;
            }
        }
    }
}
class Mobile
{
    public string Model{get;set;}
    public string Brand { get; set; }
    public int Price { get; set; }

}
class MobileUtility
{
    public void AddMobileDetails(string model, string brand, int price)
    {
        int key=Program.mobileDetails.Count+1;
        Mobile mobile=new Mobile();
            mobile.Model=model;
            mobile.Brand=brand;
            mobile.Price=price;
        
        Program.mobileDetails.Add(key,mobile);
    }
    public SortedDictionary<string, List<Mobile>> GroupMobilesByBrand()
    {
        SortedDictionary<string,List<Mobile>> result=new SortedDictionary<string, List<Mobile>>();
        
        foreach(var item in Program.mobileDetails.Values)
        {
            if (!result.ContainsKey(item.Brand))
            {
                List<Mobile> list=new List<Mobile>();
                foreach(var it in Program.mobileDetails.Values)
                {
                    if (it.Brand == item.Brand)
                    {
                        list.Add(it);
                    }
                }
                result.Add(item.Brand,list);
            }
        }
        return result;
    }
}