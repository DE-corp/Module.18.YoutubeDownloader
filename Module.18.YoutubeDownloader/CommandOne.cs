using System;
using System.Threading.Tasks;

namespace Module._18.YoutubeDownloader
{
    class CommandOne : ICommand
    {
        private YoutubeReceiver _receiver;

        public CommandOne(YoutubeReceiver receiver)
        {
            _receiver = receiver;
        }

        public async Task DownloadVideo()
        {
            Console.WriteLine("Команда скачивания видео отправлена");
            await _receiver.Download();
        }

        public async Task ShowVideoInfoAsync()
        {
            Console.WriteLine("Команда получения информации отправлена");
            await _receiver.ShowInfo();
        }

    }
}
