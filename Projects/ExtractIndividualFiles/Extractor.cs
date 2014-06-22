using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace ExtractIndividualFiles
{
    class Extractor
    {
        public void extractFiles(){

            using (ZipArchive archive = ZipFile.OpenRead(ExtractionInfo.zipPath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        // for every entry (aka file) in the zip archive
                        if (entry.FullName.EndsWith(ExtractionInfo.fileExtension,  StringComparison.OrdinalIgnoreCase))
                        {
                            // if the file's name ends with the desired extension, extract it!
                            entry.ExtractToFile(Path.Combine(ExtractionInfo.extractionPath, entry.FullName));
                        }
                    }
                }
        }
    }
}
