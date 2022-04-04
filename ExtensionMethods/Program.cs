// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace ExtensionMethods // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "This is a long post.";
            var shortenedPost = post.Shorten(5);

        }
    }



}