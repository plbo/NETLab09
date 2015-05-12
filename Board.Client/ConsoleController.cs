using Board.Contract;
using System;
using System.Linq;

namespace Board.Client
{
    public class ConsoleController
    {
        private readonly IBoardService _boardService;

        public ConsoleController(IBoardService boardService)
        {
            if (boardService == null)
            {
                throw new ArgumentNullException("boardService", "service cannot be null");
            }

            _boardService = boardService;
        }

        public void Run()
        {
            var isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Type A to add board info, C see board content, Q to quit");
                var c = Console.ReadLine();

                switch (c.ToUpper())
                {
                    case "A":
                        AddNewInfo();
                        break;
                    case "C":
                        SeeBoardContent();
                        break;
                    case "Q":
                        isRunning = false;
                        break; 
                    default:
                        Console.WriteLine("Undefined command");
                        break;
                }

            }
        }

        private void SeeBoardContent()
        {
            Console.WriteLine("Calling service to get board content");
            var content = _boardService.GetContent();

            if (content != null && content.Any())
            {
                foreach (var info in content)
                {
                    Console.WriteLine("Added on: {0}", info.AddedOn);
                    Console.WriteLine("Title: {0}", info.Title);
                    Console.WriteLine("Content: {0}", info.Content);
                    Console.WriteLine("EOM");
                }
            }
            else
            {
                Console.WriteLine("Board is empty");
            }
        }

        private void AddNewInfo()
        {
            Console.WriteLine("Adding new information to the board");
            Console.Write("Enter title:");
            var title = Console.ReadLine();
            Console.Write("Enter content:");
            var content = Console.ReadLine();
            var info = new BoardInfo { Content = content, Title = title };
            Console.WriteLine("Calling service to add board content");
            var resultInfo = _boardService.AddInfo(info);
            Console.WriteLine("Entry added on {0}", resultInfo.AddedOn);
        }
    }
}
