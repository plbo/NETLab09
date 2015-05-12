using Board.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Board.Service
{
    public class BoardService : IBoardService
    {
        private readonly IBoardService _repository;

        public BoardService()
        {
            Console.WriteLine("BoardService created");
            _repository = new BoardRepository();
        }

        public BoardInfo AddInfo(BoardInfo info)
        {
            Console.WriteLine("Adding info with title: {0}", info.Title);
            var added = _repository.AddInfo(info);
            Console.WriteLine("Added info with title: {0} on time {1}", info.Title, info.AddedOn);
            return added;
        }

        public IEnumerable<BoardInfo> GetContent()
        {
            Console.WriteLine("GetContent request recieved");
            var result = _repository.GetContent();
            Console.WriteLine("GetContent returns {0} of results", result.Count());
            return result;
        }
    }
}
