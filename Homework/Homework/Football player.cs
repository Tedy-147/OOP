using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public abstract class Football_player : Person
    {
        public int number;
        public int height;
        protected int Number
        {
            get { return number; }
            set { number = value; }
        }
        protected int Height
        {
            get { return height; }
            set { height = value; }
        }
        
    }
}
