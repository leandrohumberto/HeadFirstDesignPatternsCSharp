using System;

namespace Chapter08.WithHookTemplate
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override bool CustomerWantsCondiment()
        {
            var answer = GetUserInput();

            return answer == 'y' || answer == 'Y';
        }

        private char GetUserInput()
        {
            Console.Write("Would you like milk and sugar with your coffee (y/n)? ");
            var answer = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return answer;
        }
    }
}
