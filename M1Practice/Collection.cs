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
