using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    // ----------- Task 1 --------------------
    /*public class Student
    {
        public string Name;
        public float EcatMarks;
        public float FscMarks;
        public float MatricMarks;
        public float Aggregate;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Ali";
            student.EcatMarks = 300;
            student.MatricMarks = 800;
            student.FscMarks = 980;

            Student student2 = student;
            student2.Name = "Sarmad";

            Console.WriteLine(student2.Name);
            Console.WriteLine(student.Name);

            Console.ReadKey();

        }
    }*/

    //-------------- Copy Constructor format --------------
    /*public class Student
    {
        public string Name;
        public float EcatMarks;
        public float FscMarks;
        public float MatricMarks;
        public float Aggregate;

        public Student()
        {

        }

        public Student(Student student)
        {
            Name = student.Name;
            EcatMarks = student.EcatMarks;
            FscMarks = student.FscMarks;
            MatricMarks = student.MatricMarks;
            Aggregate = student.Aggregate;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Ali";
            student.EcatMarks = 300;
            student.MatricMarks = 800;
            student.FscMarks = 980;
            student.Aggregate = 78;

            Console.ReadKey();

        }
    }*/

    // ------------------- Task 2 ---------------

    /*class POS
    {
        public int p_ID;
        public string p_Name;
        public float p_amount;
        public string p_date;
        public string p_time;

        public POS(int id, string name, float amount, string date, string time)
        {
            p_ID = id;
            p_Name = name;
            p_amount = amount;
            p_date = date;
            p_time = time;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {

            POS n1 = new POS(1, "Biscuits", 1520, "12-05-2026", "7:15 pm");
            POS n2 = new POS(2, "Mango",450 , "14-05-2026" , "8:00 pm");
            n2.p_ID = n1.p_ID;
            n2.p_Name = n1.p_Name;
            n2.p_amount = n1.p_amount;
            n2.p_date = n1.p_date;
            n2.p_time = n1.p_time;
            Console.WriteLine("ID: " + n1.p_ID + " Product Name: " + n1.p_Name + " Price: " + n1.p_amount + " Date: "  + n1.p_date  +  " Time: " + n1.p_time);
            Console.WriteLine("ID: " + n2.p_ID + " Product Name: " + n2.p_Name + " Price: " + n2.p_amount + " Date: " + n2.p_date + " Time: " + n2.p_time);
            n1.p_ID = 222;
            n1.p_Name = "Coffee";
            n1.p_amount = 1250;
            n1.p_date = "15-09-2026";
            n1.p_time = "9:15 pm";

            n2.p_ID = 125;
            n2.p_Name = "Latte";
            n2.p_amount = 950;
            n2.p_date = "18-06-2026";
            n2.p_time = "3:15 pm";
            Console.WriteLine("ID: " + n1.p_ID + " Product Name: " + n1.p_Name + " Price: " + n1.p_amount + " Date: " + n1.p_date + " Time: " + n1.p_time);
            Console.WriteLine("ID: " + n2.p_ID + " Product Name: " + n2.p_Name + " Price: " + n2.p_amount + " Date: " + n2.p_date + " Time: " + n2.p_time);
            Console.Read();
        }
    }*/


    // ------------ Task 3 --------------------------

    /*class Calculator
    {
        public int n1;
        public int n2;
        public int add;
        public int subtract;
        public int multiply;
        public int divide;

        public string op;
        public void sum(int n1, int n2, string op)
        {
            if (op == "+")
            {
                Console.WriteLine("Output is: " + (n1 + n2));
            }

        }

        public void minus(int n1, int n2, string op)
        {
            if (op == "-")
            {
                Console.WriteLine("Output is: " + (n1 - n2));
            }

        }

        public void mul(int n1, int n2, string op)
        {
            if (op == "*")
            {
                Console.WriteLine("Output is: " + (n1 * n2));
            }

        }

        public void div(int n1, int n2, string op)
        {
            if (op == "/")
            {
                Console.WriteLine("Output is: " + (n1 / n2));
            }

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Calculator n1 = new Calculator();
                Console.WriteLine("Enter 1st number: ");
                n1.n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number: ");
                n1.n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter  numbers & operator(+ , - , * , / ) : ");
                string op = Console.ReadLine();

                n1.sum(n1.n1, n1.n2, op);
                n1.minus(n1.n1, n1.n2, op);
                n1.mul(n1.n1, n1.n2, op);
                n1.div(n1.n1, n1.n2, op);

            }
        }
    }
}*/

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student s = new Student();
            while (true)
            {
                int option = menu();
                if (option == 1)
                {
                    Student sdata = new Student();
                    sdata = s.addStudents(s);
                    students.Add(sdata);
                }
                else if (option == 2)
                {
                    Console.Clear();
                    s.ShowData(students);
                }
                else if (option == 3)
                {

                    s.CalculateAggregate(students);
                }
            }
            


        }
        static int menu()
        {
            Console.WriteLine("--------- MENU ---------");
            Console.WriteLine("1: Add Students ");
            Console.WriteLine("2: Display Students ");
            Console.WriteLine("3: Aggregate Calculator ");

            return 1;
        }

    }

}

