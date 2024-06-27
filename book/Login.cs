using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace book
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];


        private void btn_login_Click(object sender, EventArgs e)
        {
            string account = this.txt_account.Text;
            string passwd = this.txt_passwd.Text;

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(passwd))
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            // Query to check if the account and password match for a manager
            string sqlManager = "SELECT * FROM login WHERE account = @account AND passwd = @passwd AND permission = 1";
            SqlCommand cmdManager = new SqlCommand(sqlManager, con);
            cmdManager.Parameters.AddWithValue("@account", account);
            cmdManager.Parameters.AddWithValue("@passwd", passwd);

            SqlDataReader readerManager = cmdManager.ExecuteReader();
            if (readerManager.HasRows)
            {
                readerManager.Close();
                manage m = new manage(account);
                m.Show();
                this.Hide();
                con.Close();
                return;
            }
            readerManager.Close();

            // Query to check if the account and password match for a reader
            string sqlReader = "SELECT * FROM login WHERE account = @account AND passwd = @passwd AND permission = 0";
            SqlCommand cmdReader = new SqlCommand(sqlReader, con);
            cmdReader.Parameters.AddWithValue("@account", account);
            cmdReader.Parameters.AddWithValue("@passwd", passwd);

            SqlDataReader readerReader = cmdReader.ExecuteReader();
            if (readerReader.HasRows)
            {
                readerReader.Close();
                Readers readers = new Readers(account);
                readers.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }

            con.Close();
        }



    }
}
