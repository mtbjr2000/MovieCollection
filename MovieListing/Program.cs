using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Client;
using TMDbLib.Objects.General;

namespace MovieListing
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMovieList();

            Console.WriteLine("\nCOMPLETED");
            Console.ReadLine();
        }

        private static void GetMovieList()
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\mtbjr\Desktop\Titles.txt");

            GetMovieListPipeDelimited(new DirectoryInfo(@"G:\"), writer);
            GetMovieListPipeDelimited(new DirectoryInfo(@"I:\"), writer);
            //GetMovieListPipeDelimited(new DirectoryInfo(@"J:\"), writer);

            writer.Flush();
            writer.Close();
        }

        static void GetMovieListPipeDelimited(DirectoryInfo rootDir, StreamWriter writer)
        {
            try
            {
                var files = (from i in rootDir.GetFiles()
                             where i.Extension == ".mkv"
                             orderby i.Name
                             select i).ToArray();

                if (files.Length > 0)
                {
                    TMDbClient client = new TMDbClient("3356865d41894a2fa9bfa84b2b5f59bb");

                    foreach (FileInfo item in files)
                    {
                        Console.WriteLine(item.Name);
                        
                        string title = item.Name.Substring(0, item.Name.LastIndexOf(".")).Replace("REMUX", "").Replace("4K", "").Trim();
                        var match = client.SearchMovieAsync(title).Result;

                        int movieId = 0;
                        string movieTitle = "%";

                        if (match.Results.Count > 0 && match.Results[0].MediaType == MediaType.Movie)
                        {
                            var exact = match.Results.FirstOrDefault(i => i.Title == title);

                            if (exact != null)
                            {
                                movieId = match.Results[0].Id;
                                movieTitle = match.Results[0].Title;
                            }                            
                        }

                        double size = item.Length / 1024.00 / 1024.00 / 1024.00;

                        if (size > 0.00)
                            writer.WriteLine($"{item.Name}|{size:n}|{movieId}|{movieTitle}");
                    }
                }

                foreach (DirectoryInfo item in rootDir.GetDirectories())
                    GetMovieListPipeDelimited(item, writer);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}\n");
            }
        }

        static void GetMovieListWithHeader(DirectoryInfo rootDir, StreamWriter writer)
        {
            try
            {
                string[] extensionExceptions = { ".jpg", ".jpeg", ".JPG", ".db" };
                string[] directoryExceptions = { "$RECYCLE.BIN", "Pictures", "Music" };

                var files = (from i in rootDir.GetFiles()
                             where extensionExceptions.Contains(i.Extension) == false
                             && i.LastAccessTime >= new DateTime(2017, 1, 1)
                             orderby i.Name
                             select i).ToArray();

                if (files.Length > 0)
                {
                    writer.WriteLine("{0}:\n", rootDir.Name.ToUpper());

                    foreach (FileInfo item in files)
                    {
                        double size = item.Length / 1024.00 / 1024.00 / 1024.00;

                        if (size > 0.00)
                            writer.WriteLine("{0} ({1:n} GB)", item.Name, size);
                    }

                    writer.WriteLine();
                    writer.WriteLine();
                }

                foreach (DirectoryInfo item in rootDir.GetDirectories().Where(i => directoryExceptions.Contains(i.Name) == false))
                    GetMovieListWithHeader(item, writer);
            }
            catch
            {
            }
        }
    }
}
