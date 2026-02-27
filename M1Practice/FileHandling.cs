// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         File.WriteAllText("example.txt", "Hello, this is file handling in C#");
//         Console.WriteLine("File written successfully!");
//     }
// }


// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         string content = File.ReadAllText("example.txt");
//         Console.WriteLine(content);
//     }
// }



//serialization json
// using System;
// using System.Text.Json;

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
        // Student s = new Student { Id = 3, Name = "Ravi" };

        // string json = JsonSerializer.Serialize(s);
        // File.WriteAllText("student.json", json);

        // Console.WriteLine(json);

       //============deserialization================================
        // string json = File.ReadAllText("student.json");
        // Student s = JsonSerializer.Deserialize<Student>(json);
        //  Console.WriteLine(s.Name);

//     }
// }
