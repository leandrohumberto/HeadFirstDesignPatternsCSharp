using SmartTV.Abstractions;
using SmartTV.Implementors;
using System;

namespace SmartTV
{
    /// <summary>
    /// https://www.codeproject.com/Articles/434352/Understanding-and-Implementing-Bridge-Pattern-in-C 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            SuperSmartTV myTv = new SuperSmartTV();

            Console.WriteLine("Select A source to get TV Guide and Play");
            Console.WriteLine("1. Local Cable TV\n2. Local Dish TV\n3. IP TV");

            ConsoleKeyInfo input = Console.ReadKey();

            // Let us see what user has selected and select the video source accrodingly
            switch (input.KeyChar)
            {
                case '1':
                    myTv.VideoSource = new LocalCableTV();
                    break;

                case '2':
                    myTv.VideoSource = new LocalDishTv();
                    break;

                case '3':
                    myTv.VideoSource = new IptvService();
                    break;
            }

            Console.WriteLine(); //some whitespace on output for readability

            //Let us show the TV guide from selected source
            myTv.ShowTvGuide();

            //Let us now play the selected TV source.
            myTv.PlayTV();

            Console.WriteLine(); //some whitespace on output for readability
        }
    }
}
