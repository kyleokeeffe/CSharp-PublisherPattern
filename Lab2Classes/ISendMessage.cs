using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Classes
{
    public interface ISendMessage
    {
        //<summary>
        //Interface used for polymorphic reference to both classes of SendMessage objects
        public string AddressValue { get; set; }
    }
}
