using System;
namespace ConsoleApplication
{
class Class
{
    
    
    
public static void Main(string[] args)
        {
            //1
             Console.WriteLine("Введiть розмiрнiсть масиву");
                int nz = int.Parse(Console.ReadLine());
                int[] a = new int[nz];
                for (int i = 0; i < nz; ++i)
                {
                    Console.Write("a[{0}]= ", i);
                    a[i] = int.Parse(Console.ReadLine());
 
                }
                Console.WriteLine("Введiть iнтервал");
                Console.Write("A=");
                int A = int.Parse(Console.ReadLine());
                Console.Write("B=");
                int B = int.Parse(Console.ReadLine());
                Console.WriteLine("Тi що не попали");
                for (int i = 0; i < a.Length; ++i)
                    if (!(a[i] >= A & a[i] <= B))
 
                        Console.WriteLine(i);
            
            //3
            Console.Write("Який розмiр масиву : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] myArray_2 = new int[n,n];
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < n; j++)
                {
                    myArray_2[i, j] = rnd.Next(10);
                    Console.Write("{0} ", myArray_2[i, j]);
                }
            }
            int Average = 0,del = 1;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                    if(myArray_2[i, j] % 2 == 0)
                    {
                        Average += myArray_2[i, j];
                        del++;
                    }
            }
            Console.WriteLine("\nВiдповiдь: {0}", Average / del);
            Console.ReadKey();

            //4
            Console.Write("Скiльки ступiнiв в масивi : ");
            int nb = Convert.ToInt32(Console.ReadLine());
            int[][] myArray_1 = new int[n][];
            int[] minArray = new int[n];
            Random rn = new Random();
 
            for(int i = 0; i< myArray_1.Length;i++)
            {
                Console.WriteLine();
                myArray_1[i] = new int[i + 1];
                for(int j = 0; j <= i; j++)
                {
                    myArray_1[i][j] = rnd.Next(10);
                    Console.Write(myArray_1[i][j]+" ");
                }
            }
 
            int min = 0;
            for(int i = 0; i < myArray_1.Length; i++)
            {
                min = myArray_1[i][0];
                for(int j = 0; j <= i; j++)
                {
                    if(min >= myArray_1[i][j])
                        min = myArray_1[i][j];
                }
                minArray[i] = min;
            }
            Console.WriteLine("\n~~ Мiнiмальнi елементи ~~");
            foreach(int value in minArray)
                Console.Write("{0} ", value);
            Console.ReadKey();
        }

        

}
}