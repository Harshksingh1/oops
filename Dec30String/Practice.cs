using System;
using System.Numerics;
class Practice
{
    public static void Main(string[] args)
    {
        //question1
        // string[] arr=new string[10];
        // for(int i = 0; i < 10; i++)
        // {
        //     arr[i]=Console.ReadLine();
        // }
        //  for(int i = 0; i < 10; i++)
        // {
        //     Console.Write(arr[i]+" ");
        // }

        //que2
        // int[,] arr=new int[2,2];
        //  for(int i = 0; i < arr.GetLength(0); i++)
        // {
        //     for(int j = 0; j < arr.GetLength(1); j++)
        //     {
        //         arr[i,j]=int.Parse(Console.ReadLine());
        //     }
        //     Console.WriteLine();
        // }
        //  for(int i = 0; i < arr.GetLength(0); i++)
        // {
        //     for(int j = 0; j < arr.GetLength(1); j++)
        //     {
        //         Console.Write(arr[i,j]+" ");
        //     }
        //     Console.WriteLine();
        // }

        //Add two matrix
        // Console.WriteLine("Enter size: (m*n): ");
        // int m=int.Parse(Console.ReadLine());
        // int n=int.Parse(Console.ReadLine());
        // int[,] arr1=new int[m,n];
        // int[,] arr2=new int[m,n];
        //  for(int i = 0; i < m; i++)
        // {
        //     for(int j = 0; j < n; j++)
        //     {
        //         arr1[i,j]=int.Parse(Console.ReadLine());
        //     }
        //     Console.WriteLine();
        // }
        //  for(int i = 0; i < m; i++)
        // {
        //     for(int j = 0; j < n; j++)
        //     {
        //         arr2[i,j]=int.Parse(Console.ReadLine());
        //     }
        //     Console.WriteLine();
        // }
        //  for(int i = 0; i < m; i++)
        // {
        //     for(int j = 0; j < n; j++)
        //     {
        //         Console.Write(arr1[i,j]+arr2[i,j]+" ");
        //     }
        //     Console.WriteLine();
        // }

        //========================multiply two  matrix===========================
        // Console.WriteLine("Enter size: (m*n): ");
        // int m1 = int.Parse(Console.ReadLine());
        // int n1 = int.Parse(Console.ReadLine());
        // int m2 = int.Parse(Console.ReadLine());
        // int n2 = int.Parse(Console.ReadLine());
        // if (n1 != m2)
        // {
        //     Console.WriteLine("Multiplication not possible");
        //     return;
        // }
        // int[,] arr1 = new int[m1, n1];
        // int[,] arr2 = new int[m2, n2];
        // for (int i = 0; i < m1; i++)
        // {
        //     for (int j = 0; j < n1; j++)
        //     {
        //         arr1[i, j] = int.Parse(Console.ReadLine());
        //     }
        //     Console.WriteLine();
        // }
        // for (int i = 0; i < m2; i++)
        // {
        //     for (int j = 0; j < n2; j++)
        //     {
        //         arr2[i, j] = int.Parse(Console.ReadLine());
        //     }
        //     Console.WriteLine();
        // }
        // int[,] result = new int[m1, n2];
        // for (int i = 0; i < m1; i++)
        // {
        //     for (int j = 0; j < n2; j++)
        //     {
        //         result[i, j] = 0;
        //         for (int k = 0; k < n1; k++)
        //         {
        //             result[i, j] += arr1[i, k] * arr2[k, j];
        //         }
        //     }
        // }
        // Console.WriteLine("Resultant Matrix:");
        // for (int i = 0; i < m1; i++)
        // {
        //     for (int j = 0; j < n2; j++)
        //     {
        //         Console.Write(result[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }

        //================Transpose matrix============
        // int[,] matrix =
        // {
        //     {1,2,3},
        //     {5,6,7}
        // };
        // int m=matrix.GetLength(0);
        // int n=matrix.GetLength(1);
        // int[,] transpose=new int[n,m];
        //  for(int i = 0; i < n; i++)
        // {
        //     for(int j = 0; j < m; j++)
        //     {
        //         transpose[i,j]=matrix[j,i];
        //     }

        // }
        //  for(int i = 0; i < n; i++)
        // {
        //     for(int j = 0; j < m; j++)
        //     {
        //         Console.Write(transpose[i,j]+" ");
        //     }
        //     Console.WriteLine();
        // }

        //====================check Diagonal Matrix
        //      int[,] matrix =
        //     {
        //         {1,0,0},
        //         {0,6,0},
        //         {0,0,8}
        //     };
        //     int m=matrix.GetLength(0);
        //     int n=matrix.GetLength(1);
        //      for(int i = 0; i < m; i++)
        //     {
        //         for(int j = 0; j < n; j++)
        //         {
        //             if(i!=j && matrix[i,j]!=0)
        //             {
        //                 Console.WriteLine("Not diagonal");
        //                 return;
        //             }
        //         }

        //     }
        //   Console.WriteLine("Diagonal");


        //===============reverse string===============================
        // string str = "Harsh i am harsh";
        // char[] arr = str.ToCharArray();
        // Array.Reverse(arr);
        // Console.WriteLine(arr);

        //=======================to lower and upper
        // string str="harsh";
        // Console.WriteLine(str.ToUpper());
        // string s="AMAN";
        // Console.WriteLine(s.ToLower());
        //==============without function==========================
        // string str="harsh";
        // char[] res=str.ToCharArray();
        // for(int i = 0; i < res.Length; i++)
        // {
        //     res[i]=(char)(str[i]-32);
        // }
        // Console.WriteLine(res);


        //=================to compare===============
        // string s1="harsh";
        // string s2="hjrsh";
        // for(int i = 0; i < s1.Length; i++)
        // {
        //     if (s1[i] != s2[i])
        //     {
        //         Console.WriteLine("Not equal");
        //         return;
        //     }
        // }
        // Console.WriteLine("Equal");

        //==========================concatinate======================
        // string str="I am Harsh";
        // string str1="Singh";
        // Console.WriteLine(String.Concat(str,str1));
        // Console.WriteLine(str+" yashu");

        //===============================search a string  in main string============================
        // string str="i am Harsh singh";
        // Console.WriteLine(str.Contains("ngh"));
    }
}