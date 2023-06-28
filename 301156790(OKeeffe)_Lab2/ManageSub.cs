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
    public partial class ManageSub : Form
    {
        public ManageSub()
        {
            InitializeComponent();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            //<summary>
            //Listener for subscribe button. 
            //Adds new ISendMessage objects to publisher instance
            //and triggers validation functions for entry fields
            if (chkEmail.Checked == true)
            {
                bool emailValid = Validator.ValidateEmail(txtEmail.Text);
                if (emailValid == true)
                {
                    SendViaEmail email = new SendViaEmail(txtEmail.Text);
                    lblEmailValidation.Visible = true;
                    if (email.Subscribe(Publisher.PublisherInstance))
                        lblEmailValidation.Text = "Subscription added: " + txtEmail.Text ;
                    else
                        lblEmailValidation.Text = "Subscription already present: " + txtEmail.Text;
                }
                else
                {
                    lblEmailValidation.Visible = true;
                    lblEmailValidation.Text = "Please check email format.";
                }
            }

            if (chkSms.Checked == true)
            {
                bool smsValid = Validator.ValidatePhone(txtSMS.Text);
                if (smsValid == true)
                {
                    SendViaSMS sms = new SendViaSMS(txtSMS.Text);
                    lblSMSValidation.Visible = true;
                    if (sms.Subscribe(Publisher.PublisherInstance))
                        lblSMSValidation.Text = "Subscription added: " + txtSMS.Text;
                    else
                        lblSMSValidation.Text = "Subscription already present: " + txtSMS.Text;
                }
                else
                {
                    lblSMSValidation.Visible = true;
                    lblSMSValidation.Text = "Please check telephone format.";
                }
            }
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            //<summary>
            //Listener for Unsubscribe button
            //Triggers unsubscribe function on publisher instance, and performs basic field validation. 
            if (chkEmail.Checked == true)
            {
                if (txtEmail.Text != null)
                {
                    if (Publisher.PublisherInstance.PerformUnsubscribe(txtEmail.Text))
                    {
                        lblEmailValidation.Visible = true;
                        lblEmailValidation.Text = "Unsubscribe completed: " + txtEmail.Text;
                    }
                    else
                    {
                        lblEmailValidation.Visible = true;
                        lblEmailValidation.Text = "Subscription not found: " + txtEmail.Text;
                    }
                }
            }
          
            if (chkSms.Checked == true)
            {
                if (txtSMS.Text != null)
                {
                    if (Publisher.PublisherInstance.PerformUnsubscribe(txtSMS.Text))
                    {
                        lblSMSValidation.Visible = true;
                        lblSMSValidation.Text = "Unsubscribe completed: " + txtSMS.Text;
                    }
                    else
                    {
                        lblSMSValidation.Visible = true;
                        lblSMSValidation.Text = "Subscription not found: " + txtSMS.Text;
                    }
                }
            }
        }

        private void btnManageCancel_Click(object sender, EventArgs e)
        {
            //<summary>
            //Listener for Manage button. Closes current windo, shows main window
            Form1.FormInstance.Show();
            this.Close();
        }

        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {
            //<summary>
            //Listener for when check buttons are altered. Clears field values and hides error field
            if (chkEmail.Checked == false)
            {
                lblEmailValidation.Visible = false;
                lblEmailValidation.Text = "";
                txtEmail.Text = "";
            }
        }

        private void chkSms_CheckedChanged(object sender, EventArgs e)
        {
            //<summary>
            //Listener for when check buttons are altered. Clears field values and hides error field
            if (chkEmail.Checked == false)
            {
                lblSMSValidation.Visible = false;
                lblSMSValidation.Text = "";
                txtSMS.Text = "";
            }
        }
    }
}
