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
    public partial class Readers_overtime : Form
    {
        public Readers_overtime(string rno)
        {
            InitializeComponent();

            // 查询逾期书籍
            string sql = "Readersovertime";

            // 使用参数化查询防止SQL注入
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Rno", SqlDbType.Int) { Value = int.Parse(rno) }
            };

            // 使用存储过程执行查询
            DataTable dt = ExecuteStoredProcedure(sql, parameters).Tables[0];

            // 设置标签文本
            label2.Text = "读者 " + GetRnameFromDatabase(rno) + " 的逾期书籍";

            // 将查询结果放入 DataSource
            this.overtimeList.DataSource = dt;
        }

        private DataSet ExecuteStoredProcedure(string storedProcName, SqlParameter[] parameters)
        {
            string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(storedProcName, con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                }

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
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


    }
}
