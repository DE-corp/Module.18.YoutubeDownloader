using System.Threading.Tasks;

namespace Module._18.YoutubeDownloader
{
    /// <summary>
    /// Базовый интерфейс команды
    /// </summary>
    public interface ICommand
    {
        // Обьявил тело метода, потому что иначе ругается
        public async Task DownloadVideo() { }
        public async Task ShowVideoInfoAsync() { }
    }
}
