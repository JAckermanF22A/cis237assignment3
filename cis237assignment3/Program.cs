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
            Console.SetWindowSize(150, 40); //Expands the console for easier viewing!

            droidCollection.AddAstromech("Astromech", "steel", "Red", true, true, true, true, 5);
            droidCollection.AddJanitor("Janitor", "titanium", "Grey", true, false, true, true, true);
            droidCollection.AddProtocol("Protocol", "steel", "Red", 5);
            droidCollection.AddUtility("Utility", "steel", "Pink", false, true, true);
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
