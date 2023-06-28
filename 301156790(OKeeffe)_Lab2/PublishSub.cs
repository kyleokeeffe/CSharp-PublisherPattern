using Lab2Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301156790_OKeeffe__Lab2
{
    public partial class PublishSub : Form
    {
        public static PublishSub publishSub {get;set;}
        public PublishSub()
        {
            InitializeComponent();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            //<summary>
            //Listener method for publish button.
            //-Triggers publishing of subscriptions. 
            //-Provides basic field validation
            if (txtNotifCont.Text != null)
            {
                Publisher.PublisherInstance.PublishMessage(txtNotifCont.Text); //get all the items subscribed to the delegate and trigger them 
                lblPublishError.Text = "Message sent: "+ txtNotifCont.Text;
                lblPublishError.Visible = true;
            }
            else
            {
                lblPublishError.Text = "Please enter a message to publish";
                lblPublishError.Visible = true;
            }
        }

        private void btnPublishExit_Click(object sender, EventArgs e)
        {
            //<summary>
            //Listener for Exit button
            //-Closes window, returns to main window
            Form1.FormInstance.Show();
            this.Close();
        }
    }
}
