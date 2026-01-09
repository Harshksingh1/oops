// class BinaryWriteExample
// {
//     static void Main()
//     {
//         string filepath="Employee.dat";
//         using(FileStream fs=new FileStream(filepath,FileMode.Create))
//         using(BinaryWriter bi=new BinaryWriter(fs))
//         {
//             bi.Write(101);
//             bi.Write("Abhi");
//             bi.Write(2839.300);
//             bi.Write(true);
//         }
//         Console.WriteLine("File created sucessfully");
//     }
// }