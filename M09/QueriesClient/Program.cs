using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using EPAM.CSCourse2016.SilkinIvan.JSONParser;
using System.Collections.Generic;

namespace QueriesClient
{
    class Program
    {
        private static Random rnd = new Random();
        private const string _name = "-name";
        private const string _minmark = "-minmark";
        private const string _maxmark = "-maxmark";
        private const string _datefrom = "-datefrom";
        private const string _dateto = "-dateto";
        private const string _test = "-test";

        static void Main(string[] args)
        {
            JSONParser jSONParser = new JSONParser(FindJSONFile());
            var jItem = jSONParser.Parse();
            //Console.WriteLine(jItem.ToString());
            var jItemList = new List<JItem>();
            jItem.ListAllNodes(ref jItemList);
            var query = from JItem item in jItemList where item.HasKeyOrValue() select (JKeyValuePair)item;
            ShowQuery(query);

            const string mark = "3";
            args = new string[] { "-mark", mark };
            ShowQueryEqualByParameter(query, args, "-mark", false, JItemType.SingleValue);

            args = new string[] { "-name", "Ivan" };
            ShowQueryEqualByParameter(query, args, "-name", true, JItemType.String);

            var higherMarks = from JKeyValuePair pair in query 
                        where pair.ContainsIntegerValue() 
                        select pair;
            var higherMarksObjects = higherMarks
                .Where(p => p.GetIntegerValueOrReturnNull() >= int.Parse(mark))
                .Select(x => x.FindContainerOrReturnParent(new JString("Student")));
            ShowQuery(higherMarksObjects);


            Console.Read();
        }

        public static void ShowQueryWithIntComparedToParameter(
            IEnumerable<JKeyValuePair> query,
            string[] args, string parameter, CompareType compareType,
            bool key = true,
            JItemType itemType = JItemType.SingleValue)
        {
            if (args.Contains(parameter))
            {
                if (args.Length > (Array.IndexOf(args, parameter) + 1))
                {
                    var higherMarks = from JKeyValuePair pair in query
                                      where pair.ContainsIntegerValue()
                                      select pair;
                    var higherMarksObjects = higherMarks
                        .Where(p => p.GetIntegerValueOrReturnNull() >= 
                        int.Parse(args[Array.IndexOf(args, parameter) + 1])
                        )
                        .Select(x => x.FindContainerOrReturnParent(new JString("Student")));
                    ShowQuery(higherMarksObjects);
                }
            }
        }
        public bool CompareIntsByMethod(int? left, int right, CompareType compareType)
        {
            if (left is null)
                return false;
            int compared = left.Value.CompareTo(right);
            if (compared == 0)
                return true;
            else if (compared < 0 || compareType == CompareType.LessOrEquals) {
                return true;
            }
            else if (compared > 0 || compareType == CompareType.MoreOrEquals) {
                return true;
            }
            return false;
        }

        public static void ShowQueryEqualByParameter(
        IEnumerable<JKeyValuePair> query, 
        string[] args, string parameter, bool key = true, 
        JItemType itemType = JItemType.SingleValue)
        {
            if (args.Contains(parameter))
            {
                if (args.Length > (Array.IndexOf(args, parameter) + 1))
                {
                    var student = new JString("Student");
                    var certainQuery = query.Where(x => 
                        (key ? x.Key : x.Value)
                        .Equals(JItem. Factory(itemType, args[Array.IndexOf(args, parameter) + 1])) 
                        ).Select(x => x.FindContainerOrReturnParent(student));
                    ShowQuery(certainQuery);
                }
            }
        }

        public static void ShowQueryMoreThanParameter(
        IEnumerable<JKeyValuePair> query,
        string[] args,
        string parameter,
        bool key = true,
        JItemType itemType = JItemType.SingleValue)
            {
                if (args.Contains(parameter))
                {
                    if (args.Length > (Array.IndexOf(args, parameter) + 1))
                    {
                        var student = new JString("Student");
                        var certainQuery = query.Where(x =>
                            (key ? x.Key : x.Value)
                            .Equals(JItem.Factory(itemType, args[Array.IndexOf(args, parameter) + 1]))
                            ).Select(x => x.FindContainerOrReturnParent(student));
                        ShowQuery(certainQuery);
                    }
                }
            }

        public static void ShowQuery(IEnumerable<JItem> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("______");
        }

        private static string FindJSONFile()
        {
            DirectoryInfo dI = new DirectoryInfo(Environment.CurrentDirectory);
            while (dI.Name != "M09" && dI.Parent.Exists)
            {
                dI = dI.Parent;
            }
            return $@"{dI.FullName}\QueriesTests\bin\Release\netcoreapp3.1\MathTest.json";
        }
    }
}
