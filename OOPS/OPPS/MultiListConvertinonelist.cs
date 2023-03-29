using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPS
{
    public class Table
    {
        public int a { get; set; }
        public string b { get; set; }
    }


    public class CallMultiList
    {
        //public static void Main()
        //{

        //    var tagIdList = new List<int>() { 1, 2, 3, 3, 4 };            
        //    var tagList = new List<string>() { "a", "b", "d", "e" };
            
        //    var tagIdAndSelectionList = tagIdList.Zip(tagList, (tagId, isTagSelected) => new { tagId, isTagSelected }).ToList();

        //    var removeduplicate = tagIdAndSelectionList.GroupBy(x => new { x.tagId }).Select(x => x.First()).ToList();

        //    foreach (var item in removeduplicate)
        //    {
        //        Console.WriteLine("{0} {1}", item.isTagSelected, item.tagId);
        //    }

        //    //List<int> IntList = new List<int>() { 1,2,4,4,5 };
        //    //List<string> StringList = new List<string>() { "a", "b", "c", "c", "f" };



        //    //var expected = (
        //    //    from t1 in IntList
        //    //    join t2 in StringList on IntList.IndexOf(t1)
        //    //    equals StringList.IndexOf(t2)
        //    //    select new Table { a = t1, b = t2 }).ToList();

        //    //var removeduplicate = expected.GroupBy(x => new { x.b }).Select(x => x.LastOrDefault()).ToList();

        //    //foreach (var item in removeduplicate)
        //    //{
        //    //    Console.WriteLine("{0} {1}", item.a, item.b);
        //    //}

        //    Console.ReadLine();
        //}
    }
}
