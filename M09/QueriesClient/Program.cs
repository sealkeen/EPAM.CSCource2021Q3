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

            args = new string[] { "-mark", "2" };
            ShowQueryByParameter(query, args, "-mark", CompareType.LessThan, false, JItemType.SingleValue);

            args = new string[] { "-name", "Ivan" };
            ShowQueryByParameter(query, args, "-name", CompareType.Equals, true, JItemType.String);

            Console.Read();
        }
        public static void ShowQueryByParameter(
            IEnumerable<JKeyValuePair> query, 
            string[] args, 
            string parameter, 
            CompareType compareType,
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
                        .Compare(JItem. Factory(itemType, args[Array.IndexOf(args, parameter) + 1])) 
                        == (int)compareType
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
