using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Classes
{
    public class DelegateListItem
    {
        //<summary>
        //Class used to store subscribe and unsubscribe actions for each ISendMessage object.
        public string AddressValue { get; set; }
        public ActionItem SubscribeItem { get; set; }
        public ActionItem UnsubscribeItem { get; set; }

        public DelegateListItem(string addressValue, Action subscribeAction,Action unsubscribeAction)
        {
            AddressValue = addressValue;
            SubscribeItem = new ActionItem("Subscribe", subscribeAction);
            UnsubscribeItem = new ActionItem("Unsubscribe", unsubscribeAction);
        }

        public class ActionItem
        {
            public string DelegateType { get; set; }
            public Action DelegateAction { get; set; }
            public ActionItem(string delegateType, Action delegateAction)
            {
                DelegateType = delegateType;
                DelegateAction = delegateAction;
            }
        }
    }
}
