using System;
namespace ConsoleApplication;

public class Rhombus
    {
        protected int d1 { get; set; }
        protected int d2 { get; set; }
        public int a {get; set; }
 
        public bool IsRhombus
        {
            get
            { if (d1 != d2)
                    return true;
                else return false;
            }
        }
        public Rhombus (int D1,int D2, int A){ d1 = D1; d2 = D2;  a=A;}
 
        public void PrintRhombus()
        {
            Console.WriteLine($"d1={d1}  d2={d2}");
        }
        public int GetS()
        {
            return d1*d2;
        }
        public int GetP()
        {
            return (4*a);
        }
    }
    public class Persona
    {
    public string name;
    public string surname;
    public int age;
     public Persona()
      {
        name="No name";
        surname="No surname";
        age=0;
      }
     public Persona(string n, string l, int a){
        name =n;
        surname=l;
        age=a;
      }
      

        public void PrintPersona()
        {
       
 Console.WriteLine ("Name="+name);
 Console.WriteLine ("Surname"+surname);
 Console.WriteLine ("Age="+age);

        }
        
    }
public class Student : Persona
    {
        public int group;
        public string speciality;
        public string facultet;
    public Student()
       {
        name="Petro";
        surname="Mostavchuk";
        age=19;
        group=341;
        speciality="Computer Science";
        facultet="Physico-Tech";
       }
     public  Student(int g, string s, string f)
       {
        group=g;
        speciality=s;
        facultet=f;
       }
       public void PrintStudent()
        {
       
 Console.WriteLine ("Name="+name);
 Console.WriteLine ("Surname"+surname);
 Console.WriteLine ("Age="+age);
 Console.WriteLine ("Group="+group);
 Console.WriteLine ("Speciality="+speciality);
 Console.WriteLine ("Facultet="+facultet);

        }
    }
   public class Teacher : Student
    {
    public string subject;
public Teacher()
{
        name="Dmytro";
        surname="Gordon";
        age=53;
        facultet="Physico-Tech";
        subject="Physics";
}
public Teacher(string p)
{
    subject=p;
}
public void PrintTeacher()
{
Console.WriteLine ("Name="+name);
Console.WriteLine ("Surname"+surname);
Console.WriteLine ("Age="+age);
Console.WriteLine ("Facultet="+facultet);
Console.WriteLine ("Predmet="+subject);
}
    }
    public class HeadDep : Teacher
    {
     public string department;
     public HeadDep()
     {
        name="Kirylo";
        surname="Kadzumenko";
        age=57;
        facultet="Physico-Tech";
        department="Education department";
     }
     public HeadDep(string d)
     {
        department=d;
     }
     public void PrintHeadDep()
     {
        Console.WriteLine ("Name="+name);
        Console.WriteLine ("Surname"+surname);
        Console.WriteLine ("Age="+age);
        Console.WriteLine ("Facultet="+facultet);
        Console.WriteLine ("Department="+department);
     }
    }
   public class Program
    {
        static void Main(string[] args)
        {
            Rhombus rhombus = new Rhombus(6, 6, 6);
            rhombus.PrintRhombus();
            if (!rhombus.IsRhombus)
                Console.WriteLine("Квадрат!");
            Rhombus rhombus1 = new Rhombus(6, 7, 8);
            rhombus1.PrintRhombus();
            Console.WriteLine($"P={rhombus1.GetP()}  S={rhombus1.GetS()}");
            Console.ReadKey();
            Student student = new Student();
            student.PrintStudent();
            Teacher teacher = new Teacher();
            teacher.PrintStudent();
            HeadDep headep = new HeadDep();
            headep.PrintStudent();
           

        }
    }