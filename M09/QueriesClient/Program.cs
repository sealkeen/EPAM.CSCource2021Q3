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
            args = new string[] { "-name", "Ivan"};
            JSONParser jSONParser = new JSONParser(FindJSONFile());
            var jItem = jSONParser.Parse();
            //Console.WriteLine(jItem.ToString());
            var jItemList = new List<JItem>();
            jItem.ListAllNodes(ref jItemList);
            var query = from JItem item in jItemList where (item is JKeyValuePair) select (JKeyValuePair)item;
            ShowQuery(query);
            if (args.Contains(_name))
            {
                //query = query.Where(x => x.Key.Equals(new JString("name")));
                //ShowQuery(query);
                if (args.Length > (Array.IndexOf(args, _name) + 1))
                {
                    query = query.Where(x => x.Contains(new JString(args[Array.IndexOf(args, _name)+1])));
                    ShowQuery(query);
                }
            }


            Console.Read();
        }
        public static void ShowQuery(IEnumerable<JItem> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
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
