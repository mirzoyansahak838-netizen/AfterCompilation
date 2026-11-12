using System;
using System.Collections.Generic;
using System.Text;

namespace AfterCompilation
{
    internal class Level
    {
        public int level;
        public Bonus b1;   

        public int Func(int n)
        {
            return n + level + b1.bonus;
        }
    }
}
