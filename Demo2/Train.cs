using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    class Train : Fordon, IRunnable
    {
        public Train(string name)
        {
            Console.WriteLine("Train konstruktor");
        }
        public string RunString { get; set; }
    }
}
