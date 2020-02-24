using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class DicBasic //コレクションはオブジェクトの集合体
    {
        Dictionary<string, string> dic = new Dictionary<string, string>()//<>はジェネリック構文　ディクショナリはJSでいうオブジェクトのようなデータ構造を表す　<キーの型、値の型>
        {
            ["Rose"] = "バラ",
            ["SunFlower"] = "ひまわり",
            ["Morning Glory"] = "あさがお"
        };

        public void Run()
        {
            Console.WriteLine(dic.Count);
            Console.WriteLine(dic.ContainsKey("Rose"));
            Console.WriteLine(dic.ContainsValue("バラ"));

            dic.Add("Tulip", "チューリップ"); //C#の配列は長さを変えられない。変えたいときはコレクションを使う。Addでデータを増やしている
            dic["Sunflower"] = "向日葵";

            foreach (var key in dic.Keys)//https://docs.microsoft.com/ja-jp/dotnet/api/system.collections.generic.dictionary-2?view=netframework-4.8 Keysプロパティがある
            {
                Console.WriteLine($"{key}:{dic[key]}");
            }

            foreach(var d in dic.Values)//ValuesプロパティもKeysと同様に組み込みで用意されたプロパティ
            {
                Console.WriteLine(d);
            }

        }
    }

}
