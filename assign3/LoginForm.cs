using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign3
{
    public partial class LoginForm : Form
    {
        private static string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

        public LoginForm()
        {
            InitializeComponent();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\USER\\Desktop\\Algo\\download.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }
        private int remainingAttempts = 3;
        private void button1_Click(object sender, EventArgs e)
        {

            string uname = Username.Text.ToString();
            string pword = Password.Text.ToString();

            if (uname == "admin" && pword == "test123")
            {
                LogAction(uname, "Login success", "Main Screen");



                Form1 Form1 = new Form1();
                Form1.Show();
                this.Hide();
            }

            else
            {
                LogAction(uname, "Login Failed", "Login Screen");

                MessageBox.Show("Invalid credential, wrong username or password");
                remainingAttempts--;
                if (remainingAttempts <= 0)
                {
                    LogAction(uname, "Too many failed attempts", "Application will be aborted");

                    MessageBox.Show("Too many failed attempts. Application will be aborted.");
                    Application.Exit();
                }
            }
        }

        private void LogAction(string user, string action, string page)
        {
            string logEntry = $"{DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt")} {user} {action} {page}";

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(logEntry);
            }
        }
    }



}
