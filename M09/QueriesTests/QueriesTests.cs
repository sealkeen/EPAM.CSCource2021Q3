using NUnit.Framework;
using System;
using EPAM.CSCourse2016.SilkinIvan.JSONParser;
using System.Diagnostics;
using System.IO;

namespace QueriesTests
{
    public class QueriesTests
    {
        private static Random rnd = new Random();
        [Test]
        public void CreateJSONTest()
        {
            JRoot root = new JRoot();
            JKeyValuePair mathTest = new JKeyValuePair(new JString("Math Test"), null, root);
            JArray testResultArray = new JArray(mathTest);

            testResultArray.Add(
                CreateNewStudentTestResult(testResultArray, ("Ivan"), ("Ivanov")),
                CreateNewStudentTestResult(testResultArray, ("Pyotr"), ("Petrov")),
                CreateNewStudentTestResult(testResultArray, ("Vasily"), ("Vasilyev")),
                CreateNewStudentTestResult(testResultArray, ("Maria"), ("Marieva")),
                CreateNewStudentTestResult(testResultArray, ("Pavel"), ("Pavlov")),
                CreateNewStudentTestResult(testResultArray, ("Roman"), ("Romanov")),
                CreateNewStudentTestResult(testResultArray, ("Boris"), ("Borisov")),
                CreateNewStudentTestResult(testResultArray, ("Ulya"), ("Ulyeva"))
                );

            mathTest.Value = testResultArray;

            root.Add(mathTest);
            root.ToFile("MathTest.json");
            if (File.Exists("MathTest.json"))
                Process.Start("notepad.exe", "MathTest.json");
            Assert.IsTrue(File.Exists("MathTest.json"));
        }

        public JObject CreateNewStudentTestResult(JArray studentArray, string firstName, string lastName)
        {
            JObject testResult = new JObject(studentArray);
            JKeyValuePair student = new JKeyValuePair( 
                new JString("name"),
                new JKeyValuePair(new JString(firstName), new JString(lastName))
                );
            testResult.Add(student, 
                new JKeyValuePair(new JString("date"), new JString(DateTime.Now.ToString())), 
                new JKeyValuePair(new JString("mark"), new JSingleValue(rnd.Next(2, 5).ToString()))
                );
            return testResult;
        }
    }
}