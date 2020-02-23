using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    abstract class Abstest
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Abstest(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public abstract double GetArea();//抽象メソッドだから継承先で必ず実装する

        public virtual String Notabstest()//抽象メソッドではないから継承先で実装しなくてもいい。またvirtualはオーバーライドする際に抽象メソッド側につける
        {
            return "notabs";
        }

    }
}

//抽象クラスは抽象メソッドを書くかつ具体的実装をもったメソッド（abstructがついてない）もかける
//インターフェイスは抽象メソッドだけ書く。具体的実装はかけない。
//これらの使い分けが大切。
//抽象クラスで具体的な実装で場合ごとのメソッドを書くか、インターフェイスで場合ごとのクラスを増やすか（＝Japanese.cs,Chenese.csなどを増やすか）
