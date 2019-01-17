namespace SmartTV.Implementors
{
    class IptvService : IVideoSource
    {
        private readonly string _sourceName = "IPTV";

        string IVideoSource.GetTvGuide()
        {
            return $"Getting TV guide from - {_sourceName}";
        }

        string IVideoSource.PlayVideo()
        {
            return $"Playing - {_sourceName}";
        }
    }
