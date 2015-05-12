using System.Collections.Generic;
using System.ServiceModel;

namespace Board.Contract
{
    public interface IBoardService
    {
        BoardInfo AddInfo(BoardInfo info);

     
        IEnumerable<BoardInfo> GetContent();
    }
}
