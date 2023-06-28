using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Classes
{
    public class MessageEventArgs:EventArgs
    {
        //<summary>
        //Class used to define event arguments for the passing message data between classes
        public string Message { get; set; }
        public MessageEventArgs(string mesg)
        {
            this.Message = mesg;
        }
    }
}
