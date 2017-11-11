using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SK_Import.Models;
using System.Diagnostics;
using SK_Import.Utilities;

//csevent is notes about events
//csreftbl is lookups / defined values
//scqkacct is account ids
//csind is individuals
//csgroup is groups
//csfamily is families
//cscach is cash donations
//csattsum is attendance summary?
//csattend is attendance?



namespace SK_Import
{
    class Program
    {
        static void Main( string[] args )
        {
            string zipPath = @"c:\SKBACKUP.SKB";
            string extractPath = @"c:\temp\skbackup";

            try
            {
            Directory.Delete( extractPath, true );
            }
            catch
            {
            }

            ZipFile.ExtractToDirectory( zipPath, extractPath );

            var individual = FixedWidthFile.Convert( "C:\\temp\\skbackup\\user\\csind.udb" ).Map<Individual>();
            Console.ReadKey();
        }
    }
}
