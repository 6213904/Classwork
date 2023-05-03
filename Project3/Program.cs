using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* const int size = 6;


             int[] var1=new int[] {1,2,3,4,5};
             int[] var2 = {1,2,3,4,5};
             int[] var3 = new int[size];

             for(int i = 0; i < size; i++) 
                 var3[i] = int.Parse(Console.ReadLine());

             for(int i = 0; i < var3.Length;i++)
                 Console.WriteLine(var3[i]);

             foreach(int i in var3)
                 Console.WriteLine(i);

             int[,] array1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

             for(int row=0; row < array1.GetLength(0); row++)
             {
                 for(int col=0; col < array1.GetLength(1); col++)
                 {
                     Console.Write(array1[row, col] + " ");
                 }
             }
             int[,] array2 = new int[4, 2] { { 1, 2,},{ 3,4}, { 5, 6 } ,{ 7,8} };
             int counter = 0;
             foreach (int i in array2)
             {
                 Console.Write(i + " ");
                 counter++;
                 if(counter % 2==0 ) 
                     Console.WriteLine();

             }    */

            /*1 2 3 4
             *5 6 
             *7 8 9
             
            int[][] array3 = new int[3][] { new int[4] { 1, 2, 3, 4 },new int[2] { 5,6},new int[3] { 7,8,9} };

            for(int row=0; row<array3.Length; row++)
            {
                for(int col=0; col < array3[row].Length; col++)
                {
                    Console.Write(array3[row][col]+ " ");
                }
                Console.WriteLine();
            }

            foreach (int[] outer in array3)
            {
                foreach (int  i in outer)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }*/

            /*2.5 8.6 9.6 7.5
             *2.1 5.8 8.6
             *2.2 7.8 9.6 9.85
             *2.2 3.5 4.7
             

            double[][] array4 = new double[4][] { new double[4] { 2.5, 8.6, 9.6, 7.5 }, new double[3] { 2.1, 5.8,8.6 }, new double[5] { 2.2, 7.8, 9.6,9.5,9.85 } , new double[3] { 2.2,3.5,4.7} };

            for (int row = 0; row < array4.Length; row++)
            {
                for (int col = 0; col < array4[row].Length; col++)
                {
                    Console.Write(array4[row][col] + " ");
                }
                Console.WriteLine();
            }*/

            List<int> listVar1 = new List<int>();
            listVar1.Add(2);
            listVar1.Add(3);
            listVar1.Add(4);
            
            listVar1.Insert(1,9);
            for (int i = 0; i < listVar1.Count; i++)
            {
                Console.Write(listVar1[i]);
            }

            listVar1.Remove(3);

            foreach (int i in listVar1)
                Console.Write(i + " ");

            listVar1.RemoveAt(1);
            foreach (int i in listVar1)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
