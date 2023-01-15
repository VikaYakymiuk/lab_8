using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    public class Box<T>
    {
        private T something;
        public Box(T x)
        {
            this.something = x;
        }
        public override string ToString()
        {
            return $"{this.something.GetType()}: {this.something}";
        }
    }
}
