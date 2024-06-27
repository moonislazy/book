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
    public partial class book_not_return : Form
    {
        public book_not_return(string rno)
        {
            InitializeComponent();

            // 查询Rname
            string Rname = GetRnameFromDatabase(rno);
            if (Rname != null)
            {
                label2.Text = "读者 " + Rname + " 的未归还书籍";

                // 执行查询未归还书籍的操作，假设使用 book.Query 方法执行
                string sql = "Bnotreturn @Rno=" + rno;
                this.unreturnList.DataSource = book.Query(sql).Tables[0];
            }
            else
            {
                MessageBox.Show("未找到该读者信息！");
                this.Close(); // 关闭窗体或者执行其他逻辑
            }
        }

        private string GetRnameFromDatabase(string rno)
        {
            // 连接数据库查询Rname
            string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
            string Rname = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 查询Rname
                string sql = "SELECT Rname FROM Readers WHERE Rno = @Rno";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Rno", rno);

                // 执行查询
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Rname = reader["Rname"].ToString();
                }

                // 关闭数据库连接
                con.Close();
            }

            return Rname;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
