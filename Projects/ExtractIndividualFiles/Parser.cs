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
            blank // blank option means no option has been selected
        };

        Option userOpt;
        private bool outDirSet = false; // tracks if the output file directory has been set
        private string optionInput;

        private void printAvailableCommands()
        {
            Console.WriteLine("Available commands: yes, no, exit");
        }

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

        public bool processZipPath(string userZipPath)
        {
            /* This function processes the zip file path input 
             * Returns true in case a valid path has been set, false otherwise
             */
            if (!File.Exists(userZipPath))
            {
                // If the file does not exist
                Console.WriteLine("The specified zip file does not exist");
                return false;
            }
            else if (!userZipPath.EndsWith(".zip"))
            {
                // User did not provide a zip file
                Console.WriteLine("Please provide a valid zip file path");
                return false;
            }
            else
            {
                // File exists, everything is OK
                ExtractionInfo.zipPath = userZipPath;
                return true;
            }

        }

        public bool processExtrPath(string userDir)
        {
            /* This function processes the extraction path input.
             * Returns true in case a valid path has been set, false otherwise.
             */

            Option userOpt = Option.blank;

            if (!Directory.Exists(userDir))
            {
                // If the file does not exist
                Console.WriteLine("The specified path file not exist, would you like to create it?");
                while (!processOpt(Console.ReadLine()))
                {
                    Console.WriteLine("Invalid input");
                    this.printAvailableCommands();
                }

                if (userOpt == Option.yes)
                {
                    // User answered yes, create the directory!
                    try
                    {
                        // Try and create the directory
                        Directory.CreateDirectory(userDir);
                        Console.WriteLine("Directory created successfully!");
                        ExtractionInfo.extractionPath = userDir;
                        return true;
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Directory creation failed: {0}", e.ToString());
                        return false;
                    }
                    finally { }
                }
                else if (userOpt == Option.no)
                {
                    return false;
                }
                else if (userOpt == Option.exit)
                {
                    Environment.Exit(0); // terminate the program execution
                    return false;
                }
                else
                {
                    // Something went wrong
                    return false;
                }
                
            }
            else
            {
                // Valid path
                ExtractionInfo.extractionPath = userDir;
                return true;
            }
            
        }

        // Properties
        private string OptionInput { set; get; }



    }

}
