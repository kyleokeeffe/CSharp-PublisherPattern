using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Classes
{
    public class Publisher
    {
        public List<DelegateListItem> EmailSubscriptions = new List<DelegateListItem>();            
            
        public List<DelegateListItem> SmsSubscriptions = new List<DelegateListItem>();
        public List<DelegateListItem> Subscriptions = new List<DelegateListItem>();

        private static Publisher publisherInstance;

        public static Publisher PublisherInstance
        {
            //<summary>
            //Singleton instance of publisher class
            get
            {
                try
                {
                    if (publisherInstance == null)
                        Publisher.CreatePublisherInstance();
                    else
                        return publisherInstance;
                }catch(Exception e)
                {
                    Console.WriteLine("Problem initializing publish instance");
                }
                return publisherInstance;
            }
            set
            {
                publisherInstance = value;
            }
        }
        public event EventHandler<MessageEventArgs> Message;
      
        private static void CreatePublisherInstance()
        {
            publisherInstance = new Publisher();
        }

        public bool IsAddressInSubscription(string value)
        {
            //<summary>
            //Iterates through obejcts subscribed to publisher message event
            Delegate[] delegates;
            if (Message != null)
                delegates = Message.GetInvocationList();
            else
                return false;

            foreach (var dele in delegates)
            {
                var delMessageType = (ISendMessage)dele.Target;
                if (delMessageType.AddressValue == value)
                    return true;
            }
            return false;
        }

        public void PublishMessage(string mesg)
        {
            Message.Invoke(this, new MessageEventArgs(mesg));
        }

        public  bool PerformUnsubscribe(string text)
        {
            //<summary>
            //Performs unsubscribe if address is in the list of subscribed obejcts
            if (IsAddressInSubscription(text))
            {
                try
                {
                    DelegateListItem listItem = Publisher.PublisherInstance.Subscriptions.Where<DelegateListItem>(x => x.AddressValue == text).Select(x=>x).First();
                    Action address = listItem.UnsubscribeItem.DelegateAction;
                    address.Invoke();
                    PublisherInstance.Subscriptions.Remove(listItem);
                    return true;
                } catch (Exception e)
                {
                    return false;
                }
            }
            else
                return false;
        }
    }
}
