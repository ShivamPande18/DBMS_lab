namespace Notepad
{
    public partial class Form1 : Form
    {
        string user = "shivam";
        string pass = "pande";
        public Form1()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            if (username.Text == user && password.Text == pass)
            {
                Form2 frm = new Form2();
                frm.Show();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void change_Click(object sender, EventArgs e)
        {
            if(newPass.Text!="")
            {
                pass = newPass.Text;
                newPass.Text = "";
            }
        }
    }
}
