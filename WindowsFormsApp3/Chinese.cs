using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Chinese : IHuman　//IHumanインターフェイスの実装
    {
        public string SayHello()
        {
            Console.WriteLine("にーはお");
            return "a";
        }
    }
}
