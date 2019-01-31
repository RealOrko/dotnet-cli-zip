using System;
using System.IO.Compression;

namespace zip
{
    class Program
    {
        const int ActionOrdinal = 0;
        const int FromOrdinal = 1;
        const int ToOrdinal = 2;

        const string ExtractAction = "-e";
        const string CompressAction = "-c";

        static void Main(string[] args)
        {
            if (args.Length == 0 || args[0] == "--help" || args[0] == "/?" || args[0] == "?" || args.Length != 3)
            {
                PrintUsage();
                return;
            }

            try
            {
                var actionValue = args[ActionOrdinal];
                var fromValue = args[FromOrdinal];
                var toValue = args[ToOrdinal];

                if (actionValue == ExtractAction)
                {
                    ExtractFilesRecursively(fromValue, toValue);
                }
                else if (actionValue == CompressAction)
                {
                    CompressFilesRecursively(fromValue, toValue);
                }
                else
                {
                    PrintUsage();
                }
            }
            catch (Exception err)
            {
                PrintUsage();
                Console.Error.WriteLine(err);
            }
        }

        private static void CompressFilesRecursively(string folderPath, string zipPath)
        {
            Console.WriteLine($"Compressing from '{folderPath}' to '{zipPath}' recursively.");
            ZipFile.CreateFromDirectory(folderPath, zipPath);
        }

        private static void ExtractFilesRecursively(string zipPath, string folderPath)
        {
            Console.WriteLine($"Extracting from '{folderPath}' to '{zipPath}' recursively.");
            ZipFile.ExtractToDirectory(zipPath, folderPath, overwriteFiles:true);
        }

        static void PrintUsage()
        {
            Console.WriteLine("dotnet cli zip");
            Console.WriteLine("---------------");
            Console.WriteLine("Usage:");
            Console.WriteLine("   > z -e MyZip.zip ./MyZipFolder");
            Console.WriteLine("   > z -c ./MyZipFolder MyZip.zip");
        }
    }
}
