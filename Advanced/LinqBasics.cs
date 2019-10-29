using System;
using System.IO;
using System.Linq;

namespace Advanced
{
    class LinqBasics
    {
        public void Top5FilesInADirectory()
        {
            var query = new DirectoryInfo("C:\\Windows").GetFiles().OrderByDescending(file => file.Length).Take(5);

            var query2 = (from file in new DirectoryInfo("C:\\Windows").GetFiles()
                            orderby file.Length descending
                            select file).Take(5);

            foreach (var file in query )
            {
                Console.WriteLine(file);
            }
        }
    }
}
