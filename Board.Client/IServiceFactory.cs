using System;
using Board.Contract;

namespace Board.Client
{
    public interface IServiceFactory
    {
        IBoardService GetService();
    }
}
