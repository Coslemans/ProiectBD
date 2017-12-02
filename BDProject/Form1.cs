using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BDProject
{
    public partial class LogIn : Form
    {
        public static SqlConnection connection;
        public LogIn()
        {
            InitializeComponent();
            connection = new SqlConnection();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string Username = Username_Box.Text.ToString();
            string Password = Password_Box.Text.ToString();
            connection.ConnectionString = "Server=.;DataBase=Cabinet_Medical;Trusted_Connection=false;User=" + Username + ";Password=" + Password + ";";
            connection.Open();
            Console.WriteLine(connection.ServerVersion.ToString());
           // textBox1.AppendText(connection.ServerVersion.ToString());
            connection.Close();

            Hide();
            Form2 Test = new Form2();

        }
       
    }
}
