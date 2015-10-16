using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        public static UI ui = new UI();
        public static DroidCollection droidCollection = new DroidCollection();

        static void Main(string[] args)
        {
            ui.PrintMenu();
            MainLoop();
        }

        static void MainLoop()
        {
            while(ui.userInput != "exit")
            {
                ui.GetInput();
                switch(ui.userInput)
                {
                    case "Add Droid":
                        ui.GatherInfo();
                        break;
                    case "Print Droids":
                        ui.PrintArray();
                        break;
                    case "exit":
                        //We out.
                        break;
                }
            }
        }
    }
}
