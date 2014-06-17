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
using System.IO;
using System.IO.Compression;

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
            string zipPath = @"c:\example\example.zip"; // path to zip file
            string extractPath = @"c:\example\extract"; // where to extract the files
            string fileExtension = ".txt"; // desired file extension to extract

            using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    // for every entry (aka file) in the zip archive
                    if (entry.FullName.EndsWith(fileExtension,  StringComparison.OrdinalIgnoreCase))
                    {
                        // if the file's name ends with the desired extension, extract it!
                        entry.ExtractToFile(Path.Combine(extractPath, entry.FullName));
                    }
                }
            }
        }
    }
}
