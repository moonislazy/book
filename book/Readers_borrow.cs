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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace book
{
    public partial class Readers_borrow : Form
    {
        private int rno;  // 读者编号

        public Readers_borrow(int rno)
        {
            InitializeComponent();
            this.rno = rno;
        }

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = textBox1.Text;
            string sql = "SELECT * FROM Book WHERE Bno = @isbn";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@isbn", isbn);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // 显示书籍信息
                    string bookInfo = $"书名: {reader["Bname"]}\n出版社: {reader["Bpublish"]}\n作者: {reader["Bauthor"]}\n总数量: {reader["Bsum"]}\n剩余数量: {reader["Bleft"]}";
                    MessageBox.Show(bookInfo, "书籍信息");
                }
                else
                {
                    MessageBox.Show("书籍不存在！");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bno = textBox1.Text;
            string sql0 = "SELECT Rno FROM Readers WHERE Rno = @rno";
            string sql1 = "EXEC count_fine @Rno = @rno";
            string sql2 = "SELECT Rno FROM Readers WHERE Rcan > Rborrow AND Rno = @rno";
            string sql3 = "SELECT Rno FROM Borrow WHERE Rno = @rno AND Returntime IS NULL AND DATEADD(day, Borrowperiod, Borrowtime) < GETDATE()";
            string sql4 = "SELECT Bno FROM Book WHERE Bleft > 0 AND Bno = @bno";
            string sql4_1 = "SELECT * FROM Borrow WHERE Bno = @bno AND Rno = @rno AND Returntime IS NULL";

            int wrong = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (!RecordExists(connection, sql0, new SqlParameter("@rno", rno)))
                {
                    MessageBox.Show("读者不存在！");
                    wrong++;
                }
                else
                {
                    if (GetFine(connection, sql1, new SqlParameter("@rno", rno)) > 0)
                    {
                        MessageBox.Show("罚款未缴纳！");
                        wrong++;
                    }
                    if (!RecordExists(connection, sql2, new SqlParameter("@rno", rno)))
                    {
                        MessageBox.Show("可借书籍已达上限！");
                        wrong++;
                    }
                    if (RecordExists(connection, sql3, new SqlParameter("@rno", rno)))
                    {
                        MessageBox.Show("存在逾期未还图书！");
                        wrong++;
                    }
                    if (!RecordExists(connection, sql4, new SqlParameter("@bno", bno)))
                    {
                        MessageBox.Show("图书不可借阅！");
                        wrong++;
                    }
                    if (RecordExists(connection, sql4_1, new SqlParameter("@bno", bno), new SqlParameter("@rno", rno)))
                    {
                        MessageBox.Show("该书借阅未还！");
                        wrong++;
                    }
                }

                if (wrong == 0)
                {
                    string sql = "INSERT INTO Borrow VALUES(@rno, @bno, GETDATE(), 30, NULL, 0, 0)";
                    ExecuteNonQuery(connection, sql, new SqlParameter("@rno", rno), new SqlParameter("@bno", bno));

                    // 更新 Book 表中的 Bleft 字段
                    string updateBleftSql = "UPDATE Book SET Bleft = Bleft - 1 WHERE Bno = @bno";
                    ExecuteNonQuery(connection, updateBleftSql, new SqlParameter("@bno", bno));

                    MessageBox.Show("借阅成功！");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bno = textBox1.Text;
            string sql = "UPDATE Borrow SET Returntime = GETDATE() WHERE Rno = @rno AND Bno = @bno AND Returntime IS NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                ExecuteNonQuery(connection, sql, new SqlParameter("@rno", rno), new SqlParameter("@bno", bno));

                // 更新 Book 表中的 Bleft 字段
                string updateBleftSql = "UPDATE Book SET Bleft = Bleft + 1 WHERE Bno = @bno";
                ExecuteNonQuery(connection, updateBleftSql, new SqlParameter("@bno", bno));

                MessageBox.Show("还书成功！");
            }
        }

        private bool RecordExists(SqlConnection connection, string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddRange(parameters);
            return command.ExecuteScalar() != null;
        }

        private double GetFine(SqlConnection connection, string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddRange(parameters);
            var result = command.ExecuteScalar();
            return result != DBNull.Value ? Convert.ToDouble(result) : 0;
        }

        private void ExecuteNonQuery(SqlConnection connection, string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddRange(parameters);
            command.ExecuteNonQuery();
        }
    }
}
