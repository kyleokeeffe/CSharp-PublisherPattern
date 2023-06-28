namespace _301156790_OKeeffe__Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManageNav = new System.Windows.Forms.Button();
            this.btnPublishNav = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageNav
            // 
            this.btnManageNav.Location = new System.Drawing.Point(3, 3);
            this.btnManageNav.Name = "btnManageNav";
            this.btnManageNav.Size = new System.Drawing.Size(94, 29);
            this.btnManageNav.TabIndex = 0;
            this.btnManageNav.Text = "Manage Subscriptions";
            this.btnManageNav.UseVisualStyleBackColor = true;
            this.btnManageNav.Click += new System.EventHandler(this.btnManageNav_Click);
            // 
            // btnPublishNav
            // 
            this.btnPublishNav.Location = new System.Drawing.Point(103, 3);
            this.btnPublishNav.Name = "btnPublishNav";
            this.btnPublishNav.Size = new System.Drawing.Size(94, 29);
            this.btnPublishNav.TabIndex = 1;
            this.btnPublishNav.Text = "Publish Subscription";
            this.btnPublishNav.UseVisualStyleBackColor = true;
            this.btnPublishNav.Click += new System.EventHandler(this.btnPublishNav_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(203, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnManageNav);
            this.flowLayoutPanel1.Controls.Add(this.btnPublishNav);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(245, 151);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 54);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnManageNav;
        private Button btnPublishNav;
        private Button btnExit;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}