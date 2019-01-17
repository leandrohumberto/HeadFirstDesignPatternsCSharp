using BuilderExamples.Directors;
using System;

namespace BuilderExamples
{
    /// <summary>
    /// <see cref="http://blogs.tedneward.com/patterns/Builder-CSharp/"/>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            Console.WriteLine("Director.Construct():");
            var product = director.Construct();
            product.Parts.ForEach((part) => Console.WriteLine(part));
            Console.WriteLine();

            Console.WriteLine("Director.ConstructFluently():");
            product = director.ConstructFluently();
            product.Parts.ForEach((part) => Console.WriteLine(part));
            Console.WriteLine();

            Console.WriteLine("Director.ContructFluentlyFunc():");
            product = director.ContructFluentlyFunc();
            product.Parts.ForEach((part) => Console.WriteLine(part));
            Console.WriteLine();

            Console.WriteLine("Director.ContructFluentlyComposeFunc():");
            product = director.ContructFluentlyComposeFunc();
            product.Parts.ForEach((part) => Console.WriteLine(part));
            Console.WriteLine();

            Console.WriteLine("Director.ContructFluentlyGuarded():");
            product = director.ContructFluentlyGuarded();
            product.Parts.ForEach((part) => Console.WriteLine(part));
            Console.WriteLine();
        }
    }
}
