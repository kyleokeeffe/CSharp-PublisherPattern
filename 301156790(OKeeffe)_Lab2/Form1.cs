namespace _301156790_OKeeffe__Lab2
{
    public partial class Form1 : Form
    {
        private static Form1 formInstance;
        public static Form1 FormInstance
        {
            get
            {
                try
                {
                    if (formInstance == null)
                        Form1.CreateForm();
                    else
                        return formInstance;
                }
                catch (Exception e)
                {
                    MessageBox.Show("problem initizalizing form singleton instance");
                }
                return formInstance;
            }

            set
            {
                formInstance = value;
            }
        } 
        
        public Form1()
        {
            InitializeComponent();
        }

        private static void CreateForm()
        {
            //<summary>
            //Constructor used for singleton instance
            formInstance = new Form1();
        }

        private void btnManageNav_Click(object sender, EventArgs e)
        {
            //<summary>
            //Listener for Manage button. Create new manageSub window 
            Form manageSub = new ManageSub();
            manageSub.Show();
        }

        private void btnPublishNav_Click(object sender, EventArgs e)
        {
            //<summary>
            //Listener for Publish button. Creates new publishSub window.
            Form publishSub = new PublishSub();
            publishSub.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //<summary>
            //Exits the application
            Application.Exit();
        }
    }
}