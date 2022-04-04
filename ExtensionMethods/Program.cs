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


            IEnumerable<int> numbers = new List<int>() { 1, 2, 3, 5, 2, 18 };
            var max = numbers.Max(); //look at th elist and return the biggest number
            

            Console.WriteLine(max);

        }
    }



}

/*
 
 So what Microsoft suggests in their guidelines is

use extension methods only when you really have to.

If you have the source code of the original class,

go ahead and change it there.

Otherwise, create a new type that derives from that class and add your new method there.

And if that doesn't work,

then go ahead and use extension method.

In practical terms in the real world,

most often you will be using extension methods instead of creating them.

 */