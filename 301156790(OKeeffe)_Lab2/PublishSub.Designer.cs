namespace _301156790_OKeeffe__Lab2
{
    partial class PublishSub
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
            this.lblPublishError = new System.Windows.Forms.Label();
            this.txtNotifCont = new System.Windows.Forms.TextBox();
            this.lblNotifCont = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnPublishExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPublishError);
            this.panel1.Controls.Add(this.txtNotifCont);
            this.panel1.Controls.Add(this.lblNotifCont);
            this.panel1.Location = new System.Drawing.Point(159, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 125);
            this.panel1.TabIndex = 0;
            // 
            // lblPublishError
            // 
            this.lblPublishError.AutoSize = true;
            this.lblPublishError.Location = new System.Drawing.Point(224, 77);
            this.lblPublishError.Name = "lblPublishError";
            this.lblPublishError.Size = new System.Drawing.Size(50, 20);
            this.lblPublishError.TabIndex = 2;
            this.lblPublishError.Text = "label1";
            this.lblPublishError.Visible = false;
            // 
            // txtNotifCont
            // 
            this.txtNotifCont.Location = new System.Drawing.Point(224, 47);
            this.txtNotifCont.Name = "txtNotifCont";
            this.txtNotifCont.Size = new System.Drawing.Size(125, 27);
            this.txtNotifCont.TabIndex = 1;
            // 
            // lblNotifCont
            // 
            this.lblNotifCont.AutoSize = true;
            this.lblNotifCont.Location = new System.Drawing.Point(32, 47);
            this.lblNotifCont.Name = "lblNotifCont";
            this.lblNotifCont.Size = new System.Drawing.Size(144, 20);
            this.lblNotifCont.TabIndex = 0;
            this.lblNotifCont.Text = "Notification Content";
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(251, 323);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(94, 29);
            this.btnPublish.TabIndex = 1;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnPublishExit
            // 
            this.btnPublishExit.Location = new System.Drawing.Point(414, 323);
            this.btnPublishExit.Name = "btnPublishExit";
            this.btnPublishExit.Size = new System.Drawing.Size(94, 29);
            this.btnPublishExit.TabIndex = 2;
            this.btnPublishExit.Text = "Exit";
            this.btnPublishExit.UseVisualStyleBackColor = true;
            this.btnPublishExit.Click += new System.EventHandler(this.btnPublishExit_Click);
            // 
            // PublishSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPublishExit);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.panel1);
            this.Name = "PublishSub";
            this.Text = "PublishSub";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtNotifCont;
        private Label lblNotifCont;
        private Button btnPublish;
        private Button btnPublishExit;
        private Label lblPublishError;
    }
}