using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class HumanGenerator
    {
        public IHuman GetHuman(int id)
        {
            if(id == 0)
            {
                return new Japanese();
            }
            return new Chinese();
        }
    }
}

//Simple Factoryパターン　http://okwakatta.net/designpattern/dpSimpleFactory.html