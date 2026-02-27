
//substing
// class Program
// {
//     public static void Main()
//     {
//         string str="Harsh";
//         for(int i = 0; i < str.Length; i++)
//         {
//             for(int j = 1; j <= str.Length-i; j++)
//             {
//                 Console.WriteLine(str.Substring(i,j));
//             }

//         }
//     }
// }


//subsequence
// using System;

// class Program
// {
//     public static void genrateSub(string curr, string s, int ind)
//     {
//         if (ind == s.Length)
//         {
//             Console.WriteLine(curr);
//             return;
//         }

//         // Include current character
//         genrateSub(curr + s[ind], s, ind + 1);

//         // Exclude current character
//         genrateSub(curr, s, ind + 1);
//     }

//     public static void Main(string[] args)
//     {
//         string name = "Abhi";
//         genrateSub("", name, 0);
//     }
// }

class Program
{
     public static void Subseq(string curr,string s,int index)
    {
        if (index==s.Length)
        {
            Console.WriteLine(curr);
            return;
        }
        Subseq(curr+s[index],s,index+1);
        Subseq(curr,s,index+1);
    }
    static void Main()
    {
        string s="HArsh";
        Subseq("",s,0);
    }
}

//M1 mock
// using System;
// using System.Text;
// class Program{
//     static void Main()
//     {
//     StringBuilder str=new StringBuilder("world");
//        StringBuilder rev=new StringBuilder();
//        for(int i=str.Length-1;i>=0;i--){
//            rev.Append(str[i]);
//        }

//    for(int i = 0; i < rev.Length; i++)
//         {
//             if(rev[i]=='a')
//             rev[i]='e';
//            else if(rev[i]=='e')
//             rev[i]='i';
//            else if(rev[i]=='i')
//             rev[i]='o';
//            else if(rev[i]=='o')
//             rev[i]='u';
//            else if(rev[i]=='u')
//             rev[i]='a';
//         }
//          StringBuilder rev1=new StringBuilder();
//          rev1.Append(rev[0]);
//        for(int i = 1; i < rev.Length; i++)
//         {
//             if(rev[i]!=rev[i-1])
//             rev1.Append(rev[i]);
//         }

//          int k=3;
//         k=k%rev1.Length;
//         StringBuilder result=new StringBuilder();
//         for(int i = rev1.Length - k; i < rev1.Length; i++)
//         {
//             result.Append(rev1[i]);
//         }
//         for(int i = 0; i < rev1.Length-k; i++)
//         {
//             result.Append(rev1[i]);
//         }
//            Console.WriteLine(result);
//     }
// }


// class Program
// {
//     static void Main()
//     {


        //====Anagram=====
    //     string str="harsh";
    //     string str1="arshh";

    //     char[] arr=str.ToCharArray();
    //     arr.Sort();

    //     char[] arr1=str.ToCharArray();
    //     arr1.Sort();
         
    //      bool check=true;
    //     for(int i = 0; i < arr.Length; i++)
    //     {
    //         if(arr[i]!=arr1[i]){
    //         check=false;
    //         break;
    //         }

    //     }
    //    Console.WriteLine(check);



     //==================1️⃣1️⃣ Remove duplicate characters======================
     //==================1️⃣2️⃣ Find first non-repeating character===============
     //==================1️⃣5️⃣ Reverse words in a sentence======================
     //==================3️⃣5️⃣ Check if a substring exists in a string==================
     //==================5️⃣5️⃣ Find longest substring without repeating characters======
     //==================6️⃣5️⃣Longest palindromic substring====================
     //==================1️⃣3️⃣ Longest Common Subsequence (LCS)===================

//=====================1️⃣3️⃣ compress string=============================================
//     string str="aaabccdddaaa"; //a3b1c2d3a2
//     string result="";
//     int count=1;
//     for(int i = 0; i < str.Length-1; i++)
//         {
//             if(str[i]==str[i+1])
//             {
//                 count++;
//             }
//             if (str[i] != str[i + 1])
//             {
            
//             result+=str[i];
//             result+=count;
//             count=1;
//             }
           
//         }
//         result+=str[str.Length-1];
//         result+=count;
//        Console.WriteLine(result);



//     }
// }