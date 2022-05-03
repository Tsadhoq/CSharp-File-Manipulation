using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVManipulation
{
    public class FileWriterClass
    {
        public void FileWriteToCsv(string text)
        {
            File.WriteAllText(ThePaths.FilePath1.ToString(), text);
        }
    }
}
