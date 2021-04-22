using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronPythonTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = IronPython.Hosting.Python.CreateEngine();
            var scope = engine.CreateScope();

            try
            {
                var source = engine.CreateScriptSourceFromFile(@"test.py");
                source.Execute(scope);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.StackTrace); 
            }
        }
    }
}
