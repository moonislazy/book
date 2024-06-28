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
            UpdateFine(); // 在初始化表单数据时更新罚款信息
        }

        // 更新罚款信息方法
        private void UpdateFine()
        {
            try
            {
                // 连接数据库
                string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // 调用存储过程 GetBorrowInfo 更新罚款信息
                    SqlCommand cmd = new SqlCommand("GetBorrowInfo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Rno", Rno);

                    // 执行存储过程
                    cmd.ExecuteNonQuery();

                    // 关闭数据库连接
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新罚款信息时出错：" + ex.Message);
            }
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
                reader.Close();
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
            Readers_myinfo childrenForm = new Readers_myinfo(Rno);
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // 图片点击事件处理
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 图片点击事件处理
        }

        private void Readers_Load(object sender, EventArgs e)
        {
            // 窗体加载时执行的操作
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 借书按钮点击事件处理
            Readers_borrow borrowForm = new Readers_borrow(int.Parse(Rno));
            borrowForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 缴费按钮点击事件处理
            string rno = Rno; // 获取当前读者的编号

            // 连接数据库
            string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 调用存储过程 count_fine 计算罚款
                string sql = "count_fine @Rno=" + rno;
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Rno", rno);

                // 执行查询并获取罚款金额
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    double fine = Convert.ToDouble(reader[0]);

                    if (fine > 0)
                    {
                        // 显示罚款信息
                        DialogResult result = MessageBox.Show("本次共需缴纳罚款 " + fine + " 元。是否确认缴费？", "缴费确认", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            reader.Close();

                            // 更新相关记录，将 Pay 标记为1
                            string updateSql = "UPDATE Borrow SET Pay = 1 WHERE Rno = @Rno AND Fine > 0 AND Pay = 0";
                            SqlCommand updateCmd = new SqlCommand(updateSql, con);
                            updateCmd.Parameters.AddWithValue("@Rno", rno);
                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("缴费成功！");
                            }
                            else
                            {
                                MessageBox.Show("缴费失败，请重试！");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("没有需要缴纳的罚款。");
                    }
                }
                else
                {
                    MessageBox.Show("未找到该读者的罚款信息！");
                }

                reader.Close();
                con.Close();
            }
        }
    }
}
