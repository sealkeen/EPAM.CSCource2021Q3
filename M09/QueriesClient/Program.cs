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
            
            QueryRetriver queryRetriver = new QueryRetriver();
            queryRetriver.ShowQuery(query);

            args = new string[] { "-mark", "3" };
            queryRetriver.ShowQueryEqualByParameter(query, args, "-mark", false, JItemType.SingleValue);

            args = new string[] { "-mark", "3" };
            queryRetriver.ShowQueryWithIntComparedToParameter(query,
                args, "-mark", CompareType.LessOrEquals, false, JItemType.SingleValue);

            args = new string[] { "-mark", "4" };
            queryRetriver.ShowQueryWithIntComparedToParameter(query,
                args, "-mark", CompareType.MoreOrEquals, false, JItemType.SingleValue);

            args = new string[] { "-name", "Ivan" };
            queryRetriver.ShowQueryEqualByParameter(query, args, "-name", true, JItemType.String);

            //var higherMarks = from JKeyValuePair pair in query 
            //            where pair.ContainsIntegerValue() 
            //            select pair;
            //var higherMarksObjects = higherMarks
            //    .Where(p => p.GetIntegerValueOrReturnNull() >= int.Parse(mark))
            //    .Select(x => x.FindContainerOrReturnParent(new JString("Student")));
            //ShowQuery(higherMarksObjects);


            Console.Read();
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
