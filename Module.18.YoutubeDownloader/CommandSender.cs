using System.Threading.Tasks;

namespace Module._18.YoutubeDownloader
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class CommandSender
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public async Task ShowVideoInfoAsync()
        {
            await _command.ShowVideoInfoAsync();
        }

        public async Task DownloadVideoAsync()
        {
            await _command.DownloadVideo();
        }
    }
}
