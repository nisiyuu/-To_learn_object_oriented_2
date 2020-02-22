using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    //IHumanインターフェイスの実装（インターフェイスを継承してクラスを定義すること）＝＞実装クラス
    class Japanese : IHuman //インターフェイスはクラスと異なり複数実装できる
    {
        public string SayHello()
        {
            Console.WriteLine("こんにちは");
            return "a";
        }
    }
}
