using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var copyFrom = @"C:\Users\ceidson\Desktop\ReverseProco\Generator";
            var copyTo = @"C:\Users\ceidson\Desktop\PocoSeperated";

            var files = Directory.GetFiles(copyFrom).Where(x=>x.EndsWith(".cs")).ToList();

            var mappingPath = Path.Combine(copyTo, "Mappings");
            var entitiesPath = Path.Combine(copyTo, "Entities");
            System.IO.Directory.CreateDirectory(mappingPath);
            System.IO.Directory.CreateDirectory(entitiesPath);
            
            foreach (var file in files)
            {
                if (file.EndsWith("Mapping.cs"))
                {
                    File.Copy(file, Path.Combine(mappingPath, Path.GetFileName(file)));
                }
                else
                {
                    File.Copy(file, Path.Combine(entitiesPath, Path.GetFileName(file)));
                }
            }

        }
    }
}
