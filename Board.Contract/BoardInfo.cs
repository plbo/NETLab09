using System;
using System.Runtime.Serialization;

namespace Board.Contract
{
    
    public class BoardInfo
    {
        
        public string Title { get; set; }
        
        public string Content { get; set; }
        
        public DateTime AddedOn { get; set; }
    }
}
