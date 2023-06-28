using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab2Classes
{
    public class SendViaSMS:ISendMessage
    {
        public string AddressValue { get; set; }
        public SendViaSMS(string sms)
        {
            this.AddressValue = sms;
        }

        public void SendSmsMessage(object sender, MessageEventArgs e)
        {
            MessageBox.Show($"Message sent to {this.AddressValue}: {e.Message}");
        }

        public bool Subscribe(Publisher pub)
        {
            //<summary>
            //Creates subscribe and unsubscribe actions for current object to publisher instance message event, 

            bool alreadySubd = Publisher.PublisherInstance.Subscriptions.Where<DelegateListItem>(x => x.AddressValue == this.AddressValue).Count<DelegateListItem>() > 0 ? true : false;
            if (!alreadySubd)
            {
                pub.Message += SendSmsMessage;
                Action sub = () => Publisher.PublisherInstance.Message += SendSmsMessage;
                Action unsub = () => Publisher.PublisherInstance.Message -= SendSmsMessage;
                Publisher.PublisherInstance.Subscriptions.Add(new DelegateListItem(this.AddressValue, sub, unsub));
                return true;
            }
            else 
                return false; 
        }

        public void Unsubscribe(Publisher pub)
        {
            pub.Message -= SendSmsMessage;
        }
    }
}
