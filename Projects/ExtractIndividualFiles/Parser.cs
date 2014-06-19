using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtractIndividualFiles
{
    class Parser
    {   
        private enum Option
        {
            exit,
            yes,
            no,
            error
        };

        Option userOpt;
        private bool zipDirSet = false; // tracks if the zip file directory has been set
        private string optionInput;

        private bool processOpt(string option)
        {
            if (option == "yes" || option == "y")
            {
                userOpt = Option.yes;
                return true;
            }
            else if (option == "no" || option == "n")
            {
                userOpt = Option.no;
                return true;
            }
            else if (option == "exit" || option =="e")
            {
                userOpt = Option.exit;
                return true;
            }

            return false; // no valid option found
            
        }

        public void processInput()
        {
            
            ExtractionInfo.zipPath = Console.ReadLine(); // read the zip path

            while (!File.Exists(ExtractionInfo.zipPath))
            {
                Console.WriteLine("Invalid zip file path. Please enter a valid one: ");
                ExtractionInfo.zipPath = Console.ReadLine();
            }
            
            ExtractionInfo.extractionPath = Console.ReadLine(); // read the extraction path

            if (!Directory.Exists(ExtractionInfo.extractionPath))
            {
                Console.WriteLine("The {0} directory does not exist.", ExtractionInfo.extractionPath);
                Console.WriteLine("Would you like to create it?");
                
                OptionInput = Console.ReadLine().ToLower();
                // Process user's option input
                while (!processOpt(OptionInput))
                    // While the input is not valid, keep prompting
                    Console.WriteLine("Please answer 'yes' or 'no' "); // 'exit' works here too
                /*  TODO: 
                 *  + if the user answers 'yes'
                 *  + if the user answers 'no'
                 */
                if (userOpt == Option.yes)
                {
                    try
                    {
                        DirectoryInfo newDir = Directory.CreateDirectory(ExtractionInfo.extractionPath);
                        Console.WriteLine("Directory created sucessfully!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Directory creation failed!");
                        Console.WriteLine("{0}",e.ToString() );
                    }
                    finally { }
                }
                    


            }

            
        }

        // Properties
        private string OptionInput { set; get; }



    }

}
