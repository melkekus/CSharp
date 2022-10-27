using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Perymetr
{
class Program
{
static void Main()
{
    // 1
int r1=0;
int r2=0;
Console.Write("s= ");
double S = Math.PI * (r2*r2 - r1*r1);
float s = float.Parse(Console.ReadLine());
double p =  Math.Sqrt(s);
Console.WriteLine("p=" + p);
//3
Console.Write("x=");
 float x = float.Parse(Console.ReadLine());
 Console.Write("y=");
 float y = float.Parse(Console.ReadLine());
 if (x * x + y * y < 9 && y > 0)
 Console.Write("inside");
 else if (x * x + y * y > 9 || y < 0)
 Console.WriteLine("out");
 else Console.Write("on the edge");

//4
 Console.WriteLine("Стать=");
            string g = Console.ReadLine();
            if (g == "Ж")
            {
                Console.WriteLine("Юля, Аня, Валя");
            }
            else Console.WriteLine("Вася, Саша, Юра");
            Console.ReadLine();

 //5
Console.WriteLine("Введiть 1 число:");
 string n = Console.ReadLine();
int v = Convert.ToInt32(n);
Console.WriteLine("Введiть 2 число:");
string r = Console.ReadLine();
int c = Convert.ToInt32(r);
int chastka = v / c;
 double d = Math.Pow(chastka, 2);
 Console.WriteLine("Виведення у квадрат двох чисел 1 и 2 ={0}",d);
 //6

int a=0;
int b=0;
double pr = a + ((a + b - 1) / (Math.Pow(a, 2)+1)) - a * b;
Console.WriteLine("Result=" + a + b);

           
}

}
}