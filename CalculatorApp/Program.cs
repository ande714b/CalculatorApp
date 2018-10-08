using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            IBindings bindings = new Bindings();
            SmartMenu menu = new SmartMenu();
            menu.LoadMenu("MenuSpec.txt");
            menu.Activate(bindings);
        }
    }
}
