// class FileInfoDemo
// {
//     public static void Main()
//     {
        // string path=@"MyTestFile1.txt";
        // FileInfo f1=new FileInfo(path);
        // File.Create(path);
        // {
        //     Console.WriteLine("File has been created");
        // }
        // FileInfo fi=new FileInfo(@"MyTestFilecreatetext2.txt");
        // StreamWriter str=fi.CreateText();
        // str.WriteLine("hello");
        // Console.WriteLine("file has been created with text");
        // str.Close();

        //this method is for delete file
        // FileInfo fi=new FileInfo(@"MyTestFilecreatetext2.txt");
        // fi.Delete();
        // Console.WriteLine("file has been deleted");

        //the copyTo method is used to copy an existing file into a new file
        // string path=@"MyTestFile1.txt";
        // string path2=@"NewFile.txt";
        // FileInfo fi1=new FileInfo(path);
        // FileInfo fi2=new FileInfo(path2);
        // fi1.CopyTo(path2);
        // Console.WriteLine("{0} was copied to {1}. ",path,path2);

        //the moveto method to move one place to another
        // string path=@"MyTestFile7.txt";
        // string path2=@"NewFile.txt";
        // FileInfo fi1=new FileInfo(path);
        // FileInfo fi2=new FileInfo(path2);
        // fi1.MoveTo(path2);
        // Console.WriteLine("{0} was copied to {1}. ",path,path2);



        //Append the data

        // FileInfo fi=new FileInfo(@"MyTestFile1.txt");
        // StreamWriter sw=fi.AppendText();

        // sw.WriteLine("This");
        // sw.WriteLine("is");

        // sw.WriteLine("Extra");

        // Console.WriteLine("File has been appended");
        // sw.Close();

        // FileInfo fi = new FileInfo(@"MyTestFile1.txt");

        // StreamReader sr = fi.OpenText();

        // string s = " ";
        // while ((s = sr.ReadLine()) != null)
        // {
        //     Console.WriteLine(s);
        // }

        // FileInfo fi=new FileInfo(@"MyTestFile1.txt");
        // Console.WriteLine("File name is {0} ",fi.Name);
        // Console.WriteLine("File creation Time is {0} ",fi.CreationTime.ToLongTimeString());
        // Console.WriteLine("File Last Access Time is {0} ",fi.LastAccessTime.ToLongDateString());
        // Console.WriteLine("File Length is {0} ",fi.Length.ToString()+" Bytes");
        // Console.WriteLine("File extension is {0} ",fi.Extension);
        // Console.WriteLine("File exist is: {0} ",fi.Exists);

//     }
// }