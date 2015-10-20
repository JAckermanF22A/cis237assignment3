using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Jacob Ackerman

namespace cis237assignment3
{
    class Program
    {
        public static UI ui = new UI();
        public static DroidCollection droidCollection = new DroidCollection();

        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 40); //Expands the console so everything fits.
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
                    case "Print Menu":
                        ui.PrintMenu();
                        break;
                    case "exit":
                        //Exits the loop
                        break;
                    default:
                        ui.MenuError();
                        break;
                }
            }
        }
    }
}
