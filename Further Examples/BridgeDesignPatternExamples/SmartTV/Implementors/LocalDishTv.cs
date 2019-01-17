namespace SmartTV.Implementors
{
    public class LocalDishTv : IVideoSource
    {
        private readonly string _sourceName = "Local DISH TV";

        public string GetTvGuide()
        {
            return $"Getting TV guide from - {_sourceName}";
        }

        public string PlayVideo()
        {
            return $"Playing - {_sourceName}";
        }
    }
}
