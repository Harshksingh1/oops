using System;
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        //===========================Hashtable=========================================
        // Hashtable hashtable=new Hashtable();
        // hashtable.Add(100,"Rajesh");
        // hashtable.Add(200,"Suresh");
        // hashtable.Add(400,"Harsh");
        // hashtable.Add(500,"Vivek");
        // ICollection key=hashtable.Keys;
        // foreach(var k in key)
        // {
        //     Console.WriteLine(k);
        // }
        // ICollection value=hashtable.Values;
        // foreach(var v in value)
        // {
        //     Console.WriteLine(v);
        // }
    
        // foreach(var key1 in key)
        // {
        //     Console.WriteLine(key1+" "+ hashtable[key1]);
        // }

        // if (hashtable.ContainsKey(200))
        // {
        //     Console.WriteLine("found 200 with value: "+hashtable[200]);
        // }
        // else
        // {
        //     Console.WriteLine("Key not found");
        // }
        
        //============================sorted list================================
        // SortedList list=new SortedList();
        // list.Add(100,"Rajesh");
        // list.Add(200,"Suresh");
        // list.Add(400,"Harsh");
        // list.Add(500,"Vivek");
        // ICollection key=list.Keys;
        // foreach(var k in key)
        // {
        //     Console.WriteLine(k);
        // }
        // ICollection value=list.Values;
        // foreach(var v in value)
        // {
        //     Console.WriteLine(v);
        // }
    
        // foreach(var key1 in key)
        // {
        //     Console.WriteLine(key1+" "+ list[key1]);
        // }
        // Console.WriteLine(list.IndexOfKey(500)+" "+list.IndexOfValue("Vivek"));
        // // list.Clear();
        // int count=list.Count;
        // Console.WriteLine(count);

        //======================Stack=====================================
        // Stack stack=new Stack();
        // stack.Push('A');
        // stack.Push('B');
        // stack.Push('F');
        // stack.Push('G');
        // stack.Push('J');
        // foreach(var item in stack)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine("Element at Top: "+stack.Peek());
        // stack.Pop();

        // if (stack.Contains('F'))
        // {
        //     Console.WriteLine("F Found");
        // }
        // else
        // {
        //     Console.WriteLine("Not found");
        // }
       ///============queue==========================
        // Queue queue=new Queue();
        // queue.Enqueue('A');
        // queue.Enqueue('G');
        // queue.Enqueue('K');
        // queue.Enqueue('M');
        // foreach(var item in queue)
        // {
        //     Console.WriteLine(item);
        // }
    //   queue.Dequeue();

    //boxing and unboxing
    // object o;
    // int i=10;
    // o=i;

    // string str;
    // int j=(int)o;//unboxing

    // ArrayList list=new ArrayList();
    // list.Add(10);
    // list.Add(false);
    // list.Add(2.44f);
    //unboxing
    // int k=(int)list[10];
    // var v=list[1];
    // bool t=(bool)v;
    // var x=0;
    // x="Hello"; //error
    // dynamic d=10;
    // d="hello";


    // AddClass addClass=new AddClass();
    // int sumInt=addClass.AddInt(2,3);
    // Console.WriteLine(sumInt);
    // float sumfloat=addClass.AddFloat(2.45f,3.77f);
    // Console.WriteLine(sumfloat);
    // string sumstring=addClass.AddString("Harsh","Singh");
    // Console.WriteLine(sumstring);

    // AddGenericClass<int> addInteger=new AddGenericClass<int>();
    // int sumint=addInteger.AddAllType(30,20);
    // Console.WriteLine(sumint);

    // AddGenericClass<float> addFloat=new AddGenericClass<float>();
    // float sumfloat=addFloat.AddAllType(30.56f,20.77f);
    // Console.WriteLine(sumfloat);

    // AddGenericClass<string> addString=new AddGenericClass<string>();
    // string sumstring=addString.AddAllType("Harsh ","Singh");
    // Console.WriteLine(sumstring);

        
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee { Id = 1, Name = "Gaurav" });
        employees.Add(new Employee { Id = 2, Name = "Kundan" });
        employees.Add(new Employee { Id = 3, Name = "Krishna" });
        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp);
        }


        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(101, "Gaurav");
        dict.Add(102, "Kundan");
        dict.Add(103, "Krishna");
        foreach(var kvp in dict)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }


        SortedList<string, string> sortedList = new SortedList<string, string>();
        sortedList.Add("101", "Gaurav");
        sortedList.Add("102", "Kundan");
        sortedList.Add("103", "Krishna");
        foreach(var kvp in sortedList)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }

        Stack<char> stack = new Stack<char>();
        stack.Push('A');
        stack.Push('B');
        stack.Push('C');
        foreach(var item in stack)
        {
            Console.WriteLine("Stack item: " + item);
        }
        stack.Pop();
        Console.WriteLine("After Pop:");
        foreach(var item in stack)
        {
            Console.WriteLine("Stack item: " + item);
        }

        Queue<char> queue = new Queue<char>();
        queue.Enqueue('X');
        queue.Enqueue('Y');
        queue.Enqueue('Z');
        foreach(var item in queue)
        {
            Console.WriteLine("Queue item: " + item);
        }
        queue.Dequeue();
        Console.WriteLine("After Dequeue:");
        foreach(var item in queue)
        {
            Console.WriteLine("Queue item: " + item);
        }

    }
}