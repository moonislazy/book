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

namespace book
{
    public partial class Readers : Form
    {
        private string Rno;
        private string Rname;

        public Readers(string rno)
        {
            InitializeComponent();
            Rno = rno;
            InitializeFormData();
        }

        private void InitializeFormData()
        {
            // 连接数据库
            string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 查询Rname
                string sql = "SELECT Rname FROM Readers WHERE Rno = @Rno";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Rno", Rno);

                // 执行查询
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Rname = reader["Rname"].ToString();
                    label2.Text = "读者 " + Rname + " ，欢迎你！";
                }
                else
                {
                    MessageBox.Show("未找到该读者信息！请联系图书馆管理员修复数据库！");
                }

                // 关闭数据库连接
                con.Close();
            }
        }

        //查看当前借阅
        private void btn_my_unreturn_Click(object sender, EventArgs e)
        {
            book_not_return childrenForm = new book_not_return(Rno);
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        //搜书
        private void btn_borrow_find_Click(object sender, EventArgs e)
        {
            Readers_bookfind childrenForm = new Readers_bookfind();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        //查看逾期图书
        private void button1_Click(object sender, EventArgs e)
        {
            Readers_overtime childrenForm = new Readers_overtime(Rno);
            childrenForm.Owner = this;  
            childrenForm.Show();  
        }

        //查看读者本人信息
        private void btn_readers_Click(object sender, EventArgs e)
        {
            Readers_myinfo childrenForm=new Readers_myinfo(Rno); 
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Readers_Load(object sender, EventArgs e)
        {

        }
    }
}
