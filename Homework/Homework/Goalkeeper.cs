using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Goalkeeper : Football_player
    {
        public Goalkeeper(string Name, int Age, int Number, int Height)
        {
            name = Name;
            age = Age;
            number = Number;
            height = Height;
        }
    }
}
