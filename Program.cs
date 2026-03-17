using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Requirements__Hong_
{
    internal class Program
    {
        // ===== Abstract Class (Abstraction) =====
        abstract class Person
        {
            protected string name;

            public Person(string name)
            {
                this.name = name;
            }

            public string GetName()
            {
                return name;
            }

            public abstract void Display();
        }

        // ===== Inheritance =====
        class Student : Person
        {
            private string studentId;
            private double score;

            public Student(string name, string studentId, double score) : base(name)
            {
                this.studentId = studentId;
                this.score = score;
            }

            public string GetStudentId()
            {
                return studentId;
            }

            public double GetScore()
            {
                return score;
            }

            public override void Display()
            {
                Console.WriteLine($"ID: {studentId}, Name: {name}, Score: {score}, Grade: {GetGrade()}");
            }

            public virtual string GetGrade()
            {
                if (score >= 80) return "A";
                else if (score >= 75) return "B+";
                else if (score >= 70) return "B";
                else if (score >= 65) return "C+";
                else if (score >= 60) return "C";
                else if (score >= 55) return "D+";
                else if (score >= 50) return "D";
                else return "F";
            }
        }

        // ===== Polymorphism =====
        class SpecialStudent : Student
        {
            public SpecialStudent(string name, string studentId, double score)
                : base(name, studentId, score) { }

            public override string GetGrade()
            {

                double newScore = GetScore() + 5;

                if (newScore >= 80) return "A";
                else if (newScore >= 75) return "B+";
                else if (newScore >= 70) return "B";
                else if (newScore >= 65) return "C+";
                else if (newScore >= 60) return "C";
                else if (newScore >= 55) return "D+";
                else if (newScore >= 50) return "D";
                else return "F";
            }
        }

        // ===== Encapsulation =====
        class Course
        {
            private string courseName;
            private string courseId;
            private List<Student> students = new List<Student>();

            public Course(string courseName, string courseId)
            {
                this.courseName = courseName;
                this.courseId = courseId;
            }

            public void AddStudent(Student student)
            {
                students.Add(student);
            }

            public void ShowAllStudents()
            {
                foreach (var s in students)
                {
                    s.Display();
                }
            }

            public void ShowMaxMinScore()
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No students.");
                    return;
                }

                double max = students.Max(s => s.GetScore());
                double min = students.Min(s => s.GetScore());

                Console.WriteLine($"Max Score: {max}");
                Console.WriteLine($"Min Score: {min}");
            }

            public void ShowAverage()
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No students.");
                    return;
                }

                double avg = students.Average(s => s.GetScore());
                Console.WriteLine($"Average Score: {avg:F2}");
            }

            // ===== Main Program =====
            static void Main(string[] args)
            {
                List<Course> courses = new List<Course>();

                while (true)
                {
                    Console.WriteLine("\n===== MENU =====");
                    Console.WriteLine("1. Create Course");
                    Console.WriteLine("2. Add Student");
                    Console.WriteLine("3. Show Data");
                    Console.WriteLine("0. Exit");
                    Console.Write("Select: ");
                    string choice = Console.ReadLine();

                    if (choice == "0") break;

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Course Name: ");
                            string cname = Console.ReadLine();
                            Console.Write("Course ID: ");
                            string cid = Console.ReadLine();

                            courses.Add(new Course(cname, cid));
                            break;

                        case "2":
                            if (courses.Count == 0)
                            {
                                Console.WriteLine("No course.");
                                break;
                            }

                            Console.Write("Select Course Index: ");
                            int index = int.Parse(Console.ReadLine());

                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Student ID: ");
                            string sid = Console.ReadLine();
                            Console.Write("Score: ");
                            double score = double.Parse(Console.ReadLine());

                            courses[index].AddStudent(new Student(name, sid, score));
                            break;

                        case "3":
                            for (int i = 0; i < courses.Count; i++)
                            {
                                Console.WriteLine($"\nCourse {i}");
                                courses[i].ShowAllStudents();
                                courses[i].ShowMaxMinScore();
                                courses[i].ShowAverage();
                            }
                            break;
                    }
                }
            }
        }
    }
}
    
