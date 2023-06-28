using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab2Classes
{
    public class SendViaEmail : ISendMessage
    {
        public string AddressValue { get; set; }
        public SendViaEmail(string email)
        {
            this.AddressValue = email;
        }

        public void SendEmailMessage(object sender, MessageEventArgs e)
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
                pub.Message += SendEmailMessage;
                Action sub = () => Publisher.PublisherInstance.Message += SendEmailMessage;
                Action unsub = () => Publisher.PublisherInstance.Message -= SendEmailMessage;
                Publisher.PublisherInstance.Subscriptions.Add(new DelegateListItem(this.AddressValue, sub, unsub));
                return true;
            }
            else
                return false;
        }

        public void Unsubscribe(Publisher pub)
        {
            pub.Message -= SendEmailMessage;
        }
    }
}

