namespace SmartTV.Implementors
{
    public class LocalCableTV : IVideoSource
    {
        private readonly string _sourceName = "Local Cable TV";

        string IVideoSource.GetTvGuide()
        {
            return $"Getting TV guide from - {_sourceName}";
        }

        string IVideoSource.PlayVideo()
        {
            return $"Playing - {_sourceName}";
        }
    }
}
