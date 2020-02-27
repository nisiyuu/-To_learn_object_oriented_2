using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class IteratorBasic　//イテレーター
    {
        public IEnumerable<string>GetString()//IEnumerableはインターフェイス　ジェネリックでstring型指定
        {
            yield return "あいうえお";//yield returnとすることでその時々の値を返せる.通常のreturnであればretunrの時点で処理を終了する。
            yield return "かきくけこ";
            yield return "さしすせそ";

        }

        public void Run()
        {
            var ite = new IteratorBasic();
            foreach(var str in ite.GetString())
            {
                Console.WriteLine(str);
            }
        }
    }
}
