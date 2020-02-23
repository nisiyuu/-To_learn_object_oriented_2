using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Test : Abstest//継承
    {
        public Test(double width, double height) : base(width,height)//基底クラスの引数ありのコンストラクタを呼び出す
        {
           
        }
        public override double GetArea()//オーバーライドの処理
        {
            return this.Width + this.Height;
        }

        public override string Notabstest()//オーバーライドの処理
        {
            return "changed";
        }
    }

}
