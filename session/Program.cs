using System;

namespace session
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string songLyrics = "You say greetings, and I say hello";

            var result = songLyrics.Contains("goodbey");
            Console.WriteLine(result);

            Console.WriteLine(songLyrics.Contains("greetings"));
        }
    }
}
