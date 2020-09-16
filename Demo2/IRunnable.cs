using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    interface IRunnable
    {
        public string RunString { get; set; }
        public void Run();
    }
}
