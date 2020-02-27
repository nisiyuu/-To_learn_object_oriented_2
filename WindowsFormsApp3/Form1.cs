using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;//int型初期値0で0いれたら被る　参照であればnull
            Object[] test = new Object[5];


            var x = 1;
            var y = x; 
            x += 10;
            Console.WriteLine(x);//11 
            Console.WriteLine(y);//1 //yそのものがxに変更される＝＞値型の代入

            var builder1 = new StringBuilder("あいう");
            var builder2 = builder1;
            builder1.Append("えお");
            Console.WriteLine(builder1.ToString());//あいうえお　
            Console.WriteLine(builder2.ToString());//あいうえお
            //bulder2はbuilder1のアドレスを自分のアドレスに上書きされる＝＞参照型の代入

            var builder3 = new StringBuilder("あいう");
            var builder4 = new StringBuilder("あいう");
            Console.WriteLine(builder3 == builder4);//同一性を比較、同値性ではない




            //interfaceの話
            //IHumanはinterfaceでHumanGeneratorというクラスからインスタンスを生成し、HumanGenerator
            //に定義されたGetHumanを使用する。GetHumanの引数によってJapanese.csのSayhelloが呼ばれたり、
            //ChineseのSayhelloが呼ばれる。

            IHuman human = new HumanGenerator().GetHuman(0);
            human.SayHello();
            human = new HumanGenerator().GetHuman(1);
            human.SayHello();

            Abstest test222 = new Test(1,2);
            Console.WriteLine(test222.GetArea());
            Console.WriteLine(test222.Notabstest());

            DicBasic dic = new DicBasic();
            dic.Run();

            double d = Test.Pi;//クラスフィールド　newしなくても使える
            Console.WriteLine(Test.Pi);


            IteratorBasic ite = new IteratorBasic();
            ite.Run();
        }
    }
}



//
//