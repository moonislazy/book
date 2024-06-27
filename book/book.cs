using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book
{
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public static DataSet Query(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds, "Book");
                return ds;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sda.Dispose();
                con.Close();
            }
        }

        public static int ExecuteSql(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        //查看馆藏图书
        private void btn_book_find_Click(object sender, EventArgs e)
        {
            string bno=this.txt_bno.Text;
            string bname=this.txt_bname.Text;
            string bauthor=this.txt_bauthor.Text;
            string bpublish=this.txt_bpublish.Text;
            //string bsum=this.txt_bsum.Text;
            this.bookList.DataSource = Query("select * from Book where Bno like'%" + bno + "%' and Bname like'%" + bname + "%'and Bauthor like'%" + bauthor + "%'and Bpublish like'%" + bpublish + "%'").Tables["Book"];
        }

        //添加图书
        private void btn_book_add_Click(object sender, EventArgs e)
        {
            book_add childrenForm = new book_add();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void btn_book_delete_Click(object sender, EventArgs e)
        {
            int a = bookList.CurrentRow.Index;//获取选中的行号
            string bno = bookList.Rows[a].Cells[0].Value.ToString().Trim();
            //获取该行的第 0 列
            string sql = "delete from Book where Bno='" + bno + "'";
            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功");
            }
        }

        private void btn_book_update_Click(object sender, EventArgs e)
        {
            int a = bookList.CurrentRow.Index;//获取选中行
            string[] str = new string[bookList.Columns.Count];//用于存放选中行的值
            for (int i = 0; i < bookList.Columns.Count; i++)//选中行的值放入 str 数组
            {
                str[i] = bookList.Rows[a].Cells[i].Value.ToString();
            }
            //
            book_update childrenForm = new book_update(str[0], str[1], str[2], str[3], str[4]);//用选中行的值初始化 Form3
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void book_Load(object sender, EventArgs e)
        {

        }
    }
}
