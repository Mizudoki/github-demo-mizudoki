using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02._1
{
    public class Developer : Person
    {
        public override void Speak()
        {
            Console.WriteLine("Developer is speaking...");
        }
    }
}
