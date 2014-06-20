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
        private bool outDirSet = false; // tracks if the output file directory has been set
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
            Console.WriteLine("ZIP file path:");
            ExtractionInfo.zipPath = Console.ReadLine(); // read the zip path

            while (!File.Exists(ExtractionInfo.zipPath))
            {
                Console.WriteLine("Invalid zip file path. Please enter a valid one: ");
                ExtractionInfo.zipPath = Console.ReadLine();
            }

            while (!outDirSet) {
                Console.WriteLine("Ouput path: ");
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
                            outDirSet = true;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Directory creation failed!");
                            Console.WriteLine("{0}", e.ToString());
                        }
                        finally { }
                    }
                    else if (userOpt == Option.exit)
                    {
                        return;

                    }
                    else
                    {
                        // if user types 'no'
                        Console.WriteLine("You will be prompted for a new path");
                    }

                }
                else
                {
                    // The path is valid
                    outDirSet = true;

                }

            }

            
        }

        // Properties
        private string OptionInput { set; get; }



    }

}
