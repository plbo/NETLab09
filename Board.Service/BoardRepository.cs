using Board.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Board.Service
{
    public class BoardRepository : IBoardService
    {
        public static IBoardService Instance
        {
            get
            {
                return null;
            }
        }

        private readonly List<BoardInfo> _infos = new List<BoardInfo>();

        public BoardInfo AddInfo(BoardInfo info)
        {
            info.AddedOn = DateTime.Now;
            _infos.Add(info);            
            return info;
        }

        public IEnumerable<BoardInfo> GetContent()
        {
            return _infos.ToList();
        }

    }
}
