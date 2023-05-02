using System;
using System.Threading.Tasks;

namespace Module._18.YoutubeDownloader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            

            Console.Write("Введи ссылку на видео: ");
            var url = Console.ReadLine();

            var sender = new CommandSender();
            var receiver = new YoutubeReceiver(url);

            ICommand command = new CommandOne(receiver);

            sender.SetCommand(command);

            Console.Write("1 - Скачать видео, 2 - Получить информацию. Что сделать?: ");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        await sender.DownloadVideoAsync();
                    }
                    break;
                case "2":
                    {
                        await sender.ShowVideoInfoAsync();
                    }
                    break;
                default:
                    Console.WriteLine("Нужно ввести 1 или 2!");
                    break;
                    
            }
        }
    }
}
