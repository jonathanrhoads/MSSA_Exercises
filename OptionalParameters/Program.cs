/*
 * Syntactic sugar is when you use the syntax of the programming language to make writing code easier. 
 * Syntactic sugar can make code more human readable. Instead of writing out a for loop to find the 
 * total sum then dividing the sum by the amount of elements to get the average, I can just use LINQ 
 * to obtain that same result. Syntactic sugar doesn't make your program or code more faster. It doesn't
 * lower the time or space complexity. It's just easier for a human to mentally digest.
 * 
 */


using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            favoriteMusic("Rock", "Metallica", "Enter Sandman");
            favoriteMusic("Rock", "Metallica", "Metallica", "Enter Sandman");
        }
                
        // This is the optional parameter example.
        private static void favoriteMusic(string genre = "rock", string artist = "Metallica", string song = "Wherever I May Roam")
        {
            Console.WriteLine($"My favorite music genre is {genre}. My favorite song is {song} by {artist}.");
        }
                
        //// This is how the optional parameter example would look if it was just another overloaded method.
        //private static void favoriteMusic(string genre, string artist, string song)
        //{
        //    Console.WriteLine($"My favorite music genre is {genre}. My favorite song is {song} by {artist}.");
        //}
                
        private static void favoriteMusic(string genre, string artist, string album, string song)
        {
            Console.WriteLine($"My favorite music genre is {genre}. My favorite song is {song} on the {album} album. It is by {artist}.");
        }

    }
}
