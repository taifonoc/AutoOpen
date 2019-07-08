using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOpen
{
    class Class1
    {
        public void CreateDictionary(string r)
        {
            string t;
            Dictionary<string, string> MyDic = new Dictionary<string, string>( );
            MyDic.Add("Name", "Jack");
            MyDic.Add("Blog", "Jack’s Blog");
            MyDic.Add("Group", "KTV Group");
            Console.WriteLine(MyDic["Name"]);
        }
    }
}
