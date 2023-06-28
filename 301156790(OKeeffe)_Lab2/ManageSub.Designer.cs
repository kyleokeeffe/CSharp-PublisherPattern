namespace _301156790_OKeeffe__Lab2
{
    partial class ManageSub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkSms = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.lblSMSValidation = new System.Windows.Forms.Label();
            this.lblEmailValidation = new System.Windows.Forms.Label();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.btnManageCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(227, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 176);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkSms);
            this.splitContainer1.Panel1.Controls.Add(this.chkEmail);
           // this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblSMSValidation);
            this.splitContainer1.Panel2.Controls.Add(this.lblEmailValidation);
            this.splitContainer1.Panel2.Controls.Add(this.txtSMS);
            this.splitContainer1.Panel2.Controls.Add(this.txtEmail);
            this.splitContainer1.Size = new System.Drawing.Size(515, 176);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkSms
            // 
            this.chkSms.AutoSize = true;
            this.chkSms.Location = new System.Drawing.Point(28, 96);
            this.chkSms.Name = "chkSms";
            this.chkSms.Size = new System.Drawing.Size(190, 24);
            this.chkSms.TabIndex = 1;
            this.chkSms.Text = "Notification sent by sms";
            this.chkSms.UseVisualStyleBackColor = true;
            this.chkSms.CheckedChanged += new System.EventHandler(this.chkSms_CheckedChanged);
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(29, 27);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(202, 24);
            this.chkEmail.TabIndex = 0;
            this.chkEmail.Text = "Notification sent by email";
            this.chkEmail.UseVisualStyleBackColor = true;
            this.chkEmail.CheckedChanged += new System.EventHandler(this.chkEmail_CheckedChanged);
            // 
            // lblSMSValidation
            // 
            this.lblSMSValidation.AutoSize = true;
            this.lblSMSValidation.Location = new System.Drawing.Point(12, 126);
            this.lblSMSValidation.Name = "lblSMSValidation";
            this.lblSMSValidation.Size = new System.Drawing.Size(50, 20);
            this.lblSMSValidation.TabIndex = 3;
            this.lblSMSValidation.Text = "label2";
            this.lblSMSValidation.Visible = false;
            // 
            // lblEmailValidation
            // 
            this.lblEmailValidation.AutoSize = true;
            this.lblEmailValidation.Location = new System.Drawing.Point(12, 54);
            this.lblEmailValidation.Name = "lblEmailValidation";
            this.lblEmailValidation.Size = new System.Drawing.Size(50, 20);
            this.lblEmailValidation.TabIndex = 2;
            this.lblEmailValidation.Text = "label1";
            this.lblEmailValidation.Visible = false;
            // 
            // txtSMS
            // 
            this.txtSMS.Location = new System.Drawing.Point(12, 96);
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(125, 27);
            this.txtSMS.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 24);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 27);
            this.txtEmail.TabIndex = 0;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(227, 321);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(94, 29);
            this.btnSubscribe.TabIndex = 1;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Location = new System.Drawing.Point(400, 321);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(111, 29);
            this.btnUnsubscribe.TabIndex = 2;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
            // 
            // btnManageCancel
            // 
            this.btnManageCancel.Location = new System.Drawing.Point(561, 321);
            this.btnManageCancel.Name = "btnManageCancel";
            this.btnManageCancel.Size = new System.Drawing.Size(94, 29);
            this.btnManageCancel.TabIndex = 3;
            this.btnManageCancel.Text = "Cancel";
            this.btnManageCancel.UseVisualStyleBackColor = true;
            this.btnManageCancel.Click += new System.EventHandler(this.btnManageCancel_Click);
            // 
            // ManageSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageCancel);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.panel1);
            this.Name = "ManageSub";
            this.Text = "ManageSub";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private CheckBox chkSms;
        private CheckBox chkEmail;
        private Label lblSMSValidation;
        private Label lblEmailValidation;
        private TextBox txtSMS;
        private TextBox txtEmail;
        private Button btnSubscribe;
        private Button btnUnsubscribe;
        private Button btnManageCancel;
    }
}