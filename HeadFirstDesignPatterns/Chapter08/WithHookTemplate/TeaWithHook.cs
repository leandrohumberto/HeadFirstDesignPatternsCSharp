using System;

namespace Chapter08.WithHookTemplate
{
    class TeaWithHook : CaffeineBeverageWithHook
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override bool CustomerWantsCondiment()
        {
            var answer = GetUserInput();

            return answer == 'y' || answer == 'Y';
        }

        private char GetUserInput()
        {
            Console.Write("Would you like lemon with your tea (y/n)? ");
            var answer = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return answer;
        }
    }
}
