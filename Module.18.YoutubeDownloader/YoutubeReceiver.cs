using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Module._18.YoutubeDownloader
{
    /// <summary>
    /// Адресат команды
    /// </summary>
    class YoutubeReceiver
    {
        private YoutubeClient _youtube;
        private string _url;

        public YoutubeReceiver(string url)
        {
            _url = url;
            _youtube = new YoutubeClient();
        }

        public async Task Download()
        {
            var info = await _youtube.Videos.GetAsync(_url);
            var streamManifest = await _youtube.Videos.Streams.GetManifestAsync(_url);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await _youtube.Videos.Streams.DownloadAsync(streamInfo, $"{info.Title}.{streamInfo.Container}");
            Console.WriteLine("Видео загружено!");

        }

        public async Task ShowInfo()
        {
            var info = await _youtube.Videos.GetAsync(_url);
            Console.WriteLine("ИНФОРМАЦИЯ\n");
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------\n");
            Console.WriteLine($"Название видео: {info.Title}");
            Console.WriteLine($"Автор: {info.Author}");
            Console.WriteLine($"Описание: {info.Description}");
            Console.WriteLine($"Длительность: {info.Duration}");
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------\n");

        }
    }
}
