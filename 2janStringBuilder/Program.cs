using System;
using System.Collections;
using System.Globalization;
using System.Text;
class Program
{
    public static void Main(string[] args){
    // StringBuilder sb=new StringBuilder("Hello World!");
    // for(int i=0;i<sb.Length;i++){
    //     Console.Write(sb[i]);
    // }
    // Console.WriteLine();
    // StringBuilder sb1=new StringBuilder();
    // sb1.AppendLine("World!");
    // sb1.AppendLine("World!");
    // sb1.AppendLine("Hello C#");
    // Console.Write(sb1);

    // StringBuilder sbAmount=new StringBuilder("Your total Amount is ");
    // sbAmount.AppendFormat("{0:c} ",25);
    // CultureInfo india=new CultureInfo("en-IN");
    // sbAmount.AppendFormat(india, "{0:C}",12345678);
    // Console.WriteLine(sbAmount);

    // StringBuilder sb2=new StringBuilder("Hello World!");
    // sb2.Insert(5," C#");
    // Console.WriteLine(sb2);

    // StringBuilder sb3=new StringBuilder("Hello World!",50);
    // sb3.Remove(5,6);
    // Console.WriteLine(sb3);

    //===========================collections=================================
    ArrayList list=new ArrayList();
    Employee emplyee1=new Employee(){Id=10,Name="Harsh"};
    Employee emplyee2=new Employee(){Id=20,Name="Rahul"};
    Employee emplyee3=new Employee(){Id=30,Name="Ravi"};
    list.Add(10);
    list.Add(20);
    list.Add(30);
    list.Add(40);
    list.Add(50);
    list.Add(60.45f);
    list.Add(false);
    list.Add(emplyee1);
    list.Add(emplyee2);
    list.Add(emplyee3);


    Console.WriteLine("Number of element in list: "+list.Count);

    foreach(var item in list)
        {
            Console.WriteLine(item);
        }

    ArrayList list1=new ArrayList();
    list1.Add(80);
    list1.Add(70);
    list1.Add(40);
    list.AddRange(list1);
    foreach(var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Number of element: "+list.Count);
    //   list.Clear();
    //   Console.WriteLine("Count of Array list after clearing list: "+list.Count);

    // foreach(var item in list)
    //     {
    //         Console.WriteLine(item);
    //     }

        if (list.Contains(50))
        {
            Console.WriteLine($"Object 50 is at index no {list.IndexOf(50)}");
        }
        else
        {
            Console.WriteLine("Object Not found");
        }

        list.RemoveAt(5);
        Console.WriteLine("After removing value at index 5: ");
        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
        list.Remove(false);
        Console.WriteLine("List after removing value false from the list: ");
        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
     

     list.RemoveRange(5,3);
     Console.WriteLine("\n\n\n list After removing range from the list: ");
     foreach(var item in list)
        {
            Console.WriteLine(item);
        }
        
    Console.WriteLine("List Before sorting: ");
    foreach(var item in list)
        {
            Console.WriteLine(item);
        }
        list.Sort();
    Console.WriteLine("List After sorting: ");
    foreach(var item in list)
        {
            Console.WriteLine(item);
        }  

    list.Reverse();
    Console.WriteLine("After Reverse: ");
    foreach(var item in list)
        {
            Console.WriteLine(item);
        }
    list.Insert(0,34);
    foreach(var item in list)
        {
            Console.WriteLine(item);
        }
    ArrayList list3=new ArrayList();
    list3.Add(56);
    list3.Add(87);
    list3.Add(98);
    list.InsertRange(5,list3);
    foreach(var item in list)
        {
            Console.WriteLine(item);
        }
}
}