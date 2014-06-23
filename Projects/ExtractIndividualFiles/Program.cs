/* -------------------------- EXTRACT INDIVIDUAL FILES --------------------------
 *  This tool extracts files from a zip archive which have a specific extension.
 * 
 *  SOUCRE: http://msdn.microsoft.com/en-us/library/ms404280(v=vs.110).aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* TODO:
 * + Read file extension from user input.
 * + Perform directory checking (i.e. if the directories are valid)
 *   In case the output directory does not exist, prompt the user if he wants to
 *   create  it.
 */

namespace ExtractIndividualFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            Parser parser = new Parser();
            Console.WriteLine("ZIP file path: ");
            while (!parser.processZipPath(Console.ReadLine())) ;

            Console.WriteLine("Extraction path: ");
            while (!parser.processExtrPath(Console.ReadLine())) ;

            Console.WriteLine("Extension to extract: ");
            parser.processExtension(Console.ReadLine());

            Extractor extractor = new Extractor();
            extractor.extractFiles();
            
        }
    }
}
