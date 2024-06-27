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
    public partial class Rinfo_add : Form
    {

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public Rinfo_add()
        {
            InitializeComponent();
        }

        protected string passwd = "";

        private void comboBox_rtitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_rtitle.Text.Equals("")) label_rcan.Text = "0";
            else if(comboBox_rtitle.Text.Equals("主任")) label_rcan.Text = "8";
            else if (comboBox_rtitle.Text.Equals("副主任")) label_rcan.Text = "5";
            else if (comboBox_rtitle.Text.Equals("职工")) label_rcan.Text = "3";
        }

        private void btn_Rinfo_add_check_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txt_rname.Text) || string.IsNullOrEmpty(comboBox_rsex.Text) ||
                string.IsNullOrEmpty(this.comboBox_rtitle.Text) || string.IsNullOrEmpty(this.txt_rdepartment.Text) ||
                string.IsNullOrEmpty(this.txt_rtel.Text) || string.IsNullOrEmpty(txt_rinfo_passwd1.Text) ||
                string.IsNullOrEmpty(txt_rinfo_passwd2.Text))
            {
                MessageBox.Show("请完整填写信息！");
                return;
            }

            if (!txt_rinfo_passwd2.Text.Equals(txt_rinfo_passwd1.Text))
            {
                MessageBox.Show("两次密码不一致！");
                return;
            }

            string passwd = txt_rinfo_passwd1.Text;
            string rname = this.txt_rname.Text;
            string rsex = (comboBox_rsex.Text.Equals("男")) ? "m" : "f";
            string rtitle = this.comboBox_rtitle.Text;
            string rdepartment = this.txt_rdepartment.Text;
            string rtel = this.txt_rtel.Text;

            // 创建连接和命令对象
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // 插入语句不包含 Rno 字段（因为是自增的）
                string sql = $"insert into Readers (Rname, Rsex, Rtitle, Rcan, Rborrow, Rdepartment, Rtel) " +
                             $"values ('{rname}', '{rsex}', '{rtitle}', 0, 0, '{rdepartment}', '{rtel}'); " +
                             "SELECT SCOPE_IDENTITY();"; // 获取自增字段的值

                // 执行插入操作并获取自增字段值
                SqlCommand cmd = new SqlCommand(sql, con);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string rno = result.ToString(); // 获取插入的自增字段值

                    // 插入登录信息
                    string sql2 = $"insert into login (account, passwd, permission) values ('{rno}', '{passwd}', 1)";
                    int rowsAffected = book.ExecuteSql(sql2); // 假设 ExecuteSql 返回受影响行数，这里只是示例

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"注册成功！读者编号为 {rno}");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败，请重试！");
                    }
                }
                else
                {
                    MessageBox.Show("注册失败，请重试！");
                }
            }
        }


    }
}
