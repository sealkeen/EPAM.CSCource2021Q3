using System;
using System.Collections.Generic;

namespace Students
{
    //TODO: Create a console application called "Students".
    //TODO: Create a class "Student" which includes string FullName and string Email
    //(name is like Name Surname, email is like name.surname @epam.com).
    class Student {
        private string FullName { get; set; }
        private string Email { get; set; }
        //TODO: Create a constuctor for this class, which takes only Email(you can get the FullName from the Email).
        public Student(string email) {
            if (IsValidEmail(email))
            {
                var fullName = email.Split('@')[0].Split('.');
                if (fullName.Length == 2)
                {
                    FullName = fullName[0] + " " + fullName[1];
                }
            }
        }
        bool IsValidEmail(string email)
        {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch {
                return false;
            }
        }
        //TODO: Create a constructor for this class, which takes name and surname(you can get FullName and Email from name and surname).
        public Student(string name, string surname)
        {
            FullName = name + " " + surname;
            Email = name + "." + surname + "@epam.com"; 
        }
    }

    class Program
    {
        private Random _rnd;
        static void Main(string[] args)
        {
            Program program = new Program();
            //TODO: In the main method create a string array "subjects" which contains 6 different school subjects("Maths, "PE", etc..).
            var subjects = new string[] { "Math", "Physics", "Literature", "Chemistry", "Biology", "" };

            //TODO: In the main method create 3 students with different names using first constructor
            //TODO: (like var student1c1 = new Student("vasya.pupkin@epam.com")
            var student1c1 = new Student("ilya.varlamov@epam.com");
            var student2c1 = new Student("arseniy.pirozhkov@epam.com");
            var student3c1 = new Student("irina.gavrilenkova@epam.com");

            //TODO: In the main method create 3 students with the same names using second constructor
            //TODO: (like var student1c2 = new Student("Vasya", "Pupkin").
            var student1c2 = new Student("Ilya", "Varlamov");
            var student2c2 = new Student("Arseniy", "Pirozhkov");
            var student3c2 = new Student("Irina", "Gavrilenkova");

            //TODO: Overall you should have 3 unique students (but there are 2 instances of each student)
            //TODO: Create a new empty dictionary of<Student, HashSet> called "studentSubjectDict".
            var studentSubjectDict = new Dictionary<Student, HashSet<string>>();

            //TODO: For each student(remember that we got 6 variables despite there are only 3 unique students) fill in the dictionary like

            studentSubjectDict[student1c1] = program.Generate3RandomSubjects(subjects);
            studentSubjectDict[student2c1] = program.Generate3RandomSubjects(subjects);
            studentSubjectDict[student3c1] = program.Generate3RandomSubjects(subjects);
            studentSubjectDict[student1c2] = program.Generate3RandomSubjects(subjects);
            studentSubjectDict[student2c2] = program.Generate3RandomSubjects(subjects);
            studentSubjectDict[student3c2] = program.Generate3RandomSubjects(subjects);

            //TODO: Make sure that after that there are only three records in the "studentSubjectDict" dictionary
            //TODO: (for that purpose you should override Equals() and GetHashCode() for students class).

            //TODO: Task2:
            //TODO: Goal of the task is to get acquainted with Array.Sort, Stopwatch and System.Diagnostics.Process.

            //TODO: Create a console application called "Performance".
            //TODO: Create a class "C" with just one int field called "i".
            //TODO: Create a struct "S" with just one int field called "i".
            //TODO: In the main method create an array of 100000 "C" called "classes" and intialize it with random numbers.
            //TODO: In the main method create an array of 100000 "S" called "structs" and intialize it with random numbers.
            //TODO: Calculate PrivateMemorySize64 delta before and after arrays initialization (for each array separately). Print the results to console.
            //TODO: Compare the difference between these deltas and print it to the console.
            //TODO: Execute Array.Sort<С>(classes) и Array.Sort<S>(structs). Print the execution time of each sort to the console.

            Console.WriteLine("Hello World!");
        }

        private HashSet<string> Generate3RandomSubjects(string[] subjects) {
            HashSet<string> hashSet = new HashSet<string>();
            const int countOfStudents = 3;
            for (int i = 0; i < countOfStudents; i++) {
                hashSet.Add(subjects[_rnd.Next(0, 5)]);
            }
            return hashSet;
        }



    }
}
