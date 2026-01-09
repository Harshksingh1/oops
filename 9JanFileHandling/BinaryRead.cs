// class BinaryReadExample
// {
//     static void Main()
//     {
//         string filepath="Employee.dat";
//         using(FileStream fs=new FileStream(filepath,FileMode.Open))
//         using(BinaryReader bi=new BinaryReader(fs))
//         {
//             int id=bi.ReadInt32();
//             string name=bi.ReadString();
//             double salary=bi.ReadDouble();
//             bool isActive=bi.ReadBoolean();

//             Console.WriteLine("ID: "+id);
//             Console.WriteLine("Name: "+name);
//             Console.WriteLine("Salary: "+salary);
//             Console.WriteLine("Active: "+isActive);
//         }
//     }
// }