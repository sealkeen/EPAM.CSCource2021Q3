using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Students
{
    class Program
    {
        private Random _rnd = new Random();
        static void Main(string[] args)
        {
            var program = new Program();
            var subjects = new string[] { "Math", "Physics", "Literature", "Chemistry", "Biology", "Geography" };

            var student1c1 = new Student("ilya.varlamov@epam.com");
            var student2c1 = new Student("arseniy.pirozhkov@epam.com");
            var student3c1 = new Student("irina.gavrilenkova@epam.com");

            var student1c2 = new Student("ilya", "varlamov");
            var student2c2 = new Student("arseniy", "pirozhkov");
            var student3c2 = new Student("irina", "gavrilenkova");

            var studentSubjectDict = new Dictionary<Student, HashSet<string>>();

            studentSubjectDict[student1c1] = program.Generate3RandomSubjects(subjects);
            studentSubjectDict[student2c1] = program.Generate3RandomSubjects(subjects);
            studentSubjectDict[student3c1] = program.Generate3RandomSubjects(subjects);
            studentSubjectDict[student1c2] = program.Generate3RandomSubjects(subjects);
            studentSubjectDict[student2c2] = program.Generate3RandomSubjects(subjects);
            studentSubjectDict[student3c2] = program.Generate3RandomSubjects(subjects);

            Console.WriteLine($"Keys: {studentSubjectDict.Keys.Count}, Values: {studentSubjectDict.Values.Count}"); //Output : 3

            Console.ReadKey();
        }

        private HashSet<string> Generate3RandomSubjects(string[] subjects) 
        {
            var hashSet = new HashSet<string>();
            const int countOfStudents = 3;
            for (int i = 0; i < countOfStudents; i++) 
            {
                hashSet.Add(subjects[_rnd.Next(0, 5)]);
            }
            return hashSet;
        }
    }
}
