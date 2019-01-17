using SmartTV.Implementors;
using System;

namespace SmartTV.Abstractions
{
    public class SuperSmartTV
    {
        public IVideoSource VideoSource { get; set; }

        public void ShowTvGuide()
        {
            if (VideoSource != null)
            {
                Console.WriteLine(VideoSource.GetTvGuide());
            }
            else
            {
                Console.WriteLine("Please select a video source to get the guide from");
            }
        }

        public void PlayTV()
        {
            if (VideoSource != null)
            {
                Console.WriteLine(VideoSource.PlayVideo());
            }
            else
            {
                Console.WriteLine("Please select a video source to play");
            }
        }
    }
}
