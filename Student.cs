using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
        public class Student
        {
            string name;
            int matricMarks;
            int fscMarks;
            int ecatMarks;
            
        public Student() 
        {
            
        }

            public Student(string Name, int matric, int fsc, int ecat)
            {
                name = Name; ;
                matricMarks = matric;
                fscMarks = fsc;
                ecatMarks = ecat;
            }

            public Student addStudents(Student student)
            {
                Console.WriteLine("Enter name:");
                student.name = Console.ReadLine();
                Console.WriteLine("Enter matric marks:");
                student.matricMarks = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter fsc marks:");
                student.fscMarks = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter matric marks:");
                student.ecatMarks = int.Parse(Console.ReadLine());
                return student;
            }
            public void CalculateAggregate(List<Student>students,List<float> aggregate)
            {
            for (int i = 0; i < students.Count; i++)
            {
                aggregate[i] =(students[i].matricMarks / 1100 * 0.1F) + (students[i].fscMarks / 1200 * 0.5F) + (students[i].ecatMarks / 400 * 0.4F);
            }
        }
            public void ShowData(List<Student>students)
            {
                foreach (Student student in students)
                {
                    Console.WriteLine("Name:" + student.name + "Matric marks: " + student.matricMarks + "Fsc marks: " + student.fscMarks + "Ecat Marks: " + student.ecatMarks);
                }
            }
        }

    }
