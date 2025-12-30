using System;
class Program
{
    // public static void Main(string[] args)
    // {
        //=========================from string litral and string concatenation============
        // string fname,lname;
        // fname="Harsh";
        // lname="Vansh";
        // char[] letters={'H','e','l','l','o'};
        // string[] sarray={"Hello","From","Tutorials","point"};
        // string fullname=fname+lname;
        // Console.WriteLine(fullname);

        //=================by using string constructor========================
        // string greetings=new string(letters);
        // Console.WriteLine(greetings);

        //===================method returning string=========================
        // string message=String.Join(" ",sarray);
        // Console.WriteLine("Message: "+message);

        // ================formatting method to convert a value====================
        // DateTime waiting=new DateTime(2012,10,10,17,58,1);
        // string chat=String.Format("Message sent at {0:t} on {0:D}",waiting);
        // Console.WriteLine("Message :{0}",chat);

        //===========compare============
        // string str1="This is test";
        // string str2="This is test";
        // if(String.Compare(str1,str2)==0)
        // Console.WriteLine(str1+" "+str2);
        // else
        // Console.WriteLine("Not equal");

        //================contains==============
        // string str1="This is test";
        // if(str1.Contains("test"))
        // Console.WriteLine("found");
        // else
        // Console.WriteLine("Not found");

        //==========substring=============
        // string str1="This is test";
        // string substr=str1.Substring(6);
        // Console.WriteLine(substr);

        //=============Escape characters==============
        // Console.WriteLine("Hello\nWorld");
        // Console.WriteLine("\"Hello World\"");
        // Console.WriteLine(@"D:\project\csharp\program.cs"); //verbatim
        // Console.WriteLine("D:\\project\\csharp\\program.cs");

        // var message1=@"Hello Alice,
        
        //     Good morning?
        
        //     your file have been saved successfully at \shared\alice
        
        //     Thanks!";
        // Console.WriteLine(message1);

        // var name="Alice";
        // var greet="good morning";
        // var greeting=$"Hello {name},{greet}!";
        // Console.WriteLine(greeting);
        
        // var num=12;
        // Console.WriteLine(num*num);

        // var text="Hello World";
        // var sub_text=text.Substring(6,5);
        // Console.WriteLine(sub_text);
        // var text3="Hello World";
        // Console.WriteLine(text3.ToUpper());

        // var text4="HELLO WORLD";
        // Console.WriteLine(text4.ToLower());

        // var text5="   Hello world     ";
        // Console.WriteLine(text5.Trim());

        // var csv="Alice,Bob,Chris,Dave,Eric,Fred";
        // var names=csv.Split(',');
        // for(var i = 0; i < names.Length; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }
        // var greet3="Hello Alice. Welcome";
        // var index4=greet3.LastIndexOf("el");
        // Console.WriteLine(index4);


        //====================Jagged Array==========================
        // int[][] jagged_arr=new int[4][];
        // jagged_arr[0]=new int[]{1,2,3,4};
        // jagged_arr[1]=new int[]{11,45,67};
        // jagged_arr[2]=new int[]{3,4};
        // jagged_arr[3]=new int[]{0,1,2,3,4};
        // for(int i = 0; i < jagged_arr.Length; i++)
        // {
        //     for(int j = 0; j < jagged_arr[i].Length; j++)
        //     {
        //         Console.Write(jagged_arr[i][j]+" ");
        //     }
        //     Console.WriteLine();
        // }
    // }
}