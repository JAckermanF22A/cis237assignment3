using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UI
    {
        private string tempModel;
        private string tempMaterial;
        private string tempColor;
        private int tempNumberOfLanguages;
        private bool tempToolBox;
        private bool tempComputerConnection;
        private bool tempArm;
        private bool tempTrashCompactor;
        private bool tempVacuum;
        private bool tempFireExtinguisher;
        private int tempNumberShips;

        public string userInput;

        private int displayedCounter;

        public void PrintMenu()
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Add Droid" + " | " + "Print Droids" + " | " + "Print Menu");
            Console.WriteLine("------------------------------------------------------------------------");
        }

        public void GetInput()
        {
            userInput = Console.ReadLine();
        }



        public void GatherInfo()
        {
            Console.WriteLine("Please enter the droid model: ");
            tempModel = Console.ReadLine();

            Console.WriteLine("Please enter the material the droid was constructed with:");
            tempMaterial = Console.ReadLine();

            Console.WriteLine("Please enter the color of the droid:");
            tempColor = Console.ReadLine();

            switch (tempModel)
            {
                case "Protocol":
                    Console.WriteLine("How many languages does the robot support?");
                    try
                    {
                        tempNumberOfLanguages = Int32.Parse(Console.ReadLine());
                        Program.droidCollection.AddProtocol(tempModel, tempMaterial, tempColor, tempNumberOfLanguages);

                    }
                    catch
                    {
                        Console.WriteLine("Error: Input was not an integer. Please input an integer.");
                    }
                    break;
                case "Utility":
                    Console.WriteLine("Is the droid equipped with a tool box?");
                    Console.WriteLine("y/n?");
                    switch (Console.ReadLine())
                    {
                        case "y":
                            tempToolBox = true;
                            break;
                        case "n":
                            tempToolBox = false;
                            break;
                        default:
                            Console.WriteLine("Error: You entered something other than a y or n.");
                            break;
                    }
                    Console.WriteLine("Is the droid able to connect to a computer?");
                    Console.WriteLine("y/n?");
                    switch (Console.ReadLine())
                    {
                        case "y":
                            tempComputerConnection = true;
                            break;
                        case "n":
                            tempComputerConnection = false;
                            break;
                        default:
                            Console.WriteLine("Error: You entered something other than a y or n.");
                            break;
                    }
                    Console.WriteLine("Does the robot have an arm?");
                    Console.WriteLine("y/n?");
                    switch (Console.ReadLine())
                    {
                        case "y":
                            tempArm = true;
                            break;
                        case "n":
                            tempArm = false;
                            break;
                        default:
                            Console.WriteLine("Error: You entered something other than a y or n.");
                            break;
                    }
                    Program.droidCollection.AddUtility(tempMaterial, tempMaterial, tempColor, tempToolBox, tempComputerConnection, tempArm);
                    break;
                case "Janitor":
                    Console.WriteLine("Does the droid have a trash compactor?");
                    Console.WriteLine("y/n");
                    switch (Console.ReadLine())
                    {
                        case "y":
                            tempTrashCompactor = true;
                            break;
                        case "n":
                            tempTrashCompactor = false;
                            break;
                        default:
                            Console.WriteLine("Error: You entered something other than a y or n.");
                            break;
                    }
                    Console.WriteLine("Does the droid have a vacuum?");
                    Console.WriteLine("y/n");
                    switch (Console.ReadLine())
                    {
                        case "y":
                            tempVacuum = true;
                            break;
                        case "n":
                            tempVacuum = false;
                            break;
                        default:
                            Console.WriteLine("Error: You entered something other than a y or n.");
                            break;
                    }
                    Program.droidCollection.AddJanitor(tempModel, tempMaterial, tempColor, tempToolBox, tempComputerConnection, tempArm, tempTrashCompactor, tempVacuum);
                    break;
                case "Astromech":
                    Console.WriteLine("Does the droid have a fire extinguisher?");
                    Console.WriteLine("y/n");
                    switch (Console.ReadLine())
                    {
                        case "y":
                            tempFireExtinguisher = true;
                            break;
                        case "n":
                            tempFireExtinguisher = false;
                            break;
                        default:
                            Console.WriteLine("Error: You entered something other than a y or n.");
                            break;
                    }
                    Console.WriteLine("How many ships can the droid repair?");
                    tempNumberShips = Int32.Parse(Console.ReadLine());
                    Program.droidCollection.AddAstromech(tempModel, tempMaterial, tempColor, tempToolBox, tempComputerConnection, tempArm, tempFireExtinguisher, tempNumberShips);
                    break;
            }
        }

        public void PrintArray()
        {
            displayedCounter = 0;
            int lengthOfArray = Program.droidCollection.droidArray.Count(x => x != null);
            PrintHeader();
            while(displayedCounter < lengthOfArray)
            {
                /*switch (userInput)
                {
                    case "Protocol":
                        PrintProtocol();
                        break;
                    default:
                        Console.WriteLine("Not Implemented Yet");
                        break;
                }*/

                Console.WriteLine(Program.droidCollection.droidArray[displayedCounter].ToString());
                
                
                //Console.WriteLine(Program.droidCollection.droidArray[displayedCounter]);
                displayedCounter++;
            }
        }

        private void PrintHeader()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Model      | Material | Color | # Lang | Tool Box | Comp Connection | Arm | Trash Compactor | Vacuum | Fire Extinguisher | Ship #s | Total Cost");
        }
    }
}
